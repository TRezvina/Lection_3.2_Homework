using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Iris
{
     public abstract class Iris : Candy
    {
        private const string CandyType = "Iris";
        protected Iris(string name, int price, double weight, string subType)
            : base(name, price, weight, CandyType)
        {
            CandySubType = subType;
        }
        public string CandySubType { get; set; }

        public override string ToString()
        {
            return string.Format("Iris Candy {0}, '{1}', weight - {2}, price - {3}", CandySubType, Name, Weight, Price);
        }
    }
}
