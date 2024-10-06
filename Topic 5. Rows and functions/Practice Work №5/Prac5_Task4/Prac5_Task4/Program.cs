using System;

namespace StepInApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 2, 3, 4, 5 };

            long[] result;

            StepIn(out result, 2, data);

            Console.WriteLine("Results of raising numbers to powers:");
            foreach (long i in result)
            {
                Console.WriteLine(i);
            }
        }

        public static void StepIn(out long[] r, int a, params int[] b)
        {
            r = new long[0];

            Array.Resize(ref r, b.Length);

            int j = 0;

            foreach (int i in b)
            {
                r[j++] = (long)Math.Pow(i, a);
            }
        }
    }
}
