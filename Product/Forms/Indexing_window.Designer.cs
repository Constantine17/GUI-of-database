namespace Product.Forms
{
    partial class Indexing_window
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
            this.Index = new System.Windows.Forms.Button();
            this.Value_index = new System.Windows.Forms.TextBox();
            this.productTableAdapter1 = new Product.Products_DataBaseDataSetTableAdapters.ProductTableAdapter();
            this.products_DataBaseDataSet1 = new Product.Products_DataBaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.products_DataBaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Index
            // 
            this.Index.Location = new System.Drawing.Point(296, 30);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(75, 23);
            this.Index.TabIndex = 0;
            this.Index.Text = "OK";
            this.Index.UseVisualStyleBackColor = true;
            this.Index.Click += new System.EventHandler(this.Index_Click);
            // 
            // Value_index
            // 
            this.Value_index.Location = new System.Drawing.Point(161, 33);
            this.Value_index.Name = "Value_index";
            this.Value_index.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Value_index.Size = new System.Drawing.Size(100, 20);
            this.Value_index.TabIndex = 1;
            this.Value_index.TextChanged += new System.EventHandler(this.Delete_name_TextChanged);
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // products_DataBaseDataSet1
            // 
            this.products_DataBaseDataSet1.DataSetName = "Products_DataBaseDataSet";
            this.products_DataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please, enter index";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(267, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(158, 9);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 16);
            this.error.TabIndex = 4;
            // 
            // Indexing_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 78);
            this.ControlBox = false;
            this.Controls.Add(this.error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Value_index);
            this.Controls.Add(this.Index);
            this.Name = "Indexing_window";
            this.Text = "Indexing";
            ((System.ComponentModel.ISupportInitialize)(this.products_DataBaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Index;
        private System.Windows.Forms.TextBox Value_index;
        private Products_DataBaseDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private Products_DataBaseDataSet products_DataBaseDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label error;
    }
}