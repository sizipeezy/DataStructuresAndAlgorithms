namespace DataStructuresAndAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Recursion
    {
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
