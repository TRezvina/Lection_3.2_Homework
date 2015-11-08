using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_NewYearGift.Sweets
{
    interface ISweets
    {
        string Name { get; set; }
        int Price { get; set; }
        double Weight { get; set; }

    }
}
