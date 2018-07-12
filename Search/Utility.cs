using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Search
{
    internal class Utility
    {
        internal static int[] GetMockArray(int size)
        {
            var random = new Random();
            var array = new int[size];
            for (var i = 0; i < size; i++)
                array[i] = random.Next(1000);
            return array;
        }

        internal static int GetRandomNumber(int min = 0, int max = 100)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        internal static int[] GetArrayInput()
        {
            int[] array = null;
            try
            {
                System.Console.WriteLine("Enter Array Size : ");
                int arraySize;
                if (!int.TryParse(Console.ReadLine(), out arraySize))
                    throw new Exception("Cannot convert input to integer type");
                array = new int[arraySize];
                System.Console.WriteLine("Enter " + arraySize + " Array Elements : ");
                for (var i = 0; i < arraySize; i++)
                    if (!int.TryParse(System.Console.ReadLine(), out array[i]))
                        throw new Exception("Cannot convert input to integer type");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input Failed !");
                Console.WriteLine(ex);
            }
            return array;
        }

        internal static int? GetSearchElementInput()
        {
            int? searchElement = null;
            try
            {
                System.Console.WriteLine("Enter Search Element : ");
                int inputElement;
                if (!int.TryParse(System.Console.ReadLine(), out inputElement))
                    throw new Exception("Cannot convert input to integer type");
                searchElement = inputElement;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Input Failed !");
                Console.WriteLine(ex);
            }
            return searchElement;
        }
    }
}
