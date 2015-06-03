using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vitvarubutik_User.Utilities;

namespace Vitvarubutik_User
{
    public partial class Main : FixedForm
    {
        private List<int> indexes = new List<int>();
        private List<int> indexes_Connected = new List<int>();
        private string filter = "";
        private string categories = "";

        public Main()
        {
            InitializeComponent();
            UpdateProducts();
        }

        private void ExitButton_Click(object sender, EventArgs e) { Close(); }

        private void MyPurchasesButton_Click(object sender, EventArgs e)
        {
        }

        private void SearchTextBox_KeyClicked(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (!SearchTextBox.ContainsFocus)
                return;

            if (e.KeyCode == Keys.Return)
            {
                Search();

                SearchTextBox.Enabled = false;
                SearchTextBox.Enabled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                SearchTextBox.Text = "Sök efter...";
                SearchTextBox.Enabled = false;
                SearchTextBox.Enabled = true;
            }
        }

        private void Search()
        {
            SelectCategoryList.SelectedIndex = 0;
            string searchText = SearchTextBox.Text;

            filter =
                " WHERE Tillverkare LIKE '%" + searchText + "%' OR " +
                " Modell LIKE '%" + searchText + "%' OR " +
                " Typ LIKE '%" + searchText + "%' OR " +
                " Energiklass LIKE '%" + searchText + "%'";

            UpdateProducts();
        }

        private void SelectCategoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectCategoryList.SelectedIndex <= 0)
            {
                SelectFilterList.Visible = false;

                filter = "";
                categories = "";

                UpdateProducts();
                return;
            }

            categories = SelectCategoryList.Items[SelectCategoryList.SelectedIndex].ToString();

