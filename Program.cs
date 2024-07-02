using System;

class Program
{
    static void Main()
    {
        Console.Write("Input a string: ");
        string sinput = Console.ReadLine();

        if (IsPalindrome(sinput))
        {
            Console.WriteLine("String input is a palindrome.");
        }
        else
        {
            Console.WriteLine("String input is not a palindrome.");
        }

        Console.ReadLine();
    }

    static bool IsPalindrome(string str)
    {
        // this will convert the string to lower
        str = str.ToLower();

        // this will check if the string value reads the same forward or backward
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
