using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcess
{
    public class PhysicalProduct :Product
    {
        private readonly IPayment _payment;
        private IComission _comission;
        public PhysicalProduct(IPayment payment, IComission comission)
        {
            _payment = payment;
            _comission = comission;
        }

        public bool MakePayment(PhysicalProduct product)
        {
            bool success = false;
            try
            {
                _payment.Pay(product);
                _payment.GeneratePackingSlip(product);
                _comission.PayComission(product);
                success = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return success;
        }


    }
}
