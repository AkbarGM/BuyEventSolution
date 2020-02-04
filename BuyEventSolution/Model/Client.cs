using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyEventSolution.Model
{
    class Client
    {
        private static int id = 0;
        public Client()
        {
            id++;
            Id = id;
        }
        public int Id { get; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
