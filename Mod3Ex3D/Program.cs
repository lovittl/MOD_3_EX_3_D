using System;

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
            Console.Clear();
            Console.WriteLine("When implemented a list of all account balances will be displayed");
        }

        private static void ViewAccount()
        {
            Console.Clear();
            Console.WriteLine("When implemented another menu will appear and the user will be presented with a " +
                "list of 7 accounts to choose from then once the user makes a choice the information for that " +
                "account will be displayed");
        }

        private static void EnterTransaction()
        {
            Console.Clear();
            Console.WriteLine("When implemented the user will be prompted to enter transaction information one " +
                "field at a time that will be used to build a SQL query to insert the information into the appropriate" +
                "tables in the database");
        }

        private static void ViewReports()
        {
            Console.Clear();
            Console.WriteLine("When implemented a list of reports will be presented and once a selection has been made " +
                "the report will be displayed");
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


        