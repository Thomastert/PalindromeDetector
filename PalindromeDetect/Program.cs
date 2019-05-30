using System;
using System.Collections.Generic;

namespace PalindromeDetect
{
    class Program
    {
        //Checks if the string entered by the user is a palindrome.
        //That is that it reads the same forwards as backwards like “racecar”
        static void Main(string[] args)
        {
            var userinput = Console.ReadLine();
            var reversoText = "g";
            List<char> letterList = new List<char>();

            for (var i = 0; i < userinput.Length; i++)
            {
                letterList.Add(userinput[userinput.Length - i - 1]);
                reversoText = string.Join("", letterList.ToArray());
                //put every letter of userimput in a list
            }
            letterList.Reverse(); // reverse the list

            Console.WriteLine(userinput);
            Console.WriteLine(reversoText);

            if (userinput == reversoText)// if reversed list == userinput palindrome = true
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");

            }


            Console.ReadKey();

            Console.WriteLine("any key to quit");
            Console.ReadKey();
        }
    }
}
