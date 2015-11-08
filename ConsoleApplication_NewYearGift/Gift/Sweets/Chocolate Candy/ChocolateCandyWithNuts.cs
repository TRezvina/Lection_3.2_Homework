﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Chocolate_Candy
{
    public class ChocolateCandyWithNuts : ChocolateCandyWithFilling
    {
        private const string CandyFilling = "Nuts";
        public ChocolateCandyWithNuts(string name, int price, double weight)
            : base(name, CandyFilling, price, weight)
        {
        }
    }
}
