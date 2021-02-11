using System;

namespace SalesTaxCalculator
{
    class Process
    {
        //Formulas
        //TST = Item Cost x Sales Tax Rate / 100
        //TC = Item Cost + Total Sales Tax
        //STR = Total Sales Tax / Item Cost x 100
        

        public double itemcost; // Double variable for Item Cost
        public double totalsalestax; // Double variable for Total Sales Tax
        public double salestaxrate; // Double variable for Sales Tax Rate
        public double totalcost; // Double variable for Total Cost
        
        public void ClearScreen() // Method to Clear Screen 
        {
            Console.Clear();
            Console.ReadKey();
        }

        // Method for Error Message if one of the user input
        // is zero or less than zero
        public void ErrorMessage() 
        {
            Console.WriteLine("Error! Amount is 0. Try again. Press any key to continue");
        }
        public void TotalSalesTax()
        {
            Console.WriteLine("Enter Item Cost:");
            itemcost = Double.Parse(Console.ReadLine()); 
            if(itemcost == 0 || itemcost < 0) { ErrorMessage(); ClearScreen(); TotalSalesTax(); }
            Console.WriteLine("Enter Sales Tax Rate:");
            salestaxrate = Double.Parse(Console.ReadLine()) / 100;
            if (salestaxrate == 0 || salestaxrate < 0) { ErrorMessage(); ClearScreen(); TotalSalesTax(); }
            totalsalestax = itemcost * salestaxrate;
            Console.WriteLine("Your total sales tax is "+totalsalestax);
            
        }
        public void TotalCost()
        {
            Console.WriteLine("Enter Item Cost:");
            itemcost = Double.Parse(Console.ReadLine());
            if (itemcost == 0 || itemcost < 0) { ErrorMessage(); ClearScreen(); TotalCost(); }
            Console.WriteLine("Enter Total Sales Tax:");
            totalsalestax = Double.Parse(Console.ReadLine());
            if (totalsalestax == 0 || totalsalestax < 0) { ErrorMessage(); ClearScreen(); TotalCost(); }
            totalcost = itemcost + totalsalestax;
            Console.WriteLine("Your total cost is " + totalcost);
            
        }

        public void SalesTaxRate()
        {
            Console.WriteLine("Enter Total Sales Tax:");
            totalsalestax = Double.Parse(Console.ReadLine());
            if (totalsalestax == 0 || totalsalestax < 0) { ErrorMessage(); ClearScreen(); SalesTaxRate(); }
            Console.WriteLine("Enter Item Cost:");
            itemcost = Double.Parse(Console.ReadLine());
            if (itemcost == 0 || itemcost < 0) { ErrorMessage(); ClearScreen(); SalesTaxRate(); }
            salestaxrate = totalsalestax / itemcost * 100;
            Console.WriteLine("Your sales tax rate is " + salestaxrate + "%");
            
        }

    }
}
