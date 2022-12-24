using System.Diagnostics;

Stopwatch watch = new();
Console.Write("Press ENTER to start. ");
Console.ReadLine();
watch.Start();
int max = 45;
IEnumerable<int> numbers = Enumerable.Range(start: 1, count: max);
Console.WriteLine($"Calculating Fibonacci sequence up to {max}. Please wait...");
int[] fibonacciNumbers = numbers.AsParallel()
.Select(number => Fibonacci(number))
.OrderBy(x => x)
.ToArray();
watch.Stop();
Console.WriteLine("{0:#,##0} elapsed milliseconds.",
arg0: watch.ElapsedMilliseconds);
Console.Write("Results:");
foreach (int number in fibonacciNumbers)
{
    Console.Write($" {number}");
}
static int Fibonacci(int term) =>
term switch
{
    1 => 0,
    2 => 1,
    _ => Fibonacci(term - 1) + Fibonacci(term - 2)
};