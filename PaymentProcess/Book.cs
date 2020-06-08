using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcess
{
    public class Book :Product
    {
        private IPayment _payment;
        private IComission _comission;
        public Book(IPayment payment,IComission comission)
        {
            _payment = payment;
            _comission = comission;
        }

        public bool MakePayment(Book product)
        {
            bool paymentSuccess = false;
            try
            {
                _payment.Pay(product);
                _payment.GeneratePackingSlip(product);
                GenerateDuplicateSlipForRoyalty(product);
                _comission.PayComission(product);
                paymentSuccess = true;
            }
            catch(Exception ex)
            {

            }
            return paymentSuccess;
        }

        private void GenerateDuplicateSlipForRoyalty(Product product)
        {
            Console.WriteLine("Duplicate PackingSlip Generated For product to royalty department: " + product.ProductName);
        }
    }
}
