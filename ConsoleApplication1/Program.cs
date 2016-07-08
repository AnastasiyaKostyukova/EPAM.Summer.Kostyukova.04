using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskWithString;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Nastya Kostyukova";
            customer.ContactPhone = "+375447343330";
            customer.Revenue = 10;

            Formatter format1 = new Formatter();
            format1.WithName = false;
            format1.WithContactPhone = true;
            format1.WithRevenue = true;

            Console.WriteLine( StringCreater.CreateString(customer, format1));

        }
    }
}
