using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv.Models
{
    public class Customer : ICustomer
    {
        public delegate Customer Factory(string name, string phoneNumber);

        public Customer(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
