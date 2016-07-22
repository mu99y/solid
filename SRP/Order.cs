using System;

namespace BreakingSingleResponsibility
{
    public class Order
    {
        public void PlaceOrder()
        {
            try
            {
                // Code to add order to database would be here...
            }
            catch (Exception ex)
            {
                ExceptionLogger.Log(ex.Message);
            }
        }
    }
}