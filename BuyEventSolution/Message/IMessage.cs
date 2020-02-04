using BuyEventSolution.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyEventSolution.Message
{
    interface IMessage
    {
        int Send(Purchase purchase, Client client, out Exception exception);
    }
}
