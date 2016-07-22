using System;

namespace BreakingOpenClosedPrinciple.Interface_way_of_doing
{
    public class Standard : IProduct
    {
        private readonly decimal _price;

        public Standard(decimal price)
        {
            _price = price;
        }
        public void Render()
        {
            Console.WriteLine("Hi, I am a standard product that costs £{0}", _price);
        }
    }
}