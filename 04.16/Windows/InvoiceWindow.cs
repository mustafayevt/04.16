using _04._16.Controllers;
using _04._16.Entities;
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
    public partial class InvoiceForm : Form,iView
    {
        InvoiceModel invoice;
        public InvoiceForm(InvoiceModel invoice)
        {
            InitializeComponent();
            this.invoice = invoice;
            dataGridView1.DataSource = invoice.invoices;
        }

        public void ShowView()
        {
            Show();
        }
    }
}
