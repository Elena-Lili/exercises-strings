﻿using Microsoft.VisualBasic;
using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)

        {

            //Write a method that to remove the nth index character from a nonempty string
            // OutCharacter();
            // Write a method that to remove the characters which have odd index values of a given string.
            // RemoveOddIndex();
            // Write a method that takes input from the user and displays that input back in upper and lower cases.
            // DisplayUpperAndLower();
            // Write a method that reverses a string if it's length is a multiple of 4
            // stringMultiple4();
            // Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.
            // ConvertString();
            //Write a method that to remove a newline. 
            // RemoveNewline();
            /*Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long, the 
            formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.*/
            //FormattedString();
            //Write a method that formats a number with a percentage
            //FormatNumber();
            //Write a method that reverses a string.
            //ReverseString();
            //Write a method that strips a set of characters from a string.
            //StripsSetOfCharacters();
            //Write a method that transforms to lowercase first n characters in a string
            // TranformsToLowecase();

        }
        static void OutCharacter()
        {
        Console.WriteLine("Enter the string :");
        string mystring = Console.ReadLine();
        Console.WriteLine("Enter the position of the character we will delete :");
        int index = Int32.Parse(Console.ReadLine());
            string newstring = mystring.Remove(index, 1);
            Console.WriteLine(newstring);
        }
        static void RemoveOddIndex()
        {
        Console.WriteLine("Enter the string :");
        string mystring = Console.ReadLine();
        string newstring="";
            int index=0;
            for (int i = 0; i < mystring.Length; i++)
            {
                
                if ((i%2) != 0)
                {
                    index++;
                    newstring = newstring + mystring[i];
                }
            }
            Console.WriteLine(newstring);
        }
        static void DisplayUpperAndLower()
        {
            Console.WriteLine("Enter the string :");
            string mystring = Console.ReadLine();
            Console.WriteLine(mystring.ToUpper());
            Console.WriteLine(mystring.ToLower());
        }
        static void stringMultiple4()
        {
            Console.WriteLine("Enter the string :");
            string mystring = Console.ReadLine();
            int n = mystring.Length;
            if ((n % 4) != 0)
            {
                Console.WriteLine("The length of string isn't a multiple of 4");
            }
            else
            {
                string newstring = "";
                for (int i = n - 1; i >= 0; i--)
                {
                    newstring = newstring + mystring[i];
                }
                Console.WriteLine(newstring);
            }

        }
        static void ConvertString()
        {
            Console.WriteLine("Enter the string: ");
            string myString = Console.ReadLine();
            int nrUpper = 0;
            char character;
            if (myString.Length < 4)
            {
                Console.WriteLine("The string does not have four characters");
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    character = myString[i];
                    if (Char.IsUpper(character))
                        nrUpper += 1;

                }
                if (nrUpper >= 2)
                    Console.WriteLine("New s" +
                        "tring {0}", myString.ToUpper());
                else
                    Console.WriteLine("The string does not meet the condition");
            }

        }

        static void RemoveNewline()
        {
            Console.WriteLine("Enter strings : ");
            string myString = Console.ReadLine();
            string newString = myString.Replace("\\n", "");
            Console.WriteLine(newString);

 
        }

        static void FormattedString()
        {
            Console.WriteLine("Enter the text: ");
            string myText = Console.ReadLine();
            Console.WriteLine("Enter the text width: ");
            int width = int.Parse(Console.ReadLine());
        
            for (int i = 0; i < myText.Length; i=i+width)     
            {

                if (i+width >= myText.Length)   
                {
                    Console.WriteLine(myText.Substring(i));  
                }
                else
                {
                    Console.WriteLine(myText.Substring(i, width));
                 
                }
            }
            
        }
        static void FormatNumber()
        {
            Console.WriteLine("Enter the number: ");
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(number.ToString("P2"));
        }
        static void ReverseString()
        {
            Console.WriteLine("Enter the string :");
            string mystring = Console.ReadLine();
            int n = mystring.Length;
            string newstring = "";
                for (int i = n - 1; i >= 0; i--)
                {
                    newstring = newstring + mystring[i];
                }
                Console.WriteLine(newstring);
       
        }
        static void StripsSetOfCharacters()
        {
            Console.WriteLine("Enter the string: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Enter the set of characters: ");
            string setChar = Console.ReadLine();
            string newString = myString.Replace(setChar, "");
            Console.WriteLine(newString);

        }
        static void TranformsToLowecase()
        {
            Console.WriteLine("Enter the string: ");
            string myString = Console.ReadLine();
            Console.WriteLine("Enter the number n: ");
            int n = int.Parse(Console.ReadLine());
            if (n < myString.Length)
            { 
            string stringForTrans = myString.Substring(0, n);
            string newString = stringForTrans.ToLower() + myString.Substring(n);
                Console.WriteLine(newString);
            }
            else
            {
                if (n == myString.Length)
                    Console.WriteLine(myString.ToLower());
                else
                Console.WriteLine("The length of the string is less than n"); 
            }    
        }
    }
}


