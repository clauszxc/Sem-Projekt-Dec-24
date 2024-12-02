using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    internal class Orders
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ShipperId { get; set; }
        public string OrderStatus { get; set; }

        public Orders(int orderId, int customerId, int shipperId, string orderStatus)
        {
            OrderId = orderId;
            CustomerId = customerId;
            ShipperId = shipperId;
            OrderStatus = orderStatus;
        }
    }
}
