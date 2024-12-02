using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    internal class Suppliers
    {
        public int SupplierId { get; set; }

        public Suppliers(int supplierId)
        {
            SupplierId = supplierId;
        }
    }
}
