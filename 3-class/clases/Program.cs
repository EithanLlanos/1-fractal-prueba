using System;
using clases;
using Microsoft.VisualBasic.CompilerServices;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Producto[] list = initProducts();
            // showProducts(list);

            // CuentaBancaria cuenta = new CuentaBancaria("Eithan", 1000);
            // Console.WriteLine("Cuenta " + cuenta.ObtenerTitular() + "\nSaldo antes de transacción: " +
            //                   cuenta.ObtenerSaldo());
            // transacts(cuenta);
            // Console.WriteLine("Cuenta " + cuenta.ObtenerTitular() + "\nSaldo después de transacción: " +
            //                   cuenta.ObtenerSaldo());



            // Gato naranjo = new Gato("Naranjo");
            // naranjo.mostrarFamilia();
            // naranjo.hacerSonido();
            // naranjo.mostrarInfo();
            //
            //
            Perro cachupin = new Perro("Chusco");
            cachupin.mostrarFamilia();
            cachupin.hacerSonido();
            cachupin.mostrarInfo();

        }

        

        static private void transacts(CuentaBancaria cuentaBancaria)
        {
            cuentaBancaria.Retirar(500);
            cuentaBancaria.Depositar(300);
            cuentaBancaria.Retirar(100);
            cuentaBancaria.Depositar(500);
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