using System;
using System.Linq;

namespace Base.Common
{
    public class Utility
    {
        public static int[] GetMockArray(int size)
        {
            var random = new Random();
            var array = new int[size];
            for (var i = 0; i < size; i++)
                array[i] = random.Next(1000);
            return array;
        }

        public static int GetRandomNumber(int min = 1, int max = 100)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        public static void SortArray(ref int[] array)
        {
            var list = array.ToList();
            list.Sort();
            array = list.ToArray();
        }
    }
}
