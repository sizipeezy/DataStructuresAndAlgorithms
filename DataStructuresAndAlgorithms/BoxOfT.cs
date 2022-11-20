namespace DataStructuresAndAlgorithms
{
    using System.Collections.Generic;
    using System.Linq;


    public class BoxOfT<T>
    {
        private readonly List<T> Box;

        public BoxOfT()
        {
            Box = new List<T>();
        }

        public int Count => Box.Count;

        public void Add(T element)
        {
            Box.Add(element);
        }

        public T Remove()
        {
            T result = Box.LastOrDefault();
            Box.Remove(result);

            return result;
        }
    }
}
