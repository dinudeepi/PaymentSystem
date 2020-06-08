using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcess
{
    public class Video : Product
    {
        private readonly IPayment _payment;
        public string VideoName { get; set; }
        public Video(IPayment payment)
        {
            _payment = payment;

        }

        public bool MakePayment(Video product)
        {
            bool paymentSuccess = false;
            try
            {
                _payment.Pay(product);
                _payment.GeneratePackingSlip(product);
                if (string.Equals("LearningtoSki", product.VideoName))
                    AddFreeVideo(product);
                paymentSuccess = true;
            }
            catch (Exception ex)
            {

            }
            return paymentSuccess;

        }

        private void AddFreeVideo(Video product)
        {
            Console.WriteLine("Added free video First Aid");
        }


    }
}
