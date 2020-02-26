using System;
using System.Collections.Generic;
using System.Linq;

public class Program 
{
    public static void Main()
    {
        Console.WriteLine("Type a word and see if it is a Palindrome.");
        string userInput = Console.ReadLine();
        bool isPalindrome = ReversedArr(userInput);
        if(isPalindrome){
            Console.WriteLine("Yes");
        } else {
            Console.WriteLine("No");
        }

    }

    public static bool ReversedArr(string str)
    {
        char[] strArr = str.ToCharArray();

        for( int i = 0; i < strArr.Length; i ++)
        {
            if(strArr[i] != strArr[strArr.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}