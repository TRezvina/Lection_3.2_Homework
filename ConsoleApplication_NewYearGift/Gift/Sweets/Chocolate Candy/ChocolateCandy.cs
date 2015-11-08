using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets
{
    public abstract class ChocolateCandy : Candy
    {
        const string CandyType = "Chocolate Candy";

        protected ChocolateCandy(string name, int price, double weight, string subType)
            : base(name, price, weight, CandyType)
        {
            SubType = subType;
        }

        public string SubType { get; set; }

        public override string ToString()
        {
            return string.Format("Chocolate Candy {0} '{1}', weight - {2}, price - {3}", SubType, Name, Weight, Price);
        }
    }
}
