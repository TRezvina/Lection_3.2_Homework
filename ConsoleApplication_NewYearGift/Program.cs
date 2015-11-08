using System;
using ConsoleApplication_NewYearGift.Collections;
using ConsoleApplication_NewYearGift.Sweets;
using ConsoleApplication_NewYearGift.Sweets.Caramel;
using ConsoleApplication_NewYearGift.Sweets.Chocolate_Candy;
using ConsoleApplication_NewYearGift.Sweets.Iris;
using ConsoleApplication_NewYearGift.Sweets.Other;

namespace ConsoleApplication_NewYearGift
{
    class Program
    {
        static void Main(string[] args)
        {
         #region Part1
            Gift gift = new Gift();
            gift = PackGift();
            Console.WriteLine("List of sweets in the gift:");
            Console.WriteLine("");
            gift.ShowGiftList();
            Console.WriteLine("========================================================================");

            Console.WriteLine();
            Console.WriteLine("Gift weight is {0}", gift.Weight);
            Console.WriteLine();

            Console.WriteLine("========================================================================");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to sort by price");
            const char chchoise = '1';
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("========================================================================");
            gift.SortBy(chchoise); // no logic but to show polymorphism
            gift.ShowGiftList();

            Console.WriteLine("========================================================================");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to sort by weight");
            const int ichoice = 1;
            Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("========================================================================");
            gift.SortBy(ichoice); // no logic but to show polymorphism
            gift.ShowGiftList();

            Console.WriteLine("========================================================================");
            Console.WriteLine("");
            Console.WriteLine("Enter search conditions:");

            bool flag = false;
            bool flag2 = false;

            do
            {
                Console.WriteLine("Weight more than:");
                try
                {
                    double from = Convert.ToDouble(Console.ReadLine());
                    flag = true;
                    do
                    {
                        Console.WriteLine("Weight less than:");
                        try
                        {
                            double to = Convert.ToDouble(Console.ReadLine());
                            gift.FindByWeight(from, to);
                            flag2 = true;
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("You entered incorrect value:");
                        }

                    } while (flag2 == false);
                }
                catch (Exception)
                {
                    Console.WriteLine("You entered incorrect value:");
                }
            } while (flag == false);

            Console.WriteLine("========================================================================");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to continue with part 2");
            Console.ReadLine();
            
           #endregion

            #region Part 2

            #region ArrayList vs LinkedList
            MyArrayList myArrayList = new MyArrayList();
            MyLinkedList myLinkedList = new MyLinkedList();
            CompareObjects(myArrayList, myLinkedList);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            #endregion

            #region Stack vs Queue
            MyQueue myQueue = new MyQueue();
            MyStack myStack = new MyStack();
            CompareObjects(myQueue, myStack);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            #endregion

            #region HashTable vs Dictionary
            MyHashTable myHashTable = new MyHashTable();
            MyDictionary myDictionary = new MyDictionary();
            CompareObjects(myHashTable, myDictionary);
            #endregion
            #endregion

            
            Console.WriteLine("");
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();

        }

        public static Gift PackGift()
        {
            Gift gift = new Gift();
            gift.AddSweet(new ChocolateCandyWithJelly("Blackberry", 10, 24.01));
            gift.AddSweet(new ChocolateCandyWithCream("Noir", 15, 30.4));
            gift.AddSweet(new ChocolateCandyWithNuts("ChocoNuts", 9, 10.5));
            gift.AddSweet(new ChocolateCandyTruffle("Truffle", 15.1, 15));
            gift.AddSweet(new IrisCream("Iris Cream", 20, 30.02));
            gift.AddSweet(new IrisForChildren("Child's Iris", 23, 15.03));
            gift.AddSweet(new IrisWithFilling("Iriska", "milky cream", 32, 10.22));
            gift.AddSweet(new CaramelMedical("Halls", 35, 14.20));
            gift.AddSweet(new CaramelInChocolate("ChocoShock", 15, 20.11));
            gift.AddSweet(new LollipopFruitty("Fruitty", 22, 32.01));
            gift.AddSweet(new LollipopMilky("Milky lollipop", 12, 40.00));
            gift.AddSweet(new LollipopMinty("Minty lollipop", 21, 22.00));
            gift.AddSweet(new LollipopWithFilling("Cherry lollopop", "Cherry", 34, 28.04));
            gift.AddSweet(new JellyBean("JellyBean", 33, 20.62));
            gift.AddSweet(new Milky("Milky Candy", 27, 42.02));
            gift.AddSweet(new Roasting("Grilyazh", 52, 34.05));
            gift.AddSweet(new WaffleCandy("Waffle candy", 28, 33.44));
            return gift;
        }

        public static void Compare(string firstCollection, TimeSpan ts1, string secondCollection, TimeSpan ts2)
        {
            if(ts1>ts2)
            { Console.WriteLine("{0} faster than {1}", secondCollection, firstCollection);}
            else if (ts1<ts2)
            { Console.WriteLine("{0} faster than {1}", firstCollection, secondCollection); }
            else
            {
                Console.WriteLine("Operation takese the same time for {0} and {1}", firstCollection, secondCollection);
            }
        }

        public static void ShowTimeSpan(string operation, MyCollections firstCollection, MyCollections secondCollection, TimeSpan ts1, TimeSpan ts2)
        {
            Console.WriteLine("");

            switch (operation)
            {
                case "Add":
                {
                    Console.WriteLine("--- Operation ADD ---");
                    break;
                }
                case "Search":
                {
                    Console.WriteLine("--- Operation SEARCH ---");
                    break;
                }
                case "Delete":
                {
                    Console.WriteLine("--- Operation DELETE ---");
                    break;
                }
                
            }
            
            ShowTakenTime(firstCollection, secondCollection, ts1, ts2);
            Compare(firstCollection.GetCollectionName(), ts1, secondCollection.GetCollectionName(), ts2);
        }

        public static void ShowTakenTime(MyCollections firstCollection, MyCollections secondCollection, TimeSpan ts1, TimeSpan ts2)
        {
            Console.WriteLine("{0}: {1} ms", firstCollection.GetCollectionName(), ts1.TotalMilliseconds);
            Console.WriteLine("{0}: {1} ms", secondCollection.GetCollectionName(), ts2.TotalMilliseconds);
        }

        public static void CompareObjects(MyCollections firstCollection, MyCollections secondCollection)
        {
            TimeSpan ts1 = new TimeSpan();
            TimeSpan ts2 = new TimeSpan();
            Console.WriteLine("========================================================================");
            Console.WriteLine("{0} VS {1}", firstCollection.GetCollectionName(), secondCollection.GetCollectionName());
            Console.WriteLine("");
            ts1 = firstCollection.Init(PackGift());
            ts2 = secondCollection.Init(PackGift());
            ShowTimeSpan("Add", firstCollection, secondCollection, ts1, ts2);
            ts1 = firstCollection.GetNElement(500);
            ts2 = secondCollection.GetNElement(500);
            ShowTimeSpan("Search", firstCollection, secondCollection, ts1, ts2);
            ts1 = firstCollection.RemoveNElement(500);
            ts2 = secondCollection.RemoveNElement(500);
            ShowTimeSpan("Delete", firstCollection, secondCollection, ts1, ts2);
            Console.WriteLine("========================================================================");
            Console.WriteLine("");
        }
    }
}
