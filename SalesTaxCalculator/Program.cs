using System;

namespace SalesTaxCalculator
{
    class Program 
    {

        Process pobj = new Process();
        
        //Formulas
        //TST = Item Cost x Sales Tax Rate / 100
        //TC = Item Cost + Total Sales Tax
        //STR = Total Sales Tax / Item Cost x 100

        /* Total Sales Tax method for containing the 
          actual function from the Process.cs Class
            */
        public void TST()  
        {
            pobj.TotalSalesTax();
        }
        /* Total Cost method for containing the 
          actual function from the Process.cs Class
            */
        public void TC()
        {
            pobj.TotalCost();
        }
        /* Sales Tax Rate method for containing the 
          actual function from the Process.cs Class
            */
        public void STR()
        {
            pobj.SalesTaxRate();
        }
       
        /*Method for returning to Main after user gets
          the calculated output for the Tax Rate/Cost/etc on
          the press of a key.
            */
        public void Return()
        {
            String option = Console.ReadLine();
            if(option == "y" || option == "Y")
            {
                Console.Clear();
                Main();
            }
            else if(option == "n" || option == "N")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Wrong option. Try again");
                Return();
            }    
            
        }
        // Method for Display message for Return
        public void ReturnMessage()
        {
            String message = "Continue? Y/n";
            Console.WriteLine(message);
        }
        // Method for Instructions on how to calculate
        public void Instructions()
        {

            Console.WriteLine("Sales Tax Calculator - HUSSAIN RAFI");
            Console.WriteLine("Enter one of the numbers shown on the screen to calculate/or to get help");
            Console.WriteLine("1) Calculate Total Sales Tax 2) Calculate Total Cost");
            Console.WriteLine("3) Calculate Sales Tax Rate 4) Help 5) Exit");
        }
        // Method to explain the end-user on how these calculations work through a formula
        public void Help()
        {
            
            Console.WriteLine("These are the formulas for calculating sales tax on a certain product");
            Console.WriteLine("Total Sales Tax = Item Cost * Sales Tax Rate / 100");
            Console.WriteLine("Total Cost = Item Cost + Total Sales Tax");
            Console.WriteLine("Sales Tax Rate = Total Sales Tax / Item Cost * 100");
            
        }
        public void SelectOption()
        {
            Program pr = new Program();
            int option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    pr.TST(); // Total Sales Tax
                    pr.ReturnMessage();
                    pr.Return();
                    break;

                case 2:
                    pr.TC(); // Total Cost
                    pr.ReturnMessage();
                    pr.Return();
                    break;

                case 3:
                    pr.STR(); // Sales Tax Rate
                    pr.ReturnMessage();
                    pr.Return();
                    break;

                case 4:
                    pr.Help(); // Help
                    pr.ReturnMessage();
                    pr.Return();
                    break;

                case 5: // Exit
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Error! Wrong option. Please try again");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                    break;

            }
        }
        public static void Main()
        {
            Console.Title = "Sales Tax Calculator";
            Program pr = new Program();
            pr.Instructions();
            pr.SelectOption();


            Console.ReadKey();
        }

        
    }
}
