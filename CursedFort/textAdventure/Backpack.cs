using System;
using System.Collections.Generic;
using System.Text;
using textAdventure;
using SecretEvent;

namespace backpack
{
    public class Backpack
    {
        public Backpack()
        {
            backPack.Add(Item.WheelofCheese);
        }
        public List<Item> backPack = new List<Item>();
        public void ShowBackpack()
        {
            Console.Clear();
            if (backPack.Count < 1)
            {
                Console.WriteLine("Your backpack is empty.\nPress Enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You open your backpack.");
                for (int i = 0; i < backPack.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{backPack[i]}");
                }
                Console.Write("\nSelect item by number [#] or CLOSE[C]:> ");
                string str = Console.ReadLine().ToUpper();
                 while (true)
                {
                    if (str.Length < 1)
                    {
                    }
                    else if (int.TryParse(str, out int n))
                    {
                        if (Int32.Parse(str) > 0 && Int32.Parse(str) <= backPack.Count)
                        {
                            UseItem(Int32.Parse(str) - 1);
                            break;
                        }
                    }
                    else if (str == "CLOSE" || str == "C")
                    {
                        Console.WriteLine("\nYou close the backpack\nPress Enter to continue.");
                        Console.ReadLine();
                        break;
                    }
                    Console.Write("Incorrect input, select item [#] or CLOSE[C]:> ");
                    str = Console.ReadLine().ToUpper();
                }
            }
        }
        public void UseItem(int slot)
        {
            switch (backPack[slot])
            {
                case Item.SteelMace:
                    Program.player.Atk += 2;
                    backPack.RemoveAt(slot);
                    Program.KWStart();
                    Console.WriteLine("You equip the Steel Mace. Your Attack increase by 2.");
                    Program.KWStop();
                    Console.ReadLine();
                    break;
                case Item.OakShield:
                    Program.player.Def += 2;
                    backPack.RemoveAt(slot);
                    Program.KWStart();
                    Console.WriteLine("You equip the Oak Shield. Your Defense increase by 2.");
                    Program.KWStop();
                    Console.ReadLine();
                    break;
                case Item.HPpotion:
                    Program.player.HP += 10;
                    backPack.RemoveAt(slot);
                    Program.KWStart();
                    Console.WriteLine("You chug the Health Potion. You heal 10 HP.");
                    Program.KWStop();
                    Console.ReadLine();
                    break;
                case Item.WheelofCheese:
                    Program.player.HP++;
                    backPack.RemoveAt(slot);
                    Program.KWStart();
                    Console.WriteLine("You eat a whole wheel of cheese. You heal 1 HP.");
                    Program.KWStop();
                    Console.WriteLine("Laat Dovahkiin would be proud!");
                    Console.ReadLine();
                    break;
                case Item.RoseNecklace:
                    if (Program.secretEventWatched == true)
                    {
                        backPack.RemoveAt(slot);
                        Program.KWStart();
                        Console.WriteLine("As you touch the necklace, it suddenly crumbles to dust.");
                        Program.KWStop();
                        Console.ReadLine();
                        break;
                    }
                    else { 
                    Console.WriteLine("The beautiful piece of jewelery is captivating you for a while.\n" +
                                      "Gazing into the black opal soothes you. You gently put it back in your pouch.");
                    Console.ReadLine();
                    }
                    break;
                default:
                    break;
            }
        }
    }
    public enum Item
    {
        SteelMace,
        OakShield,
        HPpotion,
        WheelofCheese,
        RoseNecklace
    }
}