namespace ArraysTasksAndAlgorithms
{
    public class Class1
    {
        public static bool isPalRec(String str,
                   int s,
                   int e)
        {

            // If there is only one character
            if (s == e)
                return true;

            // If first and last character
            // do not match
            if ((str[s]) != (str[e]))
                return false;

            // If there are more than two
            // characters, check if middle
            // substring is also
            // palindrome or not.
            if (s < e + 1)
                return isPalRec(str, s + 1,
                                e - 1);
            return true;
        }

        public static bool isPalindrome(String str)
        {
            int n = str.Length;

            // An empty string is considered
            // as palindrome
            if (n == 0)
                return true;

            return isPalRec(str, 0, n - 1);
        }

        public static string ReverseString(string input)
        {
            char[] arr = input.ToCharArray();

            string result = string.Empty;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result += arr[i];
            }

            return result;
        }
        public static void ReverseAr(int[] arr, int end)
        {
            int temp;

            int n = arr.Length;
            int lastindex = arr.Length - 1;
            int start = 0;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

        }
        public static void reverseIntArray(int[] arr, int input)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i += input)
            {
                int left = i;
                int right = Math.Min(i + input - 1, n - 1);

                int temp = 0;
                while (left < right)
                {
                    temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                    left++;
                    right--;
                }
            }
        }
    }
}