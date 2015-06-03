namespace Vitvarubutik_User
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ListBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SelectFilterList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BeskrivningTextBox = new System.Windows.Forms.RichTextBox();
            this.ProductPicture = new System.Windows.Forms.PictureBox();
            this.SelectCategoryList = new System.Windows.Forms.ComboBox();
            this.TillverkareLabel = new System.Windows.Forms.Label();
            this.ModellLabel = new System.Windows.Forms.Label();
            this.KategoriLabel = new System.Windows.Forms.Label();
            this.EnergiklassLabel = new System.Windows.Forms.Label();
            this.LagerstatusLabel = new System.Windows.Forms.Label();
            this.PrisLabel = new System.Windows.Forms.Label();
            this.ConnectedProductList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1060, 542);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 52);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Avsluta";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(260, 21);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(685, 56);
            this.HeaderLabel.TabIndex = 4;
            this.HeaderLabel.Text = "BLOMSTERMÅLA VITVARUBUTIK";
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(270, 97);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(675, 212);
            this.ProductList.TabIndex = 5;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.AcceptsReturn = true;
            this.SearchTextBox.Location = new System.Drawing.Point(25, 103);
            this.SearchTextBox.MaxLength = 15;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(145, 20);
            this.SearchTextBox.TabIndex = 6;
            this.SearchTextBox.Text = "Sök...";
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyClicked);
            // 
            // SelectFilterList
            // 
            this.SelectFilterList.CheckOnClick = true;
            this.SelectFilterList.FormattingEnabled = true;
            this.SelectFilterList.Location = new System.Drawing.Point(12, 202);
            this.SelectFilterList.Name = "SelectFilterList";
            this.SelectFilterList.Size = new System.Drawing.Size(172, 109);
            this.SelectFilterList.TabIndex = 7;
            this.SelectFilterList.Visible = false;
            this.SelectFilterList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SelectFilterList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Filtrera efter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tillverkare:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Modell:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kategori:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Energiklass:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(906, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pris:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(183, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lagerstatus:";
            // 
            // BeskrivningTextBox
            // 
            this.BeskrivningTextBox.Location = new System.Drawing.Point(364, 315);
            this.BeskrivningTextBox.Name = "BeskrivningTextBox";
            this.BeskrivningTextBox.ReadOnly = true;
            this.BeskrivningTextBox.Size = new System.Drawing.Size(319, 175);
            this.BeskrivningTextBox.TabIndex = 18;
            this.BeskrivningTextBox.Text = "";
            // 
            // ProductPicture
            // 
            this.ProductPicture.Location = new System.Drawing.Point(689, 315);
            this.ProductPicture.Name = "ProductPicture";
            this.ProductPicture.Size = new System.Drawing.Size(188, 175);
            this.ProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPicture.TabIndex = 19;
            this.ProductPicture.TabStop = false;
            // 
            // SelectCategoryList
            // 
            this.SelectCategoryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectCategoryList.FormattingEnabled = true;
            this.SelectCategoryList.Items.AddRange(new object[] {
            "Filtrera efter....",
            "Tillverkare",
            "Typ",
            "Energiklass",
            "Pris"});
            this.SelectCategoryList.Location = new System.Drawing.Point(25, 175);
            this.SelectCategoryList.Name = "SelectCategoryList";
            this.SelectCategoryList.Size = new System.Drawing.Size(121, 21);
            this.SelectCategoryList.TabIndex = 9;
            this.SelectCategoryList.SelectedIndexChanged += new System.EventHandler(this.SelectCategoryList_SelectedIndexChanged);
            // 
            // TillverkareLabel
            // 
            this.TillverkareLabel.AutoSize = true;
            this.TillverkareLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TillverkareLabel.Location = new System.Drawing.Point(267, 329);
            this.TillverkareLabel.Name = "TillverkareLabel";
            this.TillverkareLabel.Size = new System.Drawing.Size(0, 17);
            this.TillverkareLabel.TabIndex = 20;
            // 
            // ModellLabel
            // 
            this.ModellLabel.AutoSize = true;
            this.ModellLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModellLabel.Location = new System.Drawing.Point(267, 357);
            this.ModellLabel.Name = "ModellLabel";
            this.ModellLabel.Size = new System.Drawing.Size(0, 17);
            this.ModellLabel.TabIndex = 21;
            // 
            // KategoriLabel
            // 
            this.KategoriLabel.AutoSize = true;
            this.KategoriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KategoriLabel.Location = new System.Drawing.Point(267, 390);
            this.KategoriLabel.Name = "KategoriLabel";
            this.KategoriLabel.Size = new System.Drawing.Size(0, 17);
            this.KategoriLabel.TabIndex = 22;
            // 
            // EnergiklassLabel
            // 
            this.EnergiklassLabel.AutoSize = true;
            this.EnergiklassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergiklassLabel.Location = new System.Drawing.Point(267, 420);
            this.EnergiklassLabel.Name = "EnergiklassLabel";
            this.EnergiklassLabel.Size = new System.Drawing.Size(0, 17);
            this.EnergiklassLabel.TabIndex = 23;
            // 
            // LagerstatusLabel
            // 
            this.LagerstatusLabel.AutoSize = true;
            this.LagerstatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LagerstatusLabel.Location = new System.Drawing.Point(267, 452);
            this.LagerstatusLabel.Name = "LagerstatusLabel";
            this.LagerstatusLabel.Size = new System.Drawing.Size(0, 17);
            this.LagerstatusLabel.TabIndex = 24;
            // 
            // PrisLabel
            // 
            this.PrisLabel.AutoSize = true;
            this.PrisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrisLabel.Location = new System.Drawing.Point(951, 332);
            this.PrisLabel.Name = "PrisLabel";
            this.PrisLabel.Size = new System.Drawing.Size(0, 17);
            this.PrisLabel.TabIndex = 25;
            // 
            // ConnectedProductList
            // 
            this.ConnectedProductList.FormattingEnabled = true;
            this.ConnectedProductList.Location = new System.Drawing.Point(270, 542);
            this.ConnectedProductList.Name = "ConnectedProductList";
            this.ConnectedProductList.Size = new System.Drawing.Size(675, 121);
            this.ConnectedProductList.TabIndex = 26;
            this.ConnectedProductList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ConnectedProductList_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Produkter du kanske även gillar";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 678);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConnectedProductList);
            this.Controls.Add(this.PrisLabel);
            this.Controls.Add(this.LagerstatusLabel);
            this.Controls.Add(this.EnergiklassLabel);
            this.Controls.Add(this.KategoriLabel);
            this.Controls.Add(this.ModellLabel);
            this.Controls.Add(this.TillverkareLabel);
            this.Controls.Add(this.ProductPicture);
            this.Controls.Add(this.BeskrivningTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectCategoryList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectFilterList);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ExitButton);
            this.Name = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.CheckedListBox SelectFilterList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox BeskrivningTextBox;
        private System.Windows.Forms.PictureBox ProductPicture;
        private System.Windows.Forms.ComboBox SelectCategoryList;
        private System.Windows.Forms.Label TillverkareLabel;
        private System.Windows.Forms.Label ModellLabel;
        private System.Windows.Forms.Label KategoriLabel;
        private System.Windows.Forms.Label EnergiklassLabel;
        private System.Windows.Forms.Label LagerstatusLabel;
        private System.Windows.Forms.Label PrisLabel;
        private System.Windows.Forms.ListBox ConnectedProductList;
        private System.Windows.Forms.Label label2;
    }
}

