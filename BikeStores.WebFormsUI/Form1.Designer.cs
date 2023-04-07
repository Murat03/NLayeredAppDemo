namespace BikeStores.WebFormsUI
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
            this.gbxSelect = new System.Windows.Forms.GroupBox();
            this.cbxSelect = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.cbxBrand = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxModelYear = new System.Windows.Forms.TextBox();
            this.lblModelYear = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxBrandUpdate = new System.Windows.Forms.ComboBox();
            this.lblBrandUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.tbxModelYearUpdate = new System.Windows.Forms.TextBox();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblModelYearUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxSelect.SuspendLayout();
            this.gbxSearch.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 127);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(776, 171);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxSelect
            // 
            this.gbxSelect.Controls.Add(this.cbxSelect);
            this.gbxSelect.Controls.Add(this.lblSelect);
            this.gbxSelect.Location = new System.Drawing.Point(12, 56);
            this.gbxSelect.Name = "gbxSelect";
            this.gbxSelect.Size = new System.Drawing.Size(385, 65);
            this.gbxSelect.TabIndex = 1;
            this.gbxSelect.TabStop = false;
            this.gbxSelect.Text = "Select";
            // 
            // cbxSelect
            // 
            this.cbxSelect.FormattingEnabled = true;
            this.cbxSelect.Location = new System.Drawing.Point(79, 21);
            this.cbxSelect.Name = "cbxSelect";
            this.cbxSelect.Size = new System.Drawing.Size(255, 24);
            this.cbxSelect.TabIndex = 1;
            this.cbxSelect.SelectedIndexChanged += new System.EventHandler(this.cbxSelect_SelectedIndexChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(28, 24);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(45, 16);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "Select";
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(409, 56);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(385, 65);
            this.gbxSearch.TabIndex = 2;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(84, 21);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(250, 22);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(28, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 16);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.cbxBrand);
            this.gbxAdd.Controls.Add(this.lblBrand);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.cbxCategory);
            this.gbxAdd.Controls.Add(this.tbxPrice);
            this.gbxAdd.Controls.Add(this.lblPrice);
            this.gbxAdd.Controls.Add(this.tbxModelYear);
            this.gbxAdd.Controls.Add(this.lblModelYear);
            this.gbxAdd.Controls.Add(this.lblCategory);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Location = new System.Drawing.Point(12, 304);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(385, 172);
            this.gbxAdd.TabIndex = 3;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add";
            // 
            // cbxBrand
            // 
            this.cbxBrand.FormattingEnabled = true;
            this.cbxBrand.Location = new System.Drawing.Point(270, 73);
            this.cbxBrand.Name = "cbxBrand";
            this.cbxBrand.Size = new System.Drawing.Size(109, 24);
            this.cbxBrand.TabIndex = 11;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(203, 77);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(43, 16);
            this.lblBrand.TabIndex = 10;
            this.lblBrand.Text = "Brand";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(269, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(87, 76);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(110, 24);
            this.cbxCategory.TabIndex = 8;
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(269, 33);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(110, 22);
            this.tbxPrice.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(203, 36);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 16);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price";
            // 
            // tbxModelYear
            // 
            this.tbxModelYear.Location = new System.Drawing.Point(87, 120);
            this.tbxModelYear.Name = "tbxModelYear";
            this.tbxModelYear.Size = new System.Drawing.Size(110, 22);
            this.tbxModelYear.TabIndex = 5;
            // 
            // lblModelYear
            // 
            this.lblModelYear.AutoSize = true;
            this.lblModelYear.Location = new System.Drawing.Point(8, 123);
            this.lblModelYear.Name = "lblModelYear";
            this.lblModelYear.Size = new System.Drawing.Size(77, 16);
            this.lblModelYear.TabIndex = 3;
            this.lblModelYear.Text = "Model Year";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(8, 80);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(62, 16);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(87, 33);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(110, 22);
            this.tbxName.TabIndex = 0;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cbxBrandUpdate);
            this.gbxUpdate.Controls.Add(this.lblBrandUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.cbxCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.tbxPriceUpdate);
            this.gbxUpdate.Controls.Add(this.lblProductNameUpdate);
            this.gbxUpdate.Controls.Add(this.lblPriceUpdate);
            this.gbxUpdate.Controls.Add(this.tbxProductNameUpdate);
            this.gbxUpdate.Controls.Add(this.tbxModelYearUpdate);
            this.gbxUpdate.Controls.Add(this.lblCategoryUpdate);
            this.gbxUpdate.Controls.Add(this.lblModelYearUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(400, 304);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(385, 172);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update";
            // 
            // cbxBrandUpdate
            // 
            this.cbxBrandUpdate.FormattingEnabled = true;
            this.cbxBrandUpdate.Location = new System.Drawing.Point(267, 69);
            this.cbxBrandUpdate.Name = "cbxBrandUpdate";
            this.cbxBrandUpdate.Size = new System.Drawing.Size(109, 24);
            this.cbxBrandUpdate.TabIndex = 13;
            // 
            // lblBrandUpdate
            // 
            this.lblBrandUpdate.AutoSize = true;
            this.lblBrandUpdate.Location = new System.Drawing.Point(204, 72);
            this.lblBrandUpdate.Name = "lblBrandUpdate";
            this.lblBrandUpdate.Size = new System.Drawing.Size(43, 16);
            this.lblBrandUpdate.TabIndex = 12;
            this.lblBrandUpdate.Text = "Brand";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(267, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(88, 73);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(109, 24);
            this.cbxCategoryUpdate.TabIndex = 9;
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.Location = new System.Drawing.Point(267, 33);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(110, 22);
            this.tbxPriceUpdate.TabIndex = 15;
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(6, 33);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(44, 16);
            this.lblProductNameUpdate.TabIndex = 9;
            this.lblProductNameUpdate.Text = "Name";
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Location = new System.Drawing.Point(204, 36);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(38, 16);
            this.lblPriceUpdate.TabIndex = 14;
            this.lblPriceUpdate.Text = "Price";
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(88, 33);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(110, 22);
            this.tbxProductNameUpdate.TabIndex = 8;
            // 
            // tbxModelYearUpdate
            // 
            this.tbxModelYearUpdate.Location = new System.Drawing.Point(88, 120);
            this.tbxModelYearUpdate.Name = "tbxModelYearUpdate";
            this.tbxModelYearUpdate.Size = new System.Drawing.Size(110, 22);
            this.tbxModelYearUpdate.TabIndex = 13;
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(6, 76);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(62, 16);
            this.lblCategoryUpdate.TabIndex = 10;
            this.lblCategoryUpdate.Text = "Category";
            // 
            // lblModelYearUpdate
            // 
            this.lblModelYearUpdate.AutoSize = true;
            this.lblModelYearUpdate.Location = new System.Drawing.Point(6, 123);
            this.lblModelYearUpdate.Name = "lblModelYearUpdate";
            this.lblModelYearUpdate.Size = new System.Drawing.Size(77, 16);
            this.lblModelYearUpdate.TabIndex = 11;
            this.lblModelYearUpdate.Text = "Model Year";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(521, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.gbxSelect);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxSelect.ResumeLayout(false);
            this.gbxSelect.PerformLayout();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxSelect;
        private System.Windows.Forms.ComboBox cbxSelect;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbxModelYear;
        private System.Windows.Forms.Label lblModelYear;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.TextBox tbxModelYearUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblModelYearUpdate;
        private System.Windows.Forms.ComboBox cbxBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cbxBrandUpdate;
        private System.Windows.Forms.Label lblBrandUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

