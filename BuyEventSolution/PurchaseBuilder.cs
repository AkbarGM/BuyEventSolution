using BuyEventSolution.Log;
using BuyEventSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyEventSolution
{
    class PurchaseBuilder
    {
        public delegate int MessageHandler(Purchase purchase, Client client, out Exception exception);
        public event MessageHandler Send;

        private Exception _exception;
        private Client _client;
        private Purchase _purchase;
        public PurchaseBuilder(Client client, Purchase purchase)
        {
            _client = client;
            _purchase = purchase;
        }
        public void PerformPurchase()
        {
            int? code = Send?.Invoke(_purchase, _client, out _exception);
            if (code == -1)
            {
                Console.WriteLine("The message not sent!");
                MessageLog.Log(_exception);
                Console.WriteLine(MessageLog.GetLog());
            }
            else
            {
                Console.WriteLine("The message sent!");
            }
        }
    }
}
