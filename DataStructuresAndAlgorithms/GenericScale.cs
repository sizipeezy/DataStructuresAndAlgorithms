namespace DataStructuresAndAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class GenericScale<T>
    {
        private readonly T left;
        private readonly T right;
        public GenericScale(T left, T right)
        {
            this.right = right;
            this.left = left;
        }

       public bool AreEqual()
        {

           return left.Equals(right); 
        }
    }
}
