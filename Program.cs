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

            // Same as above but with bool's
            bool ValidateBool(string msg)
            {
                WriteMessage($"\n{msg}");
                string input = Console.ReadLine().ToLower();

                if (input != "y" && input != "n")
                {
                    WriteMessage("\nHad trouble reading that, enter Y or N");
                    return ValidateBool(msg);
                }

                return input == "y" ? true : false;
            }

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
            bool ceiling = ValidateBool("Are you painting your ceiling (y/n)?");
            double height = ValidateDouble("Please enter your room's height (h) in metres");
            double width = ValidateDouble("Please enter your room's width (w) in metres");
            double length = ValidateDouble("Please enter your room's length (l) in metres");
            double floor = width * length;

            // Results
            WriteMessage(@$"
+------+.
|`.    | `.     Floor area: { Math.Round(floor, 2) }m²
|  `+--+---+
|   |  |   |    Room volume: { Math.Round(width * height * length, 2) }m³
+---+--+.  |
 `. |    `.|    Paint required: (0.1 litre per 1m²): { Math.Ceiling(paintCoats * ((2 * ((height * width) + (height * length)) + (ceiling ? floor : 0)) / 10) * 100) / 100 } litres
   `+------+  
            ");
        }
    }
}
