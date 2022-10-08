using System;

namespace Example009_IntroArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max(int arg1, int arg2, int arg3)
            {
                int result = arg1;
                if (arg2 > result) result = arg2;
                if (arg3 > result) result = arg3;
                return result;
            };

            int[] array = {74, 9, 479, 38, 83, 29, 4, 59, 63};

            int max = Max(
                Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]),
                Max(array[6], array[7], array[8])
            );
            Console.WriteLine(max);
        }
    }
}
