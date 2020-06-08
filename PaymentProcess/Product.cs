using System;
using System.Collections.Generic;
using System.Text;
using PaymentProcess.Enum;

namespace PaymentProcess
{
    public partial class Product
    {
        private readonly IPayment _payment;

        public Product()
        {

        }
        public Product(IPayment payment)
        {
            _payment = payment;
        }

        public int ProductId { get; set; }
        public string  ProductName { get; set; }
        public  ProductType ProductType { get; set; }


        public void Pay(Product product)
        {
            _payment.Pay(product);
        }

    }
}
