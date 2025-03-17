using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public interface IStockObserver
    {
        void OnStockLow(string product, int quantity);
    }

}
