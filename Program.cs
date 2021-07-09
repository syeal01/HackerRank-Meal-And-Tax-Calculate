using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Day_2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter meal cost? = ");
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            Console.Write("Enter tip percent? = ");
            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("Enter tax percent? = ");
            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine($"Sending...{meal_cost}, {tip_percent}, {tax_percent}");
            Result.solve(meal_cost, tip_percent, tax_percent);
            
            // Test Cases:
            // Result.solve(12.00, 20, 8);  // Should print 15.
            // Result.solve(100, 15, 8); // Should print 123.
            // Result.solve(15.50, 15, 10); // Should print 19.
            // Result.solve(20.75, 10, 3); // Should print 23.
            // Result.solve(10.25, 17, 5); // Should print 13.
        }
    }

    class Result
    {
        public static int solve(double meal_cost, int tip_percent, int tax_percent)
        {
            Console.WriteLine($"meal_cost = {meal_cost}, tip_percent = {tip_percent}, tax_percent = {tax_percent}");

            double tip = (tip_percent / 100.00) * meal_cost;
            Console.WriteLine($"tip: {tip}");

            double tax = (tax_percent / 100.00) * meal_cost;
            Console.WriteLine($"tax: {tax}");

            double total_cost = meal_cost + tip + tax;
            Console.WriteLine($"total_cost: {total_cost}");

            total_cost = Math.Round(total_cost);
            Console.WriteLine($"total_cost: {total_cost}");

            return (int)total_cost;
            
        }
    }
}
