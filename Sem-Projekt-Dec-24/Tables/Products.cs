using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    internal class Products
    {
        public int ProductId { get; set; }
        public int ProductStock { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }

        public Products(int productId, int productStock, string productName, string productCategory)
        {
            ProductId = productId;
            ProductStock = productStock;
            ProductName = productName;
            ProductCategory = productCategory;
        }
    }
}
