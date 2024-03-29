﻿using Inlamningsuppgift1_CodePattern_DanArv.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_CodePattern_DanArv.Models
{
    public class GetPrice : IGetPrice
    {
        public void TotalPrice(Pet pet)
        {
            int totalPrice = CostOfServices.PriceForStay;
            if (pet.NeedsClawTrim)
            {
                totalPrice += CostOfServices.PriceForTrim;
                Console.WriteLine($"Clawtrim: {CostOfServices.PriceForTrim}kr");
            }
            if (pet.NeedsWash)
            {
                totalPrice += CostOfServices.PriceForWash;
                Console.WriteLine($"Wash: {CostOfServices.PriceForWash}kr");
            }
            Console.WriteLine($"Price for stay: {CostOfServices.PriceForStay}kr");
            Console.WriteLine($"Total price: {totalPrice}kr");
        }
    }
}
