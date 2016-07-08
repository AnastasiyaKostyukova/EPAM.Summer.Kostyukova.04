using System;
using NUnit.Framework;

namespace TaskWithString.Tests
{
    public class StringCreaterTests
    {
        [Test]
        public void CreateString_NameAndContactPhone_NewCreatedString()
        {
            // Arrange
            Customer customer = new Customer();
            customer.Name = "Nastya Kostyukova";
            customer.ContactPhone = "+375447343330";
            customer.Revenue = 10;

            Formatter format = new Formatter();
            format.WithName = true;
            format.WithContactPhone = true;
            format.WithRevenue = false;
            
        //Assert
        Assert.AreEqual(StringCreater.CreateString(customer, format), "Customer record: Nastya Kostyukova +375447343330 ");
        }


        [Test]
        public void CreateString_Revenue_NewCreatedString()
        {
            // Arrange
            Customer customer = new Customer();
            customer.Name = "Nastya Kostyukova";
            customer.ContactPhone = "+375447343330";
            customer.Revenue = 10;

            Formatter format1 = new Formatter();
            format1.WithName = false;
            format1.WithContactPhone = false;
            format1.WithRevenue = true;

            //Assert
            Assert.AreEqual(StringCreater.CreateString(customer, format1), "Customer record: 10 ");
        }

    }
}
