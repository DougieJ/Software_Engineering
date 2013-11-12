using System;

public class Calculator
{
    public static void Main()
    {
        int TMS = 0; // tea milk and sugar counting
        int TMO = 0; // tea milk only count
        int TSO = 0; // tea sugar only count
        int QUIT = 0; // count to see if the user wants to quit
        char OPT; // char for switch : user input choice

        do
        {

            Console.WriteLine("Please make an option for which drink you want, or wether you want to quit the program");
            Console.WriteLine("Please select a number.");
            Console.WriteLine("1 : Tea with Milk and sugar.");
            Console.WriteLine("2 : Tea with Milk only.");
            Console.WriteLine("3 : Tea with Sugar only.");
            Console.WriteLine("4 : Quit the program.");
            OPT = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            switch (OPT)
            {
                case '1':
                    TMS++;
                    Console.WriteLine("You have chosen Tea with Milk and Sugar.");
                    Console.WriteLine("There have been " + TMS + " sales so far.");
                    Console.WriteLine();
                    break;

                case '2':
                    TMO++;
                    Console.WriteLine("You have chose Tea with Milk only.");
                    Console.WriteLine("There have been " + TMO + " sales so far.");
                    Console.WriteLine();
                    break;

                case '3':
                    TSO++;
                    Console.WriteLine("You have chose Tea with Sugar only.");
                    Console.WriteLine("There have been " + TSO + " sales so far.");
                    Console.WriteLine();
                    break;

                case '4':
                    QUIT++;
                    break;

                default:
                    Console.WriteLine("This is an incorrect function, please try again.");
                    Console.WriteLine();
                    break;
            }

        }
        while (QUIT < 1);
    } 
}
