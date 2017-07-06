namespace Product.Forms
{
    partial class Add_window
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
            this.components = new System.ComponentModel.Container();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_quantity = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_type = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.products_DataBaseDataSet = new Product.Products_DataBaseDataSet();
            this.typeTableAdapter = new Product.Products_DataBaseDataSetTableAdapters.TypeTableAdapter();
            this.productTableAdapter1 = new Product.Products_DataBaseDataSetTableAdapters.ProductTableAdapter();
            this.Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_DataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(137, 41);
            this.text_name.Name = "text_name";
            this.text_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_name.Size = new System.Drawing.Size(121, 20);
            this.text_name.TabIndex = 0;
            // 
            // text_quantity
            // 
            this.text_quantity.Location = new System.Drawing.Point(137, 69);
            this.text_quantity.Name = "text_quantity";
            this.text_quantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_quantity.Size = new System.Drawing.Size(121, 20);
            this.text_quantity.TabIndex = 1;
            // 
            // text_price
            // 
            this.text_price.Location = new System.Drawing.Point(137, 93);
            this.text_price.Name = "text_price";
            this.text_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.text_price.Size = new System.Drawing.Size(121, 20);
            this.text_price.TabIndex = 2;
            // 
            // text_type
            // 
            this.text_type.DataSource = this.typeBindingSource;
            this.text_type.DisplayMember = "TypeName";
            this.text_type.FormattingEnabled = true;
            this.text_type.Location = new System.Drawing.Point(137, 117);
            this.text_type.Name = "text_type";
            this.text_type.Size = new System.Drawing.Size(121, 21);
            this.text_type.TabIndex = 3;
            this.text_type.ValueMember = "ID";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.products_DataBaseDataSet;
            // 
            // products_DataBaseDataSet
            // 
            this.products_DataBaseDataSet.DataSetName = "Products_DataBaseDataSet";
            this.products_DataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(56, 155);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product\'s name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(137, 155);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 9;
            this.close.Text = "Cansel";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(91, 9);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 16);
            this.error.TabIndex = 10;
            // 
            // Add_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 205);
            this.ControlBox = false;
            this.Controls.Add(this.error);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.text_type);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_quantity);
            this.Controls.Add(this.text_name);
            this.Name = "Add_window";
            this.Text = "New product";
            this.Load += new System.EventHandler(this.Add_window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.products_DataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_quantity;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.ComboBox text_type;
        private Products_DataBaseDataSet products_DataBaseDataSet;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private Products_DataBaseDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private Products_DataBaseDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label error;
    }
}