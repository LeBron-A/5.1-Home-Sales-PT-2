using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] salesPeople = { "Danielle", "Edward", "Francis" };
        char[] initials = { 'D', 'E', 'F' };
        double[] totalSales = { 0.0, 0.0, 0.0 };
        double grandTotal = 0.0;
        char inital;

        while (true)
        {
            Console.WriteLine("Enter the salesperson initial or hit Z to quit");
            inital = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            if (inital == 'Z')
            {
                break;
            }
            else if (inital != 'D' && inital != 'E' && inital != 'F')
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            Console.WriteLine("Enter the sales amount");
            double salesAmount = Convert.ToDouble(Console.ReadLine());

            int index = Array.IndexOf(initials, inital);

            totalSales[index] += salesAmount;

            grandTotal += salesAmount;
        }

        Console.WriteLine("Grand Total: $" + grandTotal);

        if (totalSales[0] > totalSales[1] && totalSales[0] > totalSales[2])
        {
            Console.WriteLine("Highest Sale: D");
        }
        else if (totalSales[1] > totalSales[0] && totalSales[1] > totalSales[2])
        {
            Console.WriteLine("Highest Sale: E");
        }
        else if (totalSales[2] > totalSales[0] && totalSales[2] > totalSales[1])
        {
            Console.WriteLine("Highest Sale: F");
        }
    }
}
