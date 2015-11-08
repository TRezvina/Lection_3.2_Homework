using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets.Caramel
{
    public abstract class Caramel : Candy
    {
        private const string CandyType = "Caramel";
        protected Caramel(string name, int price, double weight, string subType)
            : base(name, price, weight, CandyType)
        {
            CandySubType = subType;
        }
        public string CandySubType { get; set; }

        public override string ToString()
        {
            return string.Format("Caramel Candy {0} '{1}', weight - {2}, price - {3}", CandySubType, Name, Weight, Price);
        }
    }
}
