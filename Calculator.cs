using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        while (true) 
        {
            
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                int result = 0;

                if (op == "+")
                {
                    result = num1 + num2;
                }
                else if (op == "-")
                {
                    result = num1 - num2;
                }
                else if (op == "*")
                {
                    result = num1 * num2;
                }
                else if (op == "/")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed. Please try again.");
                        continue; 
                    }
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Invalid operator. Please use +, -, *, or /.");
                    continue; 
                }

                Console.WriteLine("Result: " + result);
                break; 
            }
            
      
    }
}