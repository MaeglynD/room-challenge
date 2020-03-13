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
        }
    }
}
