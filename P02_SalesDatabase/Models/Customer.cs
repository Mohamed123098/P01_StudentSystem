using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    internal class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }

        public List<Sale> Sales { get; set; } = [];
        public override string ToString()
        {
            return $"Name : {Name}\nEmail : {Email}\nCreditCardNumber : {CreditCardNumber}\n--------------------------------";
        }
    }
}
