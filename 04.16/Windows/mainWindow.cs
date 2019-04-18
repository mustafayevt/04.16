using _04._16.Controllers;
using _04._16.Entities;
using _04._16.Models;
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
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void invoiceBtn_Click(object sender, EventArgs e)
        {
            Invoice invoice1 = new Invoice(1, "PS4");
            InvoiceModel invoiceModel = new InvoiceModel();
            invoiceModel.invoices.Add(invoice1);

            new InvoiceController(new InvoiceForm(invoiceModel)).show();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            Product product1 = new Product(1, "xbox");
            StockModel stockModel = new StockModel();
            stockModel.products.Add(product1);

            new InvoiceController(new ProductWindow(stockModel)).show();
        }
    }
}
