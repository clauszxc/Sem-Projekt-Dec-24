using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    public class Items
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCategory { get; set; }
        public int ItemStock { get; set; }

        public Items(int itemId, string itemName, string itemCategory, int itemStock)
        {
            ItemId = itemId;
            ItemName = itemName;
            ItemCategory = itemCategory;
            ItemStock = itemStock;
        }


    }
}