            UpdateCategoryList();
        }

        /// <summary>
        /// Controlls CategoryList, only add categories that already exists in the database
        /// </summary>

        public void UpdateCategoryList()
        {
            SelectFilterList.Visible = true;

            MySqlDataReader reader = Connection.RunQuery(" SELECT " + categories + " FROM Produkt GROUP BY " + categories);
            if (reader == null) return;

            SelectFilterList.Items.Clear();
            while (reader.Read())
            {
                SelectFilterList.Items.Add(reader.GetString(0));
            }

            reader.Close();
            Connection.CloseConnection();
        }

        /// <summary>
        /// Checks for MouseClick Event.
        /// When triggered, wait until event has finnished.
        /// Then Update CategoryList.
        /// </summary>

        private void SelectFilterList_Click(object sender, EventArgs e)
        {
            BeginInvoke(new MethodInvoker(ShowCategories), null);
        }

        /// <summary>
        /// Updates CategoryList.
        /// If no items are checked, disable RemoveCategoryButton.
        /// Updates products, in case user just unchecked the last category.
        /// If user checked a category or there are more checked items left, we want to filter the products accordingly.
        /// Loop through every checked item and add its name to our filter.
        /// Update products and enable RemoveCategoryButton.
        /// </summary>

        private void ShowCategories()
        {
            if (SelectFilterList.CheckedItems.Count <= 0)
            {
                filter = "";
                UpdateProducts();
                return;
            }

            filter = " WHERE Produkt." + categories + " = ";

            for (int i = 0; i < SelectFilterList.CheckedItems.Count; i++)
            {
                if (i < SelectFilterList.CheckedItems.Count - 1)
                    filter += " '" + SelectFilterList.CheckedItems[i].ToString() + "' OR Produkt." + categories + " = ";
                else
                    filter += " '" + SelectFilterList.CheckedItems[i].ToString() + "'";
            }

            UpdateProducts();
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedIndex < 0) return;

            ConnectedProductList.SelectedIndex = -1;

            int id = indexes[ProductList.SelectedIndex];

            MySqlDataReader reader = Connection.RunQuery(
                                    " SELECT Produkt.Tillverkare, Produkt.Modell, Produkt.Typ, Produkt.Energiklass, Produkt.Beskrivning, Produkt.Bild_Länk, "
                                  + " IFNULL(CAST(SUM(Produkt.Pris * (1 - ( Kampanj.Rabatt / 100))) AS UNSIGNED), Produkt.Pris), Produkt.Lagerantal FROM IngårI "
                                  + " RIGHT JOIN Produkt ON IngårI.Artikelnummer = Produkt.Artikelnummer LEFT JOIN Kampanj ON Kampanj.KampanjID = IngårI.KampanjID WHERE Produkt.Artikelnummer = " + id + " GROUP BY Produkt.Artikelnummer ");
            if (reader == null) return;

            TillverkareLabel.Text = "";
            ModellLabel.Text = "";
            KategoriLabel.Text = "";
            EnergiklassLabel.Text = "";
            BeskrivningTextBox.Text = "";
            PrisLabel.Text = "";
            LagerstatusLabel.Text = "";


            while (reader.Read())
            {
                TillverkareLabel.Text = reader.GetString(0);
                ModellLabel.Text = reader.GetString(1);
                KategoriLabel.Text = reader.GetString(2);
                EnergiklassLabel.Text = reader.GetString(3);
                BeskrivningTextBox.Text = reader.GetString(4);
                ProductPicture.Load(reader.GetString(5));
                PrisLabel.Text = reader.GetString(6);
                LagerstatusLabel.Text = reader.GetString(7);
            }

            reader.Close();
            Connection.CloseConnection();

            GetConnectedProducts();
        }

        private void GetConnectedProducts()
        {
            ConnectedProductList.Items.Clear();
            indexes_Connected.Clear();

            if (ProductList.SelectedIndex < 0) return;

            int id = indexes[ProductList.SelectedIndex];

            MySqlDataReader reader = Connection.RunQuery(
                                    " SELECT Produkt.Artikelnummer, Produkt.Tillverkare, Produkt.Modell, Produkt.Typ, IFNULL(CAST(SUM(Produkt.Pris * (1 - ( Kampanj.Rabatt / 100))) AS UNSIGNED), Produkt.Pris) FROM KoppladTill "
                                  + " LEFT JOIN IngårI ON KoppladTill.KoppladProdukt = IngårI.Artikelnummer "
                                  + " RIGHT JOIN Produkt ON KoppladTill.KoppladProdukt = Produkt.Artikelnummer LEFT JOIN Kampanj ON Kampanj.KampanjID = IngårI.KampanjID WHERE KoppladTill.VisadProdukt = " + id + " GROUP BY Produkt.Artikelnummer ");
            if (reader == null) return;

            while (reader.Read())
            {
                indexes_Connected.Add(reader.GetInt32(0));
                string line = reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3) + ", " + " Pris: " + reader.GetString(4);
                ConnectedProductList.Items.Add(line);
            }

            reader.Close();
            Connection.CloseConnection();
        }

        /// <summary>
        /// Asks database for information about every product
        /// Adds it to product list and displaying
        /// </summary>

        public void UpdateProducts()
        {
            MySqlDataReader reader = Connection.RunQuery("SELECT Produkt.Artikelnummer, Produkt.Tillverkare, Produkt.Modell, Produkt.Typ, IFNULL(CAST(SUM(Produkt.Pris * (1 - ( Kampanj.Rabatt / 100))) AS UNSIGNED), Produkt.Pris) FROM IngårI RIGHT JOIN Produkt ON IngårI.Artikelnummer = Produkt.Artikelnummer LEFT JOIN Kampanj ON Kampanj.KampanjID = IngårI.KampanjID " + filter + " GROUP BY Produkt.Artikelnummer");
            if (reader == null) return;

            ProductList.Items.Clear();
            indexes.Clear();

            while (reader.Read())
            {
                indexes.Add(reader.GetInt32(0));
                string line = reader.GetString(1) + ", " + reader.GetString(2) + ", " + reader.GetString(3) + ", " + " Pris: " + reader.GetString(4);
                ProductList.Items.Add(line);
            }

            reader.Close();
            Connection.CloseConnection();
        }

        private void ConnectedProductList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.ConnectedProductList.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                int id = indexes_Connected[ConnectedProductList.SelectedIndex];

                foreach (int i in SelectFilterList.CheckedIndices)
                {
                    SelectFilterList.SetItemCheckState(i, CheckState.Unchecked);
                }

                Predicate<int> findProduct = (int a) => { return a == id; };

                ProductList.SelectedIndex = indexes.FindIndex(findProduct);

                MySqlDataReader reader = Connection.RunQuery(
                                        " SELECT Produkt.Tillverkare, Produkt.Modell, Produkt.Typ, Produkt.Energiklass, Produkt.Beskrivning, Produkt.Bild_Länk, "
                                      + " IFNULL(CAST(SUM(Produkt.Pris * (1 - ( Kampanj.Rabatt / 100))) AS UNSIGNED), Produkt.Pris), Produkt.Lagerantal FROM IngårI "
                                      + " RIGHT JOIN Produkt ON IngårI.Artikelnummer = Produkt.Artikelnummer LEFT JOIN Kampanj ON Kampanj.KampanjID = IngårI.KampanjID WHERE Produkt.Artikelnummer = " + id + " GROUP BY Produkt.Artikelnummer ");

                if (reader == null) return;

                TillverkareLabel.Text = "";
                ModellLabel.Text = "";
                KategoriLabel.Text = "";
                EnergiklassLabel.Text = "";
                BeskrivningTextBox.Text = "";
                PrisLabel.Text = "";
                LagerstatusLabel.Text = "";


                while (reader.Read())
                {
                    TillverkareLabel.Text = reader.GetString(0);
                    ModellLabel.Text = reader.GetString(1);
                    KategoriLabel.Text = reader.GetString(2);
                    EnergiklassLabel.Text = reader.GetString(3);
                    BeskrivningTextBox.Text = reader.GetString(4);
                    ProductPicture.Load(reader.GetString(5));
                    PrisLabel.Text = reader.GetString(6);
                    LagerstatusLabel.Text = reader.GetString(7);
                }

                reader.Close();
                Connection.CloseConnection();

                GetConnectedProducts();
                UpdateProducts();
            }
        }
    }
}
