namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategory2 = new System.Windows.Forms.ComboBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName2 = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblProductName2 = new System.Windows.Forms.Label();
            this.gpxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxUpdateCategoryID = new System.Windows.Forms.ComboBox();
            this.tbxQuantitiyPerUnitUpd = new System.Windows.Forms.TextBox();
            this.tbxStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gpxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(18, 306);
            this.dgwProduct.Margin = new System.Windows.Forms.Padding(4);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(1185, 218);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(20, 18);
            this.gbxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCategory.Size = new System.Drawing.Size(1183, 138);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara:";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(100, 53);
            this.cbxCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(490, 26);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(18, 57);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(67, 18);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori:";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(20, 165);
            this.gbxProductName.Margin = new System.Windows.Forms.Padding(4);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Padding = new System.Windows.Forms.Padding(4);
            this.gbxProductName.Size = new System.Drawing.Size(1183, 133);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adına Göre Ara:";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(100, 76);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(490, 24);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(15, 76);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(68, 18);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı:";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategory2);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStock);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPrice);
            this.gbxProductAdd.Controls.Add(this.tbxProductName2);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.lblStock);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblCategoryID);
            this.gbxProductAdd.Controls.Add(this.lblProductName2);
            this.gbxProductAdd.Location = new System.Drawing.Point(18, 578);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(1189, 148);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni Ürün Ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(700, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 37);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategory2
            // 
            this.cbxCategory2.FormattingEnabled = true;
            this.cbxCategory2.Location = new System.Drawing.Point(79, 88);
            this.cbxCategory2.Name = "cbxCategory2";
            this.cbxCategory2.Size = new System.Drawing.Size(136, 26);
            this.cbxCategory2.TabIndex = 9;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(727, 43);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(120, 24);
            this.tbxQuantityPerUnit.TabIndex = 8;
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(414, 93);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(129, 24);
            this.tbxStock.TabIndex = 7;
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(414, 43);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(129, 24);
            this.tbxUnitPrice.TabIndex = 6;
            // 
            // tbxProductName2
            // 
            this.tbxProductName2.Location = new System.Drawing.Point(80, 43);
            this.tbxProductName2.Name = "tbxProductName2";
            this.tbxProductName2.Size = new System.Drawing.Size(135, 24);
            this.tbxProductName2.TabIndex = 5;
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(635, 46);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(86, 18);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Birim Adedi:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(325, 96);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(83, 18);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Stok Adedi:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(365, 46);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(43, 18);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Fiyat:";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(6, 96);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(67, 18);
            this.lblCategoryID.TabIndex = 1;
            this.lblCategoryID.Text = "Kategori:";
            // 
            // lblProductName2
            // 
            this.lblProductName2.AutoSize = true;
            this.lblProductName2.Location = new System.Drawing.Point(6, 46);
            this.lblProductName2.Name = "lblProductName2";
            this.lblProductName2.Size = new System.Drawing.Size(68, 18);
            this.lblProductName2.TabIndex = 0;
            this.lblProductName2.Text = "Ürün Adı:";
            // 
            // gpxUpdate
            // 
            this.gpxUpdate.Controls.Add(this.btnUpdate);
            this.gpxUpdate.Controls.Add(this.cbxUpdateCategoryID);
            this.gpxUpdate.Controls.Add(this.tbxQuantitiyPerUnitUpd);
            this.gpxUpdate.Controls.Add(this.tbxStockUpdate);
            this.gpxUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gpxUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gpxUpdate.Controls.Add(this.label1);
            this.gpxUpdate.Controls.Add(this.label2);
            this.gpxUpdate.Controls.Add(this.label3);
            this.gpxUpdate.Controls.Add(this.label4);
            this.gpxUpdate.Controls.Add(this.label5);
            this.gpxUpdate.Location = new System.Drawing.Point(20, 732);
            this.gpxUpdate.Name = "gpxUpdate";
            this.gpxUpdate.Size = new System.Drawing.Size(1189, 148);
            this.gpxUpdate.TabIndex = 11;
            this.gpxUpdate.TabStop = false;
            this.gpxUpdate.Text = "Ürün Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(700, 87);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 37);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxUpdateCategoryID
            // 
            this.cbxUpdateCategoryID.FormattingEnabled = true;
            this.cbxUpdateCategoryID.Location = new System.Drawing.Point(79, 88);
            this.cbxUpdateCategoryID.Name = "cbxUpdateCategoryID";
            this.cbxUpdateCategoryID.Size = new System.Drawing.Size(136, 26);
            this.cbxUpdateCategoryID.TabIndex = 9;
            // 
            // tbxQuantitiyPerUnitUpd
            // 
            this.tbxQuantitiyPerUnitUpd.Location = new System.Drawing.Point(727, 43);
            this.tbxQuantitiyPerUnitUpd.Name = "tbxQuantitiyPerUnitUpd";
            this.tbxQuantitiyPerUnitUpd.Size = new System.Drawing.Size(120, 24);
            this.tbxQuantitiyPerUnitUpd.TabIndex = 8;
            // 
            // tbxStockUpdate
            // 
            this.tbxStockUpdate.Location = new System.Drawing.Point(414, 93);
            this.tbxStockUpdate.Name = "tbxStockUpdate";
            this.tbxStockUpdate.Size = new System.Drawing.Size(129, 24);
            this.tbxStockUpdate.TabIndex = 7;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(414, 43);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(129, 24);
            this.tbxUnitPriceUpdate.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(80, 43);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(135, 24);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(635, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birim Adedi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stok Adedi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kategori:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ürün Adı:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(20, 531);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 40);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 902);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gpxUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gpxUpdate.ResumeLayout(false);
            this.gpxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategory2;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.TextBox tbxUnitPrice;
        private System.Windows.Forms.TextBox tbxProductName2;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblProductName2;
        private System.Windows.Forms.GroupBox gpxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateCategoryID;
        private System.Windows.Forms.TextBox tbxQuantitiyPerUnitUpd;
        private System.Windows.Forms.TextBox tbxStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemove;
    }
}

