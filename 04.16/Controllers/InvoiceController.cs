using _04._16.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._16.Controllers
{
    class InvoiceController
    {
        iView view;
        public InvoiceController(iView view)
        {
            this.view = view;
        }

        public void show()
        {
            view.ShowView();
        }
    }
}
