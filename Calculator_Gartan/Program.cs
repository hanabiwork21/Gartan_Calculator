﻿using System;

class Program
{
    static void Main()
    {
        bool continueCalculation = true;

        while (continueCalculation)
        {
            Console.WriteLine("Gartan PF1 C# Calculator");
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            if (choice == "5")
            {
                continueCalculation = false;
                break;
            }

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (choice)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Result: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid operation.");
                    break;
            }

            Console.WriteLine();
        }

        Console.WriteLine("Thank you, you may inquire to my bike service!");
    }
}
