using System;

namespace Hometask3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 45;
            //Root(ref number);

            string str = "Elnara Vahabova";
            NotSpace(ref str);

            //int[] nums = { 2,5,4 };
            //int value = 3;
            //NewArray(ref nums, value);
        }
        //Task3
        //static void Root(ref int number)
        //{
        //    int i = 0;
        //    while (i*i<=number)
        //    {
        //        i++;
        //    }
        //    Console.WriteLine(i-1);
        //}

        //Task2
        static void NotSpace(ref string str)
        { 
            string newname = string.Empty;
           string name = str.Replace(" ", String.Empty);
            Console.WriteLine(name);
        }

        //Task1
        //static void NewArray(ref int[] array, int value)
        //{
        //    int[] newarray = new int[array.Length + 1];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        newarray[i] = array[i];
        //    }
        //    newarray[array.Length] = value;
        //    array = newarray;
        //    foreach (int item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //  }

    }

}
