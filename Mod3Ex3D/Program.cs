using System;

namespace Mod3Ex3D
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection = 0;
            do
            {
                DisplayMenu();
                selection = ReadInt();

                switch (selection)
                {
                    case 1:
                        //send control to method checkBalances()
                        CheckBalances();
                        break;
                    case 2:
                        //send control to method viewAccount()
                        ViewAccount();
                        break;
                    case 3:
                        //send control to method enterTransaction()
                        EnterTransaction();
                        break;
                    case 4:
                        //send control to method viewReports()
                        ViewReports();
                        break;
                }
                
            }

            while (selection != 5);

        }

        private static void DisplayMenu()
        {

            Console.WriteLine("MAIN MENU");
            Console.WriteLine("____________________________________________\n");
            Console.WriteLine("Please make a choice from the following list and hit enter");
            Console.WriteLine("1)Check Balances, 2)View Account, 3)Enter Transaction, 4)View Reports, 5)Exit");

        }

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





        //******************************GARBAGE****************************************************

        // int getMenuNumber =  
        //Produce a two column accounting system that
        //has 7 standard categories -- 
        //assets, 
        // user starts program
        //user presented with 4 possible actions (main menu)
        /*   int getMenuNumber =
           Console.Read();

           //switch;
        */
        //1)check balances
        // Console.WriteLine("Check Balances");
        //user selects 1 and presses enter.  
        //all balances are displayed
        //user is returned to the Main Menu
        /*   2)view account
                  screen is cleared in case other functions had been called previously

                  a sql query is sent to the database and a view is displayed to the user 
                  containing all the data elements of an account. 
                  ?are all elements from the same table or multiple tables?
            */
        // ClearConsole ClearMyConsole = new ClearConsole();

        //3)enter Transaction
        //4)view reports
        //start program
        //user presented with 4 choices above
        //user chooses 1
        //balances of all accounts are displayed
        //user is returned to a prompt presenting 4 choices as before
        //user choosed 2
        //user is presented with the list of 7 accounts
        //user selects account
        //account information is displayed
        //return to main menu




        //Console.WriteLine = int.parse(Console.Read("cats"));

        //Console.WriteLine("Hello World!");
    }
}


