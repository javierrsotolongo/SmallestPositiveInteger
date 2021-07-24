using System;

namespace SmallestPositiveInteger
{

    public static class Util
    {
        public static int SmallestPositiveInteger(int[] list) 
        {
            var length = list.Length;
            var previousSmallest = 0;
            for (int i = 0; i < length; i++)
            {
                var nextSmallest = int.MaxValue;
                for (int j = 0; j < length; j++)
                {
                    if (list[j] > previousSmallest && list[j] < nextSmallest)
                    {
                        nextSmallest = list[j];
                    }
                }

                if (i == 0 && nextSmallest > 1)
                {
                    return 1;
                }
                else if (i > 0 && previousSmallest != nextSmallest && 
                                  previousSmallest + 1 != nextSmallest)
                {
                    return previousSmallest + 1;
                }

                previousSmallest = nextSmallest;
            }

            return previousSmallest + 1;
        }

        public static int Smallest(int[] numbers) 
        {
            int small = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < small)
                {
                    small = numbers[i];
                }
            }

            return small;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ///<summary>
            ///For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
            ///Given A = [1, 2, 3], the function should return 4.
            ///Given A = [−1, −3], the function should return 1.
            ///</summary>

            var A = new int[] { 1, 3, 6, 4, 1, 2 };
            var result1 = Util.SmallestPositiveInteger(A);
            Console.WriteLine($"A: {result1}");

            A = new int[] { 1, 2, 3 };
            var result2 = Util.SmallestPositiveInteger(A);
            Console.WriteLine($"A: {result2}");

            A = new int[] { -1, -3 };
            var result3 = Util.SmallestPositiveInteger(A);
            Console.WriteLine($"A: {result3}");

            A = new int[] { -3, -1 };
            var result4 = Util.Smallest(A);
            Console.WriteLine($"A: {result4}");
        }
    }
}
