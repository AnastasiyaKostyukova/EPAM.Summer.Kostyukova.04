using System;

namespace TaskWithString
{
    public class StringCreater
    {
        public static string CreateString (Customer customer, Formatter format)
        {
            string returnedString = "Customer record: ";
            if(format.WithName && !string.IsNullOrEmpty(customer.Name))
            {
                returnedString += customer.Name + " ";
            }
            
            if (format.WithContactPhone)
            {
                returnedString += customer.ContactPhone + " ";
            }

            if (format.WithRevenue)
            {
                returnedString += customer.Revenue.ToString() + " ";
            }
            return returnedString;
        }
    }
}
