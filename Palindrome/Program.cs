using System;
using System.Linq;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter in this Format (InputString TrashSymbolString) :");

            string userInput = Console.ReadLine(); // input ==>>> "a@b!!b$a !@$" 


            // ?Aa#c #?
            string[] userInputArr = userInput.Split(' ');
            //userInputArr[0] == word
            //userInputArr[1] == trashSymbol
            char[] trashSymbolArray = userInputArr[1].ToCharArray();

            foreach (Char c in trashSymbolArray)
                userInputArr[0] = userInputArr[0].Replace(c.ToString(), String.Empty);

            Console.WriteLine(userInputArr[0]);
            var result = userInputArr[0].SequenceEqual(userInputArr[0].Reverse());

            int test = 300;

            Console.WriteLine(result);

            Console.WriteLine("New Line is {0} at ",test);


            Console.WriteLine("The new value is ");

            Console.WriteLine("My Name is {0} and I am the fastest man {1}","Furqan","Alive");
        }
    }

}
