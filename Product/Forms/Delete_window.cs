using System;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Product.Forms
{
    public partial class Delete_window : Form
    {
        public Delete_window()
        {
            InitializeComponent();
        }

        private void DELL_Click(object sender, EventArgs e)
        {
            try
            {
                string directory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\Product\Product\DataBase\Products_DataBase.mdf;Integrated Security=True";
                string sql = @"Delete From Product Where Name = '" + textBox1.Text + "'";

                SqlConnection connection = new SqlConnection(directory);
                connection.Open();
                SqlCommand update = new SqlCommand(sql, connection);
                update.ExecuteNonQuery();

                this.Close();
            }
            catch { this.error.Text = "Incorrect input!"; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
