using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcess
{
    public class Membership : Product
    {
        private IPayment _payment;
        public bool UpgradeMembership { get; set; }
        public Membership(IPayment payment)
        {
            _payment = payment;
        }

        public bool MakePayment(Membership product)
        {
            bool paymentSuccess = false;
            try
            { 
                _payment.Pay(product);
                if (product.UpgradeMembership)
                    UpgradeMemberShip(product);
                else
                    ActivateMemberShip(product);
                EmailOwner(product);
                paymentSuccess = true;
            }
            catch(Exception ex)
            {

            }
            return paymentSuccess;
          
        }

        private void ActivateMemberShip(Membership product)
        {
            Console.WriteLine("Activated Product: " + product.ProductName);
        }

        private void UpgradeMemberShip(Membership product)
        {
            Console.WriteLine("Upgraded : " + product.ProductName);
        }

        private void EmailOwner(Membership product)
        {
            Console.WriteLine("Sent Email : " + product.ProductName + (product.UpgradeMembership ? " Upgraded" : " Activated"));
        }
    }
}
