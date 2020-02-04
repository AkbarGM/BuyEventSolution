using BuyEventSolution.Message;
using BuyEventSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyEventSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Клиентро месозем.
            Client client = new Client()
            {
                Email = "client@gmail.com",
                Phone = "+(992) 988654321"
            };
            //Маҳсулотро интихоб менамоем.
            Purchase purchase = new Purchase()
            {
                ProductName = "IPhone X",
                Price = 8700.00M
            };
            //Усули равон кардани мактубро интихоб мекунем.
            IMessage smsMessage = new SmsMessage();

            //Харидро иҷро менамоем.
            PurchaseBuilder pb = new PurchaseBuilder(client, purchase);
            pb.Send += smsMessage.Send;
            pb.PerformPurchase();

            Console.ReadKey();
        }
    }
}
