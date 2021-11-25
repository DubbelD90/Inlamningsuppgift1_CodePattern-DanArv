using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv.Models
{
    public class ManageCustomer : IManageCustomer
    {

        private readonly Customer.Factory _customerFactory;

        public ManageCustomer(Customer.Factory customerFactory)
        {
            _customerFactory = customerFactory;
        }

        public ICustomer CreateCustomer()
        {
            bool programIsRunning = true;
            while (programIsRunning)
            {
                Console.WriteLine("Enter name:");
                string customerName = Console.ReadLine();
                Console.WriteLine("Enter phonenumber:");
                string customerPhone = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(customerName) || !String.IsNullOrWhiteSpace(customerPhone))
                {
                    programIsRunning = false;
                    return _customerFactory(customerName, customerPhone);
                }
                else
                {
                    Console.WriteLine("Please enter valid information");
                }
            }
            return null;
        }

        public void SeeAllCustomers(List<ICustomer> customers)
        {
            foreach(var _customer in customers)
            {
                Console.WriteLine($"Name: {_customer.Name}; Phonenumber: {_customer.PhoneNumber}");
            }
        }
    }
}
