using System;
using System.Collections.Generic;

namespace BreakingOpenClosedPrinciple.Interface_way_of_doing
{
    class ProductConsole
    {
        public static void Main()
        {
            var product1 = new Standard(4.52m);
            var product2 = new Featured(3.99m);

            var products = new List<IProduct>();

            products.Add(product1);
            products.Add(product2);

            foreach (IProduct product in products)
            {
                product.Render();
            }


            Console.WriteLine("FINISHED......press any key");
            Console.ReadKey();
        
        }
    }

    //class ProductConsoleAbstractWay
    //{
    //    public static void Main()
    //    {
    //        var product1 = new Standard(4.52m);
    //        var product2 = new Featured(3.55m);

    //        var products = new List<Product>();

    //        products.Add(product1);
    //        products.Add(product2);

    //        foreach (Product product in products)
    //        {
    //            product.Render();
    //        }


    //        Console.WriteLine("FINISHED......press any key");
    //        Console.ReadKey();

    //    }
    //}
}
