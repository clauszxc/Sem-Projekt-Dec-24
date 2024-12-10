using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    public class Shipments
    {
        public int ShipmentId { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ShipperId { get; set; }
        public string ShipmentStartDate { get; set; }
        public string ShipmentEndDate { get; set; }

        public Shipments(int shipmentId, int orderId, int customerId, int shipperId, string shipmentStartDate, string shipmentEndDate)
        {
            ShipmentId = shipmentId;
            OrderId = orderId;
            CustomerId = customerId;
            ShipperId = shipperId;
            ShipmentStartDate = shipmentStartDate;
            ShipmentEndDate = shipmentEndDate;
        }
        public string ShipmentInformation
        {
            get { return $"OrderId:{OrderId}, CustomerId:{CustomerId}, ShipperId:{ShipperId}, {ShipmentStartDate}, {ShipmentEndDate}"; }
        }
    }
}
