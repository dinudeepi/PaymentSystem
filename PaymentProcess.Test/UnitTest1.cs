using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PaymentProcess; 

namespace PaymentProcess.Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void PhysicalProduct_Test()
        {
            //Arrange
            IPayment payment = new Payment();
            IComission comission = new Payment();
            PhysicalProduct product = new PhysicalProduct(payment, comission)
            {
                ProductId = 1,
                ProductName = "Physical Product",
                ProductType = PaymentProcess.Enum.ProductType.PhysicalProduct
            };
            //Actual
            bool isSuccess = product.MakePayment(product);

            //Assert
            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void Book_Test()
        {
            //Arrange
            IPayment payment = new Payment();
            IComission comission = new Payment();
            Book product = new Book(payment, comission)
            {
                ProductId = 2,
                ProductName = "Book",
                ProductType = PaymentProcess.Enum.ProductType.Book
            };
            //Actual
            bool isSuccess = product.MakePayment(product);

            //Assert
            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void Membership_Test()
        {
            //Arrange
            IPayment payment = new Payment();
            Membership product = new Membership(payment)
            {
                ProductId = 3,
                ProductName = "Membership",
                ProductType = PaymentProcess.Enum.ProductType.Membership
            };
            //Actual
            bool isSuccess = product.MakePayment(product);

            //Assert
            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void Membership_Upgrade_Test()
        {
            //Arrange
            IPayment payment = new Payment();
            Membership product = new Membership(payment)
            {
                ProductId = 3,
                ProductName = "Membership",
                ProductType = PaymentProcess.Enum.ProductType.Membership,
                UpgradeMembership = true
            };
            //Actual
            bool isSuccess = product.MakePayment(product);

            //Assert
            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void Video_Test()
        {
            //Arrange
            IPayment payment = new Payment();
            Video product = new Video(payment)
            {
                ProductId = 4,
                ProductName = "Video",
                ProductType = PaymentProcess.Enum.ProductType.Video,
                VideoName ="SampleVideo"
            };
            //Actual
            bool isSuccess = product.MakePayment(product);

            //Assert
            Assert.IsTrue(isSuccess);
        }

        [TestMethod]
        public void Video_FreeAid_Test()
        {
            //Arrange
            IPayment payment = new Payment();
            Video product = new Video(payment)
            {
                ProductId = 4,
                ProductName = "Video",
                ProductType = PaymentProcess.Enum.ProductType.Video,
                VideoName = "LearningtoSki"
            };
            //Actual
            bool isSuccess = product.MakePayment(product);

            //Assert
            Assert.IsTrue(isSuccess);
        }

    }
}
