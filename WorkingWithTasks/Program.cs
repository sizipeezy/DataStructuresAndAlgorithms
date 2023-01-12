using System;
using System.Diagnostics; // Stopwatch
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] myNum = { 10, 20, 30, 40 };
        Reverse(myNum, 2, 3);

        //OutputThreadInfo();
        //Stopwatch timer = Stopwatch.StartNew();

        //List<int> numbers = Enumerable.Range(0, 10000).ToList();
        //for (int i = 0; i < 4; i++)
        //{
        //    new Thread(() =>
        //    {
        //        while (numbers.Count > 0)
        //            lock (numbers)
        //            {
        //                if (numbers.Count == 0) break;
        //                int lastIndex = numbers.Count - 1;
        //                numbers.RemoveAt(lastIndex);
        //            }
        //    }).Start();
        //}



        //ThreadNumbers(5, 20);
        //WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");

        //WriteLine("Running methods synchronously on one thread.");
        //MethodA();
        //MethodB();
        //MethodC();
        //WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");
    }
    static void RectulangerArray(int a, int b)
    {
        var matrix = new int[a, b];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = i * 3 + j;

        foreach (var item in matrix)
        {
            Console.WriteLine(item);
        }
    }
    static void ThreadNumbers(int start, int end)
    {
        Thread evens = new Thread(() =>
        {
            PrintEvenNumbers(start, end);
        });
        evens.Start();
        evens.Join();

        Console.WriteLine("Thread finished work");
    }

    private static void Reverse(int[] arr, int k, int s)
    {
        int startIndex = k;
        int endIndex = s;
        var result = new List<int>();

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = startIndex; j < endIndex / 2; j++)
            {
                result.Add(arr[j]);
            }
        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
    private static void PrintEvenNumbers(int start, int end)
    {
        var result = new List<int>();

        for (int i = start; i < end; i++)
        {

            if (i % 2 == 0)
            {
                result.Add(i);
            }
            
        }

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    static void OutputThreadInfo()
    {
        Thread t = Thread.CurrentThread;
        WriteLine(
        "Thread Id: {0}, Priority: {1}, Background: {2}, Name: {3}",
        t.ManagedThreadId, t.Priority,
        t.IsBackground, t.Name ?? "null");
    }

    static void MethodA()
    {
        WriteLine("Starting Method A...");
        OutputThreadInfo();
        Thread.Sleep(3000); // simulate three seconds of work
        WriteLine("Finished Method A.");
    }
    static void MethodB()
    {
        WriteLine("Starting Method B...");
        OutputThreadInfo();
        Thread.Sleep(2000); // simulate two seconds of work
        WriteLine("Finished Method B.");
    }
    static void MethodC()
    {
        WriteLine("Starting Method C...");
        OutputThreadInfo();
        Thread.Sleep(1000); // simulate one second of work
        WriteLine("Finished Method C.");
    }
}