using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KomodoInsuranceCustomers
{
    [TestClass]
    public class UnitTest1
    {
        //Arrange
        private KomodoCustomerRepository _komodoRepo = new KomodoCustomerRepository();
        private KomodoCustomer customer = new KomodoCustomer();

        [TestMethod]
        public void TestCreate()
        {
            //Act
            bool addCustomer = _komodoRepo.CreateCustomer(customer);
            Assert.IsTrue(addCustomer);
        }

        [TestMethod]
        public void TestRead()
        {
           
        }

        [TestMethod]
        public void TestUpdate()
        {

        }

        [TestMethod]
        public void TestDelete()
        {

        }
    }
}
