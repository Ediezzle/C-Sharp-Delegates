using System;

namespace Delegates
{
    class Program
    {
        //Print delegate shown above, can be used to point to any method that has same return type & parameters declared with Print
        // declare delegate
        public delegate void Print(int value);

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        static void Main(string[] args)
        {
            // Print delegate points to PrintNumber
            Print printDel = PrintNumber;

            // or
            // Print printDel = new Print(PrintNumber);

            printDel(100000);
            printDel(200);

            // Print delegate points to PrintMoney
            printDel = PrintMoney;

            printDel(10000);
            printDel(200);
        }

        
    }
}
