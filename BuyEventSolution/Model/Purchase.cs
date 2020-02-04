using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyEventSolution.Model
{
    class Purchase
    {
        private static int id = 0;
        public Purchase()
        {
            id++;
            Id = id;
        }
        public int Id { get; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
