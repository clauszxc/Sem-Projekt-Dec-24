using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    internal class Shippers
    {
        public int ShipperId { get; set; }
        public string ShipperName { get; set; }

        public Shippers(int shipperId, string shipperName)
        {
            ShipperId = shipperId;
            ShipperName = shipperName;
        }
    }
}
