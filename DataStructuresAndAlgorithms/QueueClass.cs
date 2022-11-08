namespace DataStructuresAndAlgorithms
{
    using System.Collections.Generic;


    public class QueueClass
    {
        public void ReverseString(string[] input)
        {
            var stack = new Stack<string>();

            foreach (var item in input)
            {
                stack.Push(item);
            }

            Console.WriteLine(string.Join(" ", stack));

        }
    }
}
