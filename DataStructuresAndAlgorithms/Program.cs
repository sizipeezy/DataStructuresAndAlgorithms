internal class Program
{
   
    private static void Main(string[] args)
    {
        var array = new int[] { 4,2,7,1,3 };
        var item = 4;
        Console.WriteLine(string.Join(" ", SelectionSort(array)));
        string word = "kayak";
        Console.WriteLine(IsPalindrome(word));
    }

    public static bool IsPalindrome(string word)
    {
        int leftIndex = 0;
        int rightIndex = word.Length - 1;

        while (leftIndex < rightIndex)
        {
            if(word[leftIndex] != word[rightIndex])
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
                if(arr[j] < arr[lowestNumberIndex])
                {
                    lowestNumberIndex = j;  
                }   
            }

            if(lowestNumberIndex != i)
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