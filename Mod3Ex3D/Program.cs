﻿using System;

namespace Mod3Ex3D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variable to control menu selection
            int selection = 0;

            do
            {
                DisplayMenu();
                selection = ReadInt();

                //Select matching case attribute returned from method ReadInt
                switch (selection)
                {
                    case 1:
                        //send control to method CheckBalances()
                        CheckBalances();
                        break;
                    case 2:
                        //send control to method ViewAccount()
                        ViewAccount();
                        break;
                    case 3:
                        //send control to method EnterTransaction()
                        EnterTransaction();
                        break;
                    case 4:
                        //send control to method ViewReports()
                        ViewReports();
                        break;
                }

            }

            while (selection != 5);

        }
        //Instructons with instructions for the user to select menu item.
        private static void DisplayMenu()
        {

            Console.WriteLine("MAIN MENU");
            Console.WriteLine("____________________________________________\n");
            Console.WriteLine("Please make a choice from the following list and hit enter");
            Console.WriteLine("1)Check Balances, 2)View Account, 3)Enter Transaction, 4)View Reports, 5)Exit");

        }

        //Methods to build out with logic and sql queries to return information
        private static void CheckBalances()
        {
            Console.WriteLine("Case 1");
        }

        private static void ViewAccount()
        {
            Console.WriteLine("Case 2");
        }

        private static void EnterTransaction()
        {
            Console.WriteLine("Case 3");
        }

        private static void ViewReports()
        {
            Console.WriteLine("Case 4");
        }

        //Get user input and verify it was correctly entered
        private static int ReadInt()
        {
            var validInput = false;
            int val = 0;

            do
            {
                try
                {
                    val = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid selection. Try Again");
                }
            }
            while (!validInput);

            return val;
        }
    }
}


        