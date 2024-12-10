using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    public class OrderInvoices
    {
        public int OrderInvoiceId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public OrderInvoices(int orderInvoiceId, int customerId, int productId, decimal price, int quantity)
        {
            OrderInvoiceId = orderInvoiceId;
            CustomerId = customerId;
            ProductId = productId;
            Price = price;
            Quantity = quantity;
        }
        public string OrderinvioceInformation
        {
            get { return $"{CustomerId} {ProductId}, {Price}, {Quantity}"; }
        }
    }
}
