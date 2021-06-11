using BattleSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using textAdventure;

namespace Puzzle
{
    public class Puzzle
    {
        public static bool[] torch = { false, false, false, false };
        public static string str;
        public static string decide;
        public static void controlPuzzle()
        {
            Console.Clear();
            Console.WriteLine("A small table is in front of you; flint and tinder, a black cloth for smothering fire and a small, locked box is on the table.\n" +
                              "Slightly above the table you see four torches aligned horizontally. The number '10' is inscribed on the table.");
            Console.WriteLine($"\n\nCommands:> TORCH[1] TORCH[2] TORCH[3] TORCH[4] [LEAVE] [EXIT]");
            Console.Write("Input:> ");
            str = Console.ReadLine().ToUpper();
            while (true)
            {
                if (str.Length < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Enter # digit, LEAVE or EXIT.");
                }
                else if (int.TryParse(str, out int n))
                {
                    if (Int32.Parse(str) > 0 && Int32.Parse(str) <= 4)
                    {
                        if (torch[Int32.Parse(str) - 1] == false)
                        {
                            torch[Int32.Parse(str) - 1] = true;
                            Console.WriteLine($"Torch {str} is lit");
                        }
                        else
                        {
                            torch[Int32.Parse(str) - 1] = false;
                            Console.WriteLine($"Torch {str} is put out");
                        }
                    }else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input. Enter # digit, LEAVE or EXIT.");
                    }
                }
                else if (str == "EXIT" || str == "E")
                {
                    Console.Clear();
                    Console.WriteLine($"Are you sure you want to stop playing, {Program.player.name}? There is no save function. Sorry.");
                    Console.Write("[Y]ES/[N]O:> ");
                    decide = Console.ReadLine().ToUpper();

                    if (decide == "YES" || decide == "Y")
                    {
                        Console.Clear();
                        Console.WriteLine($"Thank you for playing, {Program.player.name}!");
                        Console.WriteLine(" _____   ___  ___  ___ _____   _____  _   _ ___________");
                        Console.WriteLine("|  __ \\ / _ \\ |  \\/  ||  ___| |  _  || | | |  ___| ___ \\");
                        Console.WriteLine("| |  \\// /_\\ \\| .  . || |__   | | | || | | | |__ | |_/ /");
                        Console.WriteLine("| | __ |  _  || |\\/| ||  __|  | | | || | | |  __||    / ");
                        Console.WriteLine("| |_\\ \\| | | || |  | || |___  \\ \\_/ /\\ \\_/ / |___| |\\ \\ ");
                        Console.WriteLine(" \\____/\\_| |_/\\_|  |_/\\____/   \\___/  \\___/\\____/\\_| \\_|\n\n");
                        Console.WriteLine("Press Enter to exit.");
                        Console.ReadLine();
                        Environment.Exit(-1);
                    }
                    else if (decide == "NO" || decide == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("You decide against leaving. You shake your head as to say: I've come this far, there's no point in turning back now!");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (str == "LEAVE" || str == "L")
                {
                    Console.Clear();
                    Console.WriteLine("Frustrated, you decide to leave this puzzle for later.\n" +
                                      "Maybe there's a hint nearby?\n" +
                                      "Press Enter to continue.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Enter # digit, LEAVE or EXIT.");
                }
                if (torch[0] && !torch[1] && torch[2] && !torch[3])
                {
                    Console.Clear();
                    Console.Write("After arranging the lit torches in a specific pattern, you hear the click of a lock.\n" +
                                  "The small box on the table underneath the torches must've been unlocked!\n" +
                                  "You open the box and find a ");
                    Program.KWStart();
                    Console.Write("heavy key!\n");
                    Program.KWStop();
                    Console.WriteLine("You pocket it.\n\n");
                    Console.WriteLine("You hear a loud mechanical noise coming from the reinforced door.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Program.puzzleSolved = true;
                    break;
                }
                foreach (bool b in torch)
                {
                    if (b)
                    {
                        Console.Write("X  ");
                    }
                    else
                    {
                        Console.Write("O  ");
                    }
                }
                Console.WriteLine($"\n\nCommands:> TORCH[1] TORCH[2] TORCH[3] TORCH[4] [LEAVE] [EXIT]");
                Console.Write("Input:> ");
                str = Console.ReadLine().ToUpper();
                Console.Clear();
            }
        }
    }
}
