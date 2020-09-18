namespace Simpel_Algoritme
{
    partial class Webshop
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnMaxPrice = new System.Windows.Forms.Button();
            this.btnAvgPrice = new System.Windows.Forms.Button();
            this.btnAllProducts = new System.Windows.Forms.Button();
            this.btnSortProducts = new System.Windows.Forms.Button();
            this.lbAllProducts = new System.Windows.Forms.ListBox();
            this.lbProductsMinPrice = new System.Windows.Forms.ListBox();
            this.tbMinPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 29);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(82, 61);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(164, 29);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(164, 81);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(120, 32);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name:";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(124, 84);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(34, 13);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "Price:";
            // 
            // btnMaxPrice
            // 
            this.btnMaxPrice.Location = new System.Drawing.Point(576, 48);
            this.btnMaxPrice.Name = "btnMaxPrice";
            this.btnMaxPrice.Size = new System.Drawing.Size(126, 53);
            this.btnMaxPrice.TabIndex = 5;
            this.btnMaxPrice.Text = "Maximum price is: ";
            this.btnMaxPrice.UseVisualStyleBackColor = true;
            this.btnMaxPrice.Click += new System.EventHandler(this.btnMaxPrice_Click);
            // 
            // btnAvgPrice
            // 
            this.btnAvgPrice.Location = new System.Drawing.Point(576, 107);
            this.btnAvgPrice.Name = "btnAvgPrice";
            this.btnAvgPrice.Size = new System.Drawing.Size(126, 53);
            this.btnAvgPrice.TabIndex = 6;
            this.btnAvgPrice.Text = "Average price is: ";
            this.btnAvgPrice.UseVisualStyleBackColor = true;
            this.btnAvgPrice.Click += new System.EventHandler(this.btnAvgPrice_Click);
            // 
            // btnAllProducts
            // 
            this.btnAllProducts.Location = new System.Drawing.Point(576, 166);
            this.btnAllProducts.Name = "btnAllProducts";
            this.btnAllProducts.Size = new System.Drawing.Size(126, 53);
            this.btnAllProducts.TabIndex = 7;
            this.btnAllProducts.Text = "All products from a certain price";
            this.btnAllProducts.UseVisualStyleBackColor = true;
            this.btnAllProducts.Click += new System.EventHandler(this.btnAllProducts_Click);
            // 
            // btnSortProducts
            // 
            this.btnSortProducts.Location = new System.Drawing.Point(576, 225);
            this.btnSortProducts.Name = "btnSortProducts";
            this.btnSortProducts.Size = new System.Drawing.Size(126, 53);
            this.btnSortProducts.TabIndex = 8;
            this.btnSortProducts.Text = "Sort Products";
            this.btnSortProducts.UseVisualStyleBackColor = true;
            this.btnSortProducts.Click += new System.EventHandler(this.btnSortProducts_Click);
            // 
            // lbAllProducts
            // 
            this.lbAllProducts.FormattingEnabled = true;
            this.lbAllProducts.Location = new System.Drawing.Point(12, 135);
            this.lbAllProducts.Name = "lbAllProducts";
            this.lbAllProducts.Size = new System.Drawing.Size(206, 238);
            this.lbAllProducts.TabIndex = 9;
            // 
            // lbProductsMinPrice
            // 
            this.lbProductsMinPrice.FormattingEnabled = true;
            this.lbProductsMinPrice.Location = new System.Drawing.Point(297, 135);
            this.lbProductsMinPrice.Name = "lbProductsMinPrice";
            this.lbProductsMinPrice.Size = new System.Drawing.Size(206, 238);
            this.lbProductsMinPrice.TabIndex = 10;
            // 
            // tbMinPrice
            // 
            this.tbMinPrice.Location = new System.Drawing.Point(708, 183);
            this.tbMinPrice.Name = "tbMinPrice";
            this.tbMinPrice.Size = new System.Drawing.Size(41, 20);
            this.tbMinPrice.TabIndex = 11;
            // 
            // Webshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMinPrice);
            this.Controls.Add(this.lbProductsMinPrice);
            this.Controls.Add(this.lbAllProducts);
            this.Controls.Add(this.btnSortProducts);
            this.Controls.Add(this.btnAllProducts);
            this.Controls.Add(this.btnAvgPrice);
            this.Controls.Add(this.btnMaxPrice);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddProduct);
            this.Name = "Webshop";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnMaxPrice;
        private System.Windows.Forms.Button btnAvgPrice;
        private System.Windows.Forms.Button btnAllProducts;
        private System.Windows.Forms.Button btnSortProducts;
        private System.Windows.Forms.ListBox lbAllProducts;
        private System.Windows.Forms.ListBox lbProductsMinPrice;
        private System.Windows.Forms.TextBox tbMinPrice;
    }
}

