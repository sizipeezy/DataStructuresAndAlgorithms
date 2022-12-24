using System.Diagnostics; // Stopwatch
using static System.Console;
internal class Program
{
    private static void Main(string[] args)
    {
        OutputThreadInfo();
        Stopwatch timer = Stopwatch.StartNew();

        ThreadNumbers(5, 20);
        WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");

        //WriteLine("Running methods synchronously on one thread.");
        //MethodA();
        //MethodB();
        //MethodC();
        //WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");
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