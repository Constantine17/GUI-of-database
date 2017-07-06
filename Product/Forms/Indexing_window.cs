using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Product.Forms
{
    public partial class Indexing_window : Form
    {
        public Indexing_window()
        {
            InitializeComponent();
        }

        private void Index_Click(object sender, EventArgs e)
        {
            try
            {
                string directory = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\Product\Product\DataBase\Products_DataBase.mdf;Integrated Security=True";
                float indexing = 1+ Convert.ToSingle(Value_index.Text) / 100;
                string sql = @"UPDATE  Product SET Product.Price = (Product.Price * " + Convert.ToString(indexing, System.Globalization.CultureInfo.InvariantCulture) + " ) ";

                SqlConnection connection = new SqlConnection(directory);
                connection.Open();
                SqlCommand update = new SqlCommand(sql, connection);
                update.ExecuteNonQuery();

                productTableAdapter1.Update(products_DataBaseDataSet1.Product);
                this.Close();
            }
            catch
            {
                this.error.Text = "Incorrect input!";
            }
        }

        private void Delete_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
