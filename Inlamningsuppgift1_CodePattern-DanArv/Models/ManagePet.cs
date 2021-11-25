using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv.Models
{
    public class ManagePet : IManagePet
    {

        private readonly Pet.Factory _petFactory;

        public ManagePet(Pet.Factory petFactory)
        {
            _petFactory = petFactory;
        }

        public IPet CreatePet(List<ICustomer> owners)
        {
            bool programIsRunning = true;
            while (programIsRunning)
            {
                Console.WriteLine("Enter pets name");
                string petName = Console.ReadLine();
                if (!String.IsNullOrEmpty(petName))
                {
                    Console.WriteLine("Enter owners name");
                    string userInput = Console.ReadLine();

                    ICustomer customer = owners.FirstOrDefault(name => name.Name == userInput);
                    if(customer != null)
                    {
                        ICustomer customerName = customer;
                        Console.WriteLine("Pet added.");
                        programIsRunning = false;
                        return _petFactory(petName, customerName, false, false, false);
                    }
                    else
                    {
                        Console.WriteLine("Owner not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter your pets name");
                }
            }
            return null;
        }

        public void SeeAllPets(List<IPet> pets)
        {
            foreach (var pet in pets)
            {
                Console.WriteLine($"Name: {pet.Name}, Atkennel: {pet.InKennel}");
            }
        }
    }
}
