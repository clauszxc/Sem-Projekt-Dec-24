﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    public class PurchaseOrderInvoices
    {
        public int PurchaseOrderInvoiceId { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public PurchaseOrderInvoices(int purchaseOrderInvoiceId, int supplierId, int itemId, decimal price, int quantity)
        {
            PurchaseOrderInvoiceId = purchaseOrderInvoiceId;
            SupplierId = supplierId;
            ItemId = itemId;
            Price = price;
            Quantity = quantity;
        }
        public string PurchaseOrderInvioceInformation
        {
            get { return $"SuplierId:{SupplierId}, ItemId:{ItemId}, {Price}, {Quantity}"; }
        }
    }
}
