namespace DataStructuresAndAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Person
    {
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method 
            z = 99;

            // increment each parameter 
            x++;
            y++;
            z++;
        }
    }


}
