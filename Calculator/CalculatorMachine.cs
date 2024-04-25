using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorMachine
    {
        private string? option;
        public string Operation => option ?? string.Empty;

        public double calculate(double num1, double num2)
        {
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            string? operate = Console.ReadLine();

            // Validate input is not null, and matches the pattern
            while (operate == null || !Regex.IsMatch(operate, "[a|s|m|d]"))
            {
                Console.WriteLine("Error: Unrecognized input. Enter a valid operation.");
                operate = Console.ReadLine();
            }
            try
            {
                switch (operate)
                {
                    case "a":
                        option = "+";
                        return num1 + num2;
                    case "s":
                        option = "-";
                        return num1 - num2;
                    case "m":
                        option = "*";
                        return num1 * num2;
                    case "d":
                        option = "/";
                        return num1 / num2;
                }
            }catch (Exception e)
            {
                Console.WriteLine("A mathematical error has occured.");
            }
            return 0;
        }

        public double getNumber(string promptMessage)
        {
            string? tempNum = "";
            Console.Write(promptMessage);
            tempNum = Console.ReadLine();
            double num = 0;

            while (!double.TryParse(tempNum, out num))
            {
                Console.WriteLine($"{tempNum} is not a valid numeric value! Try again.");
                tempNum = Console.ReadLine();
            }
            return num;
        }
    }
}
