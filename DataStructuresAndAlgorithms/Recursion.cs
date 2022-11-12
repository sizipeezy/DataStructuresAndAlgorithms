namespace DataStructuresAndAlgorithms
{
    using System;
    using System.Linq;


    public class Recursion
    {
        //efficiency of O(N)

        public void FibonnaciNumber(int n)
        {
            int number = n - 1;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            Console.WriteLine(Fib[number]);
        }
        public void MaxArray(int[] ints)
        {
            if (ints.Length == 1)
                Console.WriteLine(ints[0]);

            var max = ints.Max();

            if (ints[0] > max)
            {
                Console.WriteLine(ints[0]);
            }
            else
            {
                Console.WriteLine(max);
            }


        }
        public void DoubleArray(int[] arr, int index)
        {
            if (index >= arr.Length)
                return;

            arr[index] *= 2;
            DoubleArray(arr, index + 1);
        }
        public void CountDown(int number)
        {
            if (number <= 0)
            {
                return;
            }
            Console.WriteLine(number);
            CountDown(number - 1);

            
        }
    }
}
