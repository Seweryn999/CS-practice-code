using System;
using System.Collections.Generic;

public class Budget
{
    

    public static void Main(string[] args)
    {
        budget();
    }

    static void budget()
    {
        while (true)
        {
            Console.WriteLine("-----Choose option-----");
            Console.WriteLine("1. Pass income");
            Console.WriteLine("2. Pass expense");
            Console.WriteLine("3. Show summary");
            Console.WriteLine("Pick your option (1, 2, 3): ");
            string? op = Console.ReadLine(); 

            switch (op)
            {
                case "1":
                    income();
                    break;

                case "2":
                    expenses();
                    break;

                case "3":
                    summary();
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }

    static void income()
    {
        Console.WriteLine("Pass income: ");
        string? income = Console.ReadLine(); 
        
        Console.WriteLine($"Your income: {income}");
    }

    static List<decimal> budgetList = new List<decimal>(); 
    static void expenses()
    {
        Console.WriteLine("Pass expense value: ");
        int expense = Convert.ToInt32(Console.ReadLine()); 
        
        budgetList.Add(expense);
        Console.WriteLine($"You added expense: {expense:C}");
    }

    static void summary()
    {
        Console.WriteLine("-----Your expenses-----");
        if (budgetList.Count == 0)
        {
            Console.WriteLine("You haven't passed any expenses yet");
        }
        else
        {
            decimal expensesSummary = 0;
            foreach (var expense in budgetList)
            {
                Console.WriteLine($"- {expense:C}");
                expensesSummary += expense;
            }
            Console.WriteLine($"Expenses summary: {expensesSummary:C}");
        }
    }
}
