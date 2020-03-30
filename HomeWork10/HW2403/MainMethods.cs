using System;

namespace HW2403
{
    class MainMethods
    {
        public static double ValidationStr(string str)
        {
            double number;
            while (!double.TryParse(str, out number))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Insert the number. Try again: ");
                Console.ResetColor();
                str = Console.ReadLine();
            }
            return number;
        }         

    }
}
