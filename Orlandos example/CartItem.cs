using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orlandos_example
{
    class CartItem
    {
        public int ProductID;
        public int Quantity;
        public double Tax;
        public double Subtotal;

        public CartItem(int ID, int Qty, double pTax ,double pSubtotal)
        {
            ProductID = ID;
            Quantity = Qty;
            Tax = pTax;
            Subtotal = pSubtotal;
        }      
    }
}
