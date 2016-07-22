namespace BreakingOpenClosedPrinciple.Interface_way_of_doing
{
    public interface IProduct
    {
        /// <summary>
        /// Render has one behaviour for Standard Products Types, and a different behaviour for Featured Products types. 
        /// </summary>
        void Render();
    }
}