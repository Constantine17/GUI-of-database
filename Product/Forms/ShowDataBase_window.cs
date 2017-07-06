using System;
using System.Windows.Forms;

namespace Product.Forms
{
    public partial class ShowDataBase_window : Form
    {
        public ShowDataBase_window()
        {
            InitializeComponent();
        }

        private void ShowDataBase_window_Load(object sender, EventArgs e)
        {
            this.get_productsTableAdapter.Fill(this.products_DataBaseDataSet.Get_products);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
