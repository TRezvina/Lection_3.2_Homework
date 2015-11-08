using System;
using ConsoleApplication_NewYearGift.Sweets;

namespace ConsoleApplication_NewYearGift.Collections
{
    public abstract class MyCollections
    {
        public abstract TimeSpan Init(Gift gift);
        public abstract TimeSpan GetNElement(int N);

        public abstract TimeSpan RemoveNElement(int N);

        public abstract string GetCollectionName();
    }
}
