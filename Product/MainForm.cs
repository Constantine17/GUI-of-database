using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Product.Forms;

namespace Product
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Show_window_Click(object sender, EventArgs e)
        {
            ShowDataBase_window window = new ShowDataBase_window();
            window.ShowDialog();
        }

        private void Index_Click(object sender, EventArgs e)
        {
            Indexing_window window = new Indexing_window();
            window.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete_window window = new Delete_window();
            window.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add_window window = new Add_window();
            window.ShowDialog();
        }
    }
}
