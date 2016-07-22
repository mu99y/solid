using System;

namespace BreakingOpenClosedPrinciple.Interface_way_of_doing
{
    public class Featured : IProduct
    {
        private readonly decimal _price;

        public Featured(decimal price)
        {
            _price = price;
        }
        public void Render()
        {
            Console.WriteLine("******* WOO HOOO *******");
            Console.WriteLine("******* FEATURED PRODUCT HERE **********");
            Console.WriteLine("******* I COST £{0} **********", _price);
        }
    }
}