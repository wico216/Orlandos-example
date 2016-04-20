using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orlandos_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopping_Cart Store = new Shopping_Cart();
            Store.ShowCategories();
            Store.ShowProducts();
            Store.ShowCart();
            Store.RemoveFromCart(1);
            Store.ShowCart();
            
            Console.ReadLine();
        }
    }
}
 