using _04._16.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._16.Controllers
{
    class StockController
    {
        iView view;
        public StockController(iView view)
        {
            this.view = view;
        }

        public void show()
        {
            view.ShowView();
        }
    }
}
