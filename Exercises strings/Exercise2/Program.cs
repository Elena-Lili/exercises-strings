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
            if ((n%4) != 0)
            {
                Console.WriteLine("The length of string isn't a multiple of 4");
            }
            else
            {
                string newstring="";
                for (int i = n-1; i >= 0; i--)
                {
                    newstring = newstring + mystring[i];
                }
                Console.WriteLine(newstring);
            }

        }


    }
}
