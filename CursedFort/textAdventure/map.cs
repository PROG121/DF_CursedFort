using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure
{
    class mapSystem
    {
        public static void Map()
        {
            Console.Clear();
            Console.WriteLine("You decide to take a moment and check the very badly scribbled map\n" +
                              "a drunkard at the Tavern drew for you last night.\n" +
                              "Scratching your head, you keep telling yourself it's better than no map at all.\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("         ___ ___ ___ ___ ");
            Console.WriteLine("        |   |   |   |   |");
            Console.WriteLine("        |___|___|___|___|___");
            Console.WriteLine("            |   |   |   |   |");
            Console.WriteLine("            |___|   |___|___|");
            Console.WriteLine("            |   |   |   |");
            Console.WriteLine(" ___ ___ ___|___|___|___|___");
            Console.WriteLine("|   |   |   |   |   |   |   |");
            Console.WriteLine("|___|___|___|___|___|___|___|");
            Console.WriteLine("    |   |   |   |       |   |");
            Console.WriteLine("    |___|   |___|       |___|");
            Console.WriteLine("      X                 |   |");
            Console.WriteLine("                        |___|\n");
            Console.ResetColor();
            Console.WriteLine("A quick note at the bottom of the scroll reads:\n" +
                              "X marks the entrance.\n");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }
    }
}
