using System;
using System.Collections.Generic;

namespace Orlandos_example
{
    class Shopping_Cart
    {

        List<Category> _category = new List<Orlandos_example.Category>()
        {
            new Category(0, "iPhone"),
            new Category(1, "Samsung"),
            new Category(2, "BlackBerry"),
            new Category(3, "Nokia")
         };

        List<Product> _product = new List<Orlandos_example.Product>() {
            new Product(0,"Product1","This is my Product",5.23, 14.99),
            new Product(1, "Product2", "This is my Product", 4.23, 16.99),
            new Product(2, "Product3", "This is my Product", 5.23, 17.99),
            new Product(3, "Product4", "This is my Product", 2.23, 18.99)
         };

        List<CartItem> _cartitem = new List<CartItem>()
        {
            new CartItem(1,1,2.5,6),
             new CartItem(2,3,2.5,6)
        };

        

        //Category Categoryt1 = new Category(1, "iPhone");
        //Category Categoryt2 = new Category(2, "Samsung");
        //Category Categoryt3 = new Category(3, "BlackBerry");
        //Category Categoryt4 = new Category(4, "Nokia");

        //Product Product1 = new Product(1,"Product1","This is my Product",5.23, 14.99);
        //Product Product2 = new Product(2, "Product2", "This is my Product", 4.23, 16.99);
        //Product Product3 = new Product(3, "Product3", "This is my Product", 5.23, 17.99);
        //Product Product4 = new Product(4, "Product4", "This is my Product", 2.23, 18.99);


        //List<string> Cart = new List<string>();

        public void ShowCategories()
        {

            for (int i = 0; i < _category.Count; i++)
            {
                Console.WriteLine(_category[i].CategoryName);
            }

        }


        public void ShowProducts()
        {

            for (int i = 0; i < _product.Count; i++)
            {
                Console.WriteLine(_product[i].ProductName);
            }

        }

        public void AddToCart(int id, int Qty)
        {
            _cartitem.Add(new CartItem(_product[id].ProductId, Qty, 0.00, (_product[id].ProductPrice * Qty)));

            //_product.Find(item.ProductId)
            //_cartitem.Add(new CartItem(item.ProductId,Qty,0.00,(item.ProductPrice*Qty)));
        }

        public void RemoveFromCart(int ProductRow)
        {
            _cartitem.RemoveAt(ProductRow - 1);
        }

        public void ShowCart()
        {
            foreach (var item in _cartitem)
            {
                
                Console.WriteLine(item.ProductID);
            }
        }
    }
}
