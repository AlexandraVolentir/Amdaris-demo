using System;
using System.Linq;
using StringsAndArrays;

namespace StringsAndArrays
{

    /* Working on string and array manipulation
     * (c) Volentir Alexanra
     */


    class TestClass
    {
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static int[] InserElementAtIndexInArray(int[] arr, int insertedElm, int index)
        {
            int n = arr.Length;
            int[] newArray = new int[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                if (i < index - 1)
                    newArray[i] = arr[i];
                else if (i == index - 1)
                    newArray[i] = insertedElm;
                else
                    newArray[i] = arr[i - 1];
            }
            return newArray;
        }

        public static int[] DeleteAllEvenNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array = array.Where((source, index) => index != i).ToArray();
                }
            }
            return array;
        }


        // working with one-dimensional array
        public static void Assignment1()
        {
            /*
            +Delete all even numbers.
            +Insert new element after all elements beginning with the indicated digit.
            +Delete from array all repeating elements except of their first occurrence.
            Insert new element between all element pairs with different signs.
            +Compress array by deleting all zero-value elements.

     
             */
            int[] arrayWithEvenNr = new int[14] { 1, 1, 2, 3, 4, 5, 6, 7, 7, 8, 9, 9, 9, 10 };
            Console.WriteLine("Array with even numbers: ");
            PrintArray(arrayWithEvenNr);
            var newArray = DeleteAllEvenNumbers(arrayWithEvenNr);
            Console.WriteLine("Array after removing even numbers: ");
            PrintArray(newArray);
        }

        // working with two-dimensional array
        public static void Assignment2()
        {
            /*
             * +Insert new line after line containing the first occurrence of the minimal element.
                Insert new column before all columns containing the indicated number.
                Delete all lines, containing only even number elements.
                +Delete all columns, containing only positive elements.
                Delete from array the k-th line and the j-th column if their values coincide.
                +Compress array by deleting all only zero-value lines and columns.

             */
        }

        // application with specifications
        public static void Assignment3()
        {
            /*
             insert  character <insertedElm> after every occurrence of character <y>;
                mix up the first character with the second one, the third character with the fourth one etc.
                find, which of two indicated characters is occurred in the string more often;
                count full number of occurrences of <insertedElm> and <y> characters;
                +count number of different characters in the string;
                find out if the string has two adjacent identical characters;
                delete the middle character if string length is odd or two middle characters if string length is even;
                double every occurrence of the indicated character <insertedElm>;
                delete all occurrences of  the character <insertedElm>;
                delete all occurrences of the substring <substr>;
                +replace all occurrences of the substring <substr1> on the substring <substr2>;
                count the sum of all numbers occurred in the string;
                count the sum of all digits occurred in the string;
                find indexes of the first and the last occurrences of the character <insertedElm>;
                replace all groups of adjacent dots with ellipsis;
                display all characters before the first colon occurrence in the string;
                display all characters after the first colon occurrence in the string;
                delete all characters inside the parenthesize.
                delete all characters inside the curly braces;
                count and display statistics of character occurrences in the string.

             */
        }

        // message in text file
        public static void Assignment4()
        {
        }

        // misc
        public static void Assignment5()
        {
        }


        public static void salut()
        {
        }


        // the main code is compiled here
        public static void Main(string[] args)
        {
            Assignment1();
            Assignment2();
            Assignment3();
            Assignment4();
            Assignment5();
        }
    }
}
