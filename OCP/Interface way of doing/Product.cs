namespace BreakingOpenClosedPrinciple.Interface_way_of_doing
{
    public class Product : IProduct
    {
        private readonly ProductType _type;
        private readonly decimal _price;

        public Product(decimal price, ProductType type)
        {
            _price = price;
            _type = type;
        }

        /// <summary>
        /// Render has one behaviour for Standard Products Types, and a different behaviour for Featured Products types. 
        /// </summary>
        public void Render()
        {
            
        }

        public string[] GetImageFileNames()
        {
            return new[] { "image1.jpg", "image2.jpg" };
        }
    }

    #region What's wrong with the above?
    // if we add a new ProductType, then we need to modify how this existing code works in order 
    // to include the new ProductType.
    // What if we add lots more ProductTypes? – We need more and more If statements.
    // What if this is not the only thing that varies by ProductType? - We start to duplicate this If block all over our code base.
    //
    // NB: Don’t fool yourself into thinking that a switch statement is any better – it’s just as bad!
    #endregion


}
