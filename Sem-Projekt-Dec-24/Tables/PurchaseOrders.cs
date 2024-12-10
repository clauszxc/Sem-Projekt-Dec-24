using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    public class PurchaseOrders
    {
        public int PurchaseId { get; set; }
        public int SupplierId { get; set; }
        public int ItemId { get; set; }
        public int ItemQuantity { get; set; }

        public PurchaseOrders(int purchaseId, int supplierId, int itemId, int itemQuantity)
        {
            PurchaseId = purchaseId;
            SupplierId = supplierId;
            ItemId = itemId;
            ItemQuantity = itemQuantity;
        }
        public string PurchaseOrderInformation
        {
            get { return $"SupplierId:{SupplierId}, ItemId:{ItemId}, {ItemQuantity}"; }
        }
    }
}
