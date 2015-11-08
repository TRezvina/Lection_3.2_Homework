
namespace ConsoleApplication_NewYearGift.Sweets.Other
{
    public class JellyBean : Candy
    {
        private const string CandyType = "Jelly Bean";
        public JellyBean(string name, int price, double weight)
            : base(name, price, weight, CandyType)
        {
        }
    }
}
