using PaymentProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Processpayment();
        }

        static void Processpayment()
        {
            //Physical Product
            IPayment payment = new Payment();
            IComission comission = new Payment();
            PhysicalProduct product = new PhysicalProduct(payment,comission)
            {
                ProductId = 1,
                ProductName = "Physical Product",
                ProductType = PaymentProcess.Enum.ProductType.PhysicalProduct
            };
            product.MakePayment(product);

            Book book = new Book(payment,comission)
            {
                ProductId = 2,
                ProductName = "Book",
                ProductType = PaymentProcess.Enum.ProductType.Book
            };
            book.MakePayment(book);

            Membership membership = new Membership(payment)
            {
                ProductId = 3,
                ProductName = "Membership",
                ProductType = PaymentProcess.Enum.ProductType.Book
            };
            membership.MakePayment(membership);

            Membership upgradeMembership = new Membership(payment)
            {
                ProductId = 3,
                ProductName = "Membership",
                ProductType = PaymentProcess.Enum.ProductType.Membership,
                UpgradeMembership = true

            };
            upgradeMembership.MakePayment(upgradeMembership);

            Video video = new Video(payment)
            {
                ProductId = 4,
                ProductName = "Video",
                ProductType = PaymentProcess.Enum.ProductType.Video,
                VideoName = "SomeVideo"

            };
            video.MakePayment(video);


            video = new Video(payment)
            {
                ProductId = 4,
                ProductName = "Video",
                ProductType = PaymentProcess.Enum.ProductType.Video,
                VideoName = "LearningtoSki"

            };
            video.MakePayment(video);

            Console.ReadLine();



        }
    }
}
