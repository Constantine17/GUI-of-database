namespace Product
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Show_window = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Show_window
            // 
            this.Show_window.Location = new System.Drawing.Point(12, 29);
            this.Show_window.Name = "Show_window";
            this.Show_window.Size = new System.Drawing.Size(188, 36);
            this.Show_window.TabIndex = 0;
            this.Show_window.Text = "View All Products";
            this.Show_window.UseVisualStyleBackColor = true;
            this.Show_window.Click += new System.EventHandler(this.Show_window_Click);
            // 
            // Index
            // 
            this.Index.Location = new System.Drawing.Point(12, 111);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(188, 23);
            this.Index.TabIndex = 1;
            this.Index.Text = "Index price all products";
            this.Index.UseVisualStyleBackColor = true;
            this.Index.Click += new System.EventHandler(this.Index_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 140);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(188, 23);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Remove by product\'s name";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 82);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(188, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add new product to data base";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 195);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.Show_window);
            this.Name = "MainForm";
            this.Text = "Products";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Show_window;
        private System.Windows.Forms.Button Index;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
    }
}

