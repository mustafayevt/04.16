using _04._16.Models;
using _04._16.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04._16.Windows
{
    public partial class ProductWindow : Form,iView
    {
        StockModel stock;
        public ProductWindow(StockModel stock)
        {
            InitializeComponent();
            this.stock = stock;
            dataGridView1.DataSource = stock.products;
        }

        public void ShowView()
        {
            Show();
        }
    }
}
