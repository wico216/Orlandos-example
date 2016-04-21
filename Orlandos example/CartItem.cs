using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orlandos_example
{
    class CartItem
    {
        public int ProductID { get; private set; }
        public int Quantity;
        public double Tax;
        public double Subtotal;

        public CartItem(int id, int Qty, double tax ,double pSubtotal)
        {
            ProductID = id;
            Quantity = Qty;
            Tax = tax;
            Subtotal = pSubtotal;
        }      
    }
}
