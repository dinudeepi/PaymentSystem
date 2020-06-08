using System;

namespace PaymentProcess
{
    public interface IPayment
    {
        void Pay(Product product);
        void GeneratePackingSlip(Product product);
    }
}
