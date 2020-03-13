using System;
using System.IO;

namespace room_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make our text cyan and the users white
            void WriteMessage(string msg)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(msg);
                Console.ResetColor();
            }

            // A recursive function that returns only when the user has a entered valid double
            double ValidateDouble(string msg)
            {
                double ToValidate;
                WriteMessage($"\n{msg}");

                if (!double.TryParse(Console.ReadLine(), out ToValidate))
                {
                    WriteMessage("\nHad trouble reading that, enter a valid number (decimals are allowed)");
                    return ValidateDouble(msg);
                }

                return ToValidate;
            };

            // Setup console
            Console.Clear();
            Console.WriteLine(@"
                +------+.
                |`.    | `.
                |  `+--+---+
                |   |  |   |
                +---+--+.  |  (h)
            (l)  `. |    `.|
                   `+------+
                       (w)
            ");

            // Users input
            double paintCoats = ValidateDouble("How many coats of paints would you like?");
            double height = ValidateDouble("Please enter your room's height (h) in metres");
            double width = ValidateDouble("Please enter your room's width (w) in metres");
            double length = ValidateDouble("Please enter your room's length (l) in metres");
        }
    }
}
