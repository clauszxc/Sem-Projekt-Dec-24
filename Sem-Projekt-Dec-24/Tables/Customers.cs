using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    internal class Customers
    {
        public string CustomerEmail { get; set; }
        public int CustomerId { get; set; }
        public string CustomerAdress { get; set; }

        public Customers(string customerEmail, int customerId, string customerAdress)
        {
            CustomerEmail = customerEmail;
            CustomerId = customerId;
            CustomerAdress = customerAdress;
        }
    }
}
