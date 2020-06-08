using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentProcess
{
    public class Payment : IPayment,IComission
    {
        public void Pay(Product product)
        {
            Console.WriteLine("Payment Completed for Product : " + product.ProductName);

        }

        public  void GeneratePackingSlip(Product product)
        {
            Console.WriteLine("PackingSlip Generated For product: " + product.ProductName);
        }

        public void PayComission(Product product)
        {
            Console.WriteLine("Comission Paid : " + product.ProductName);
        }
    }
}
