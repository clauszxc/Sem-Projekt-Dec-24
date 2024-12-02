using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    internal class Shipment
    {
        public int ShipmentId { get; set; }
        public string ShipmentEndDate { get; set; }
        public string ShipmentStartDate { get; set; }

        public Shipment(int shipmentId, string shipmentEndDate, string shipmentStartDate)
        {
            ShipmentId = shipmentId;
            ShipmentEndDate = shipmentEndDate;
            ShipmentStartDate = shipmentStartDate;
        }
    }
}
