using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics_and_Collections
{
    public class Program
    {
        static void Main()
        {
            //instantiate generic with Integer
            GenericArray<int> intObj = new GenericArray<int>();

            //adding integer values into collection
            intObj.AddItem(1);
            intObj.AddItem(2);
            intObj.AddItem(3);
            intObj.AddItem(4);
            intObj.AddItem(5);
            intObj.Swap(2, 3);

            // a is nullable type
            // and contains null value
            int? a = null;
            Console.WriteLine(a.HasValue);
            // it means if a is null
            // then assign 3 to b
            int b = a ?? 3;

            // conversion methods - toDictionary
            List<Product> listProducts = new List<Product>
            {
                new Product { ID= 1001, Name = "Mobile", Price = 800 },
                new Product { ID= 1002, Name = "Laptop", Price = 900 },
                new Product { ID= 1003, Name = "Desktop", Price = 800 }
            };
            Dictionary<int, Product> productsDictionary = listProducts.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Product> kvp in productsDictionary)
            {
                Console.WriteLine(kvp.Key + " Name : " + kvp.Value.Name + ", Price: " + kvp.Value.Price);
            }


            // IEquality Comparer
            CreditCardEqualityComparer creditCardEqC = new CreditCardEqualityComparer();

            var creditCards = new Dictionary<CreditCard, string>(creditCardEqC);

            var goldCreditCard = new CreditCard(4, 3, 4);
            AddCreditCard(creditCards, goldCreditCard, "gold");

            var silverCreditCard = new CreditCard(4, 3, 4);
            AddCreditCard(creditCards, silverCreditCard, "silver");

            var greenCreditCard = new CreditCard(3, 4, 3);
            AddCreditCard(creditCards, greenCreditCard, "simple");
            Console.WriteLine();

            Console.WriteLine("The dictionary contains {0} CreditCard objects.",
                              creditCards.Count);
        }

        public static void AddCreditCard(Dictionary<CreditCard, String> dict, CreditCard creditCard, String name)
        {
            try
            {
                dict.Add(creditCard, name);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Unable to add {0}: {1}", creditCard, e.Message);
            }
        }
    }
}



public class CreditCard
{
    public CreditCard(int h, int l, int w)
    {
        this.Height = h;
        this.Length = l;
        this.Width = w;
    }

    public int Height { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }

    public override String ToString()
    {
        return String.Format("({0}, {1}, {2})", Height, Length, Width);
    }
}

class CreditCardEqualityComparer : IEqualityComparer<CreditCard>
{
    public bool Equals(CreditCard c1, CreditCard c2)
    {
        if (c2 == null && c1 == null)
            return true;
        else if (c1 == null || c2 == null)
            return false;
        else if (c1.Height == c2.Height && c1.Length == c2.Length
                            && c1.Width == c2.Width)
            return true;
        else
            return false;
    }

    //Returns a hash code for the specified object.
    // This method is used to return the hash code for this instance. A hash code is a numeric value
    // which is used to insert and identify an object in a hash-based collection.
    // The GetHashCode method provides this hash code for algorithms that need quick checks of object equality.
    public int GetHashCode(CreditCard c)
    {
        int hCode = c.Height ^ c.Length ^ c.Width;
        return hCode.GetHashCode();
    }
}