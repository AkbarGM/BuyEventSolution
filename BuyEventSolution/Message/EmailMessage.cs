using BuyEventSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyEventSolution.Message
{
    class EmailMessage : IMessage
    {
        //Равон намудани мактуб ба воситаи Email.
        public int Send(Purchase purchase, Client client, out Exception exception)
        {
            try
            {
                Console.WriteLine("Message by Email!");
                Console.WriteLine($"Message Text: You've bought {purchase.ProductName}, the price is {purchase.Price}.");
                Console.WriteLine("Message is sending...");
                //Ҳангоми фаъол кардан, мактуб равон карда намешавад ва хатогӣ дар log сабт карда мешавад.
                //throw new Exception(); 
                exception = null;
                return 0;
            }
            catch (Exception e)
            {
                exception = e;
                return -1;
            }

        }
    }
}
