namespace DataStructuresAndAlgorithms
{
    using System;
    using System.Collections.Generic;


    public class Sets
    {
        public void PartyCounter(string input)
        {
            HashSet<string> set = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "PARTY")
                {
                    break;
                }
                set.Add(command);
            }
            while (true)
            {
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (set.Contains(input))
                {
                    set.Remove(input);
                }

            }
            Console.WriteLine(set.Count);
            foreach (var item in set)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in set)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void ParkingLot(string input)
        {
            var hash = new HashSet<string>();
            while (input != "END")
            {
                string[] cmdArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string number = cmdArgs[1];

                if(command == "IN")
                {
                    hash.Add(number);
                }
                else
                {
                    hash.Remove(number);
                }

               

                input = Console.ReadLine();
            }

            foreach (var item in hash)
            {
                Console.WriteLine(item);
            }
        }
        public void RecordUniqueNames(int n)
        {
            var HashSet = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                HashSet.Add(name);
            }

            foreach (var item in HashSet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
