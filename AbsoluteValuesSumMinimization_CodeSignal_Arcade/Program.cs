using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteValuesSumMinimization_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -5, -4, -3, -2, -1, 0, 0, 0, 0, 1, 2, 3,
                4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 
                19, 20, 21,};
            int x = absoluteValuesSumMinimization(array);
            Console.WriteLine(x);
        }

        static int absoluteValuesSumMinimization(int[] a)
        {
            int min = int.MaxValue, sum, index = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                sum = 0;
                for (int j = 0; j < a.Length; ++j)
                {
                    sum += Math.Abs(a[i] - a[j]);
                }
                if (sum < min)
                {
                    min = sum;
                    index = i;
                }
            }
            return a[index];
        }
    }
}
