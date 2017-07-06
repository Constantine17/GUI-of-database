using System;
using System.Windows.Forms;

namespace Product.Forms
{
    public partial class Add_window : Form
    {
        public Add_window()
        {
            InitializeComponent();
        }

        private void Add_window_Load(object sender, EventArgs e)
        {
            this.typeTableAdapter.Fill(this.products_DataBaseDataSet.Type);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string NAME = text_name.Text;
                float QUANTITY = Convert.ToSingle(text_quantity.Text);
                decimal PRICE = Convert.ToDecimal(text_price.Text);
                int TYPE = Convert.ToInt32(text_type.SelectedValue);

                var newrow = products_DataBaseDataSet.Product.NewProductRow();

                newrow.Name = NAME;
                newrow.Quantity = QUANTITY;
                newrow.Price = PRICE;
                newrow.Type = TYPE;

                products_DataBaseDataSet.Product.Rows.Add(newrow);
                productTableAdapter1.Update(products_DataBaseDataSet.Product);

                this.Close();
            }
            catch { this.error.Text = "Incorrect input!"; }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
