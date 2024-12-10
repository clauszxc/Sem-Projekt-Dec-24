using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_Projekt_Dec_24.Tables
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAdress { get; set; }

        public Customers(int customerId, string customerEmail, string customerAdress)
        {
            CustomerId = customerId;
            CustomerEmail = customerEmail;
            CustomerAdress = customerAdress;
        }
        public string CustomerInformation
        {
            get { return $"{CustomerEmail}, {CustomerAdress}"; }
        }
    }
}
