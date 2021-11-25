using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using Inlamningsuppgift1_CodePattern_DanArv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv.Models
{
    public class CreateCustPetList : ICreateCustPetList
    {
        public List<ICustomer> CreateCustomerList()
        {
            List<ICustomer> customers = new List<ICustomer>
            {
                new Customer ("Steven", "0706498321"),
                new Customer ("Daniel",  "0727218651")
            };
            return customers;
        }

        public List<IPet> CreatePetList(List<ICustomer> owner)
        {
            List<IPet> pets = new List<IPet>
            {
                new Pet ("Freija", (Customer)owner[0], true, false, false) ,
                new Pet ("Yra", (Customer)owner[1], true, false, false) 
            };
            return pets;
        }
    }
}
