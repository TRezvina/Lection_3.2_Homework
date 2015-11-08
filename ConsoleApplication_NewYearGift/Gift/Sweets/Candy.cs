using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets
{
    public class Candy : ISweets
    {
        protected Candy(string name, int price, double weight, string type)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Type = type;
        }

        public string Name { get; set; }
        public int Price { get; set; }
        public double Weight { get; set; }
        public string Type { get; set; }
        public override string ToString()
        {
            return string.Format("Candy {0}, name '{1}', weight - {2}, price - {3}", Type, Name, Weight, Price);
        }
        
    }
}
