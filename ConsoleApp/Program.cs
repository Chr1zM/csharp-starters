using System;
using System.Globalization;

namespace ConsoleApp
{
    static class Program
    {
        static bool CheckArguments(string[] args, out double left, out double right)
        {
            if (args is not null &&
                args.Length > 2 &&
                double.TryParse(args[1], CultureInfo.CurrentCulture, out left) &&
                double.TryParse(args[2], CultureInfo.CurrentCulture, out right))
            {
                return true;
            }

            left = 0;
            right = 0;
            return false;
        }

        static void Main(string[] args)
        {
            if (!CheckArguments(args, out var left, out var right))
            {
                WriteLineColorized("Invalid arguments.", ConsoleColor.Red);
                return;
            }

            switch (args[0].ToLower())
            {
                case "add":
                    WriteLineColorized($"{left} + {right} = {left + right}", ConsoleColor.Green);
                    break;

                case "subtract":
                    WriteLineColorized($"{left} - {right} = {left - right}", ConsoleColor.Green);
                    break;

                case "multiply":
                    WriteLineColorized($"{left} * {right} = {left * right}", ConsoleColor.Green);
                    break;

                case "divide":
                    WriteLineColorized($"{left} / {right} = {left / right}", ConsoleColor.Green);
                    break;

                default:
                    WriteLineColorized("Invalid operation.", ConsoleColor.Red);
                    break;
            }
        }

        static void WriteLineColorized(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}