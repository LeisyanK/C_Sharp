using System;

namespace Example010_MethodArray
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] array = {80, 45, 38, 15, 20, 63};
           int n = array.Length;
           int find = 38;
           int index = 0;

           while (index < n)
           {
            if (array[index] == find)
            {
                Console.WriteLine(index);
                break;
            }
            index++;
           }
        }
    }
}
