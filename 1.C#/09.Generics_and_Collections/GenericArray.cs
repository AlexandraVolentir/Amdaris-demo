using System;
namespace Generics_and_Collections
{
    public class GenericArray<T>
    {
        // define an Array of Generic type with length 100
        T[] obj = new T[100];
        int count = 0;

       
        // adding items mechanism into generic type
        public void AddItem(T item)
        {
            //checking length
            if (count + 1 < 40)
            {
                obj[count] = item;

            }
            count++;
        }
        //indexer for foreach statement iteration
        public T this[int index]
        {
            get { return obj[index]; }
            set { obj[index] = value; }
        }

         public void Swap(int index1, int index2)
         {
            T temp;
            temp = obj[index1];
            obj[index1] = obj[index2];
            obj[index2] = temp;
         }
    }
}
