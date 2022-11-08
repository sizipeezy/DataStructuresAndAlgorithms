﻿using DataStructuresAndAlgorithms;

internal class Program
{

    private static void Main(string[] args)
    {

        var newHash = new Sets();

        var input = Console.ReadLine();
        newHash.PartyCounter(input);





    }
    public static void CitiesAndCountries(int n)
    {
        var dict = new Dictionary<string, Dictionary<string, List<string>>>();
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string continent = cmdArgs[0];
            string country = cmdArgs[1];
            string city = cmdArgs[2];


            if (!dict.ContainsKey(continent))
            {
                dict.Add(continent, new Dictionary<string, List<string>>());
                dict[continent].Add(country, new List<string>());
                dict[continent][country].Add(city);
            }
            else if (!dict[continent].ContainsKey(country))
            {
                dict[continent].Add(country, new List<string>());
                dict[continent][country].Add(city);
            }
           
                dict[continent][country].Add(city);

        }
        foreach (var name1 in dict)
        {
            Console.WriteLine($"{name1.Key}:");
            foreach (var name2 in dict[name1.Key])
            {
                Console.Write($"  {name2.Key} -> ");
                Console.WriteLine(string.Join(", ", name2.Value));
            }
        }


    }
    public static void ProductShop(string input)
    {
        var dictionary = new Dictionary<string, Dictionary<string, double>>();
        while (true)
        {
            if (input == "Revision")
            {
                break;
            }
            string[] cmdArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var shop = cmdArgs[0];
            var product = cmdArgs[1];
            var price = double.Parse(cmdArgs[2]);


            if (!dictionary.ContainsKey(shop))
            {
                dictionary.Add(shop, new Dictionary<string, double>());
            }

            if (!dictionary[shop].ContainsKey(product))
            {
                dictionary[shop].Add(product, price);
            }

            input = Console.ReadLine();
        }

        foreach (var shop in dictionary.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{shop.Key}->");
            foreach (var item in shop.Value)
            {
                Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
            }
        }

    }
    public static void LargestThree(int[] arr)
    {
        var HashSet = new HashSet<int>();
        int[] test = arr.OrderByDescending(x => x)
            .Take(3)
            .ToArray();

        foreach (var item in test)
        {
            HashSet.Add(item);
        }

        Console.WriteLine(string.Join(" ", HashSet));
    }
    public static void CountStudentsGrades(int n)
    {
        var dictionary = new Dictionary<string, List<double>>();
        for (int i = 0; i < n; i++)
        {
            string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = cmdArgs[0];
            double grade = double.Parse(cmdArgs[1]);

            if (!dictionary.ContainsKey(name))
            {
                dictionary.Add(name, new List<double>());
            }

            dictionary[name].Add(grade);
        }
        foreach (var item in dictionary)
        {

            Console.Write($"{item.Key} -> ");
            foreach (var grade in item.Value)
            {
                Console.Write($"{grade:f2} ");
            }
            Console.Write($"(avg: {item.Value.Average():f2})");
            Console.WriteLine();
        }
    }
    public static void CountValues(int[] arr)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (var item in arr)
        {
            if (!dictionary.ContainsKey(item))
            {
                dictionary.Add(item, 0);
            }

            dictionary[item]++;
        }

        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key} - {item.Value} times");
        }
    }
    public static List<int> Intersection(int[] arr1, int[] arr2)
    {
        var HashTable = new HashSet<int>();
        var result = new List<int>();


        foreach (var item in arr1)
        {
            foreach (var item2 in arr2)
            {
                if (item == item2)
                {
                    result.Add(item);
                }
            }
        }

        return result;
    }
    public static bool IsPalindrome(string word)
    {
        int leftIndex = 0;
        int rightIndex = word.Length - 1;

        while (leftIndex < rightIndex)
        {
            if (word[leftIndex] != word[rightIndex])
            {
                return false;
            }
            leftIndex++;
            rightIndex--;
        }

        return true;
        Console.WriteLine(word);
    }
    public static int[] SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int lowestNumberIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[lowestNumberIndex])
                {
                    lowestNumberIndex = j;
                }
            }

            if (lowestNumberIndex != i)
            {
                int temp = arr[i];
                arr[i] = arr[lowestNumberIndex];
                arr[lowestNumberIndex] = temp;
            }
        }

        return arr;

    }
    public static void BubbleSort(int[] array)
    {
        int[] arr = array;
        int temp;
        for (int j = 0; j <= arr.Length - 2; j++)
        {
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp;
                }
            }

        }
        Console.WriteLine("Sorted:");
        foreach (int p in arr)
            Console.Write(p + " ");
        Console.Read();
    }
    public static void BinarySearch(int[] array, int searchValue)
    {
        int lower_bound = 0;
        int higher_bound = array.Length - 1;

        while (lower_bound <= higher_bound)
        {
            var midpoint = (lower_bound + higher_bound) / 2;
            var valueAtMidPoint = array[midpoint];

            if (searchValue == valueAtMidPoint)
            {
                Console.WriteLine("Founded!" + midpoint);
                break;
            }

            else if (searchValue < valueAtMidPoint)
                higher_bound = midpoint - 1;

            else if (searchValue > valueAtMidPoint)
                lower_bound = midpoint + 1;

        }

    }
    public static void LinearSearch(int[] array, int searchValue)
    {
        foreach (var item in array)
        {
            if (item == searchValue)
            {
                Console.WriteLine("founded! :" + searchValue);
                return;
            }

            if (item > searchValue)
            {
                Console.WriteLine("there is no such value");
                break;

            }

        }
    }
}