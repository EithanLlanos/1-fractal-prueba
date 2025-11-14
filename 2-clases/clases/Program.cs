using System;
using clases;
using Microsoft.VisualBasic.CompilerServices;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto[] list = initProducts();
            showProducts(list);

        }



        static private Producto[] initProducts()
        {
            return new Producto[]
            {
                new Producto("Producto1", 10, 5.5),
                new Producto("Producto2", 13, 0.5),
                new Producto("Producto3", 16, 2.5),
                new Producto("Producto4", 17, 8.0)
            };
        }

        static private void showProducts(Producto[] products)
        {
            String productList = "";
            foreach (Producto product in products)
            {
                productList += "\n" + product.Name + " | " + product.Stock + " | " + product.Price;
            }

            productList = productList.Substring(1);
            
            Console.WriteLine(productList);
            
            
            
        }
    }
}