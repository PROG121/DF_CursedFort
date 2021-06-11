using System;
using System.Collections.Generic;
using System.Text;
using textAdventure;
using backpack;
namespace BattleSystem
{
    public enum EnemyType
    {
        Skeleton,
        Lich
    }
    public class Player
    {
        public Player(string name)
        {
            this.name = name;
            HP = 25;
            Def = 2;
            Atk = 5;
            backpack = new Backpack();
        }
        public Backpack backpack;
        public string name;
        public int HP { get; set; }
        public int Def { get; set; }
        public int Atk { get; set; }
    }
    public class Enemy
    {
        public Enemy(EnemyType enemyType)
        {
            this.enemyType = enemyType;
            if (enemyType == EnemyType.Skeleton)
            {
                HP = 15;
                Def = 2;
                Atk = 5;
            }
            else if (enemyType == EnemyType.Lich)
            {
                HP = 40;
                Def = 3;
                Atk = 7;
            }
        }
        public EnemyType enemyType { get; set; }
        public int HP { get; set; }
        public int Def { get; set; }
        public int Atk { get; set; }
    }
    public class CombatSystem
    {
        public static void ClearKeyBuffer()
        {
            while (Console.KeyAvailable)
                Console.ReadKey(false);
        }
        public static string fdecide;
        public static void Combat(Player player, Enemy enemy)
        {
            string fightMove;
            while (player.HP > 0 && enemy.HP > 0)
            {
                Console.WriteLine($"\n\n{player.name}\nStats:" +
                                  $" HP: {player.HP} | ATK: {player.Atk} | DEF: {player.Def}\n\n" +
                                  $"{enemy.enemyType.ToString()}\nStats:" +
                                  $" HP: {enemy.HP} | ATK: {enemy.Atk} | DEF: {enemy.Def}\n\n" +
                                  $"Commands:> FIGHT[F] BACKPACK[B] [EXIT]\n");
                Console.Write("Input:> ");
                fightMove = Console.ReadLine().ToUpper();
                if (fightMove == "BACKPACK" || fightMove == "B")
                {
                    player.backpack.ShowBackpack();
                }
                if (fightMove == "EXIT")
                    {
                        while (fdecide != "YES" || fdecide != "Y" || fdecide != "NO" || fdecide != "N")
                        {
                            Console.Clear();
                            Console.WriteLine($"Are you sure you want to stop playing, {player.name}? There is no save function. Sorry.");
                            Console.Write("[Y]ES/[N]O:> ");
                            fdecide = Console.ReadLine().ToUpper();

                            if (fdecide == "YES" || fdecide == "Y")
                            {
                            Console.Clear();
                            Console.WriteLine($"Thank you for playing, {player.name}!");
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
                            else if (fdecide == "NO" || fdecide == "N")
                            {
                                Console.Clear();
                                Console.WriteLine("You decide against leaving. You shake your head as to say: I've come this far, there's no point in turning back now!");
                                Console.WriteLine("Press Enter to continue.");
                                Console.ReadLine();
                            }
                        }
                    }
                Console.Clear();
                while (!(fightMove == "FIGHT" || fightMove == "F" || fightMove == "BACKPACK" || fightMove == "B" || fightMove == "EXIT"))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine($"\n\n{player.name} stats:" +
                                      $" HP: {player.HP} | ATK: {player.Atk} | DEF: {player.Def}\n\n" +
                                      $"{enemy.enemyType.ToString()} stats:" +
                                      $" HP: {enemy.HP} | ATK: {enemy.Atk} | DEF: {enemy.Def}\n\n" +
                                      $"Commands:> FIGHT[F] BACKPACK[B] [EXIT]\n");
                    Console.Write("Input:> ");
                    fightMove = Console.ReadLine().ToUpper();
                    Console.Clear();
                }
                if (fightMove == "FIGHT" || fightMove == "F")
                {
                    PlayerAccuracy(player, enemy);
                    System.Threading.Thread.Sleep(1000);
                    ClearKeyBuffer();
                }
                else if (fightMove == "BACKPACK" || fightMove == "B")
                {
                    player.backpack.ShowBackpack();
                }
                if (fightMove == "EXIT")
                {
                    while (fdecide != "YES" || fdecide != "Y" || fdecide != "NO" || fdecide != "N")
                    {
                        Console.Clear();
                        Console.WriteLine($"Are you sure you want to stop playing, {player.name}? There is no save function. Sorry.");
                        Console.Write("[Y]ES/[N]O:> ");
                        fdecide = Console.ReadLine().ToUpper();

                        if (fdecide == "YES" || fdecide == "Y")
                        {
                            Console.Clear();
                            Console.WriteLine($"Thank you for playing, {player.name}!");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(" _____   ___  ___  ___ _____   _____  _   _ ___________");
                            Console.WriteLine("|  __ \\ / _ \\ |  \\/  ||  ___| |  _  || | | |  ___| ___ \\");
                            Console.WriteLine("| |  \\// /_\\ \\| .  . || |__   | | | || | | | |__ | |_/ /");
                            Console.WriteLine("| | __ |  _  || |\\/| ||  __|  | | | || | | |  __||    / ");
                            Console.WriteLine("| |_\\ \\| | | || |  | || |___  \\ \\_/ /\\ \\_/ / |___| |\\ \\ ");
                            Console.WriteLine(" \\____/\\_| |_/\\_|  |_/\\____/   \\___/  \\___/\\____/\\_| \\_|\n\n");
                            Console.ResetColor();
                            Console.WriteLine("Press Enter to return to the main menu.");
                            Console.ReadLine();
                            Program.menu();
                        }
                            else if (fdecide == "NO" || fdecide == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("You decide against leaving. You shake your head as to say: I've come this far, there's no point in turning back now!");
                            Console.WriteLine("Press Enter to continue.");
                            Console.ReadLine();
                        }
                    }
                }
                if (enemy.HP <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"As {player.name} lands a final blow, the {enemy.enemyType.ToString()} falls apart.\n\n" +
                                      $"You stand victorious!\n");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    break;
                }
                if (enemy.enemyType == EnemyType.Skeleton)
                {
                    EnemyAccuracy(player, enemy);
                }
                else if (enemy.enemyType == EnemyType.Lich)
                {
                    BossAccuracy(player, enemy);
                }
                if (player.HP <= 0)
                {
                    Console.Clear();
                    Console.WriteLine($"The {enemy.enemyType.ToString()} emanates an ominous aura as it suddenly moves faster.\n" +
                                      $"You couldn't see what hit you as your vision fades to black. This is how your adventure ends.\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" _____   ___  ___  ___ _____   _____  _   _ ___________");
                    Console.WriteLine("|  __ \\ / _ \\ |  \\/  ||  ___| |  _  || | | |  ___| ___ \\");
                    Console.WriteLine("| |  \\// /_\\ \\| .  . || |__   | | | || | | | |__ | |_/ /");
                    Console.WriteLine("| | __ |  _  || |\\/| ||  __|  | | | || | | |  __||    / ");
                    Console.WriteLine("| |_\\ \\| | | || |  | || |___  \\ \\_/ /\\ \\_/ / |___| |\\ \\ ");
                    Console.WriteLine(" \\____/\\_| |_/\\_|  |_/\\____/   \\___/  \\___/\\____/\\_| \\_|\n\n");
                    Console.ResetColor();
                    Console.WriteLine("Press Enter to return to the main menu.");
                    Console.ReadLine();
                    Program.menu();
                }
            }
        }
        static void PlayerAccuracy(Player player, Enemy enemy)
        {
            Random rand = new Random();
            int playerAccuracy = Convert.ToInt32(rand.Next(1, 100));
            int DamageToEnemy;
            int DamageToPlayer;
            Program.KWStart();
            Console.Write($"{player.name} attacks:> ");
            Program.KWStop();
            if (playerAccuracy == 1)
            {
                Console.WriteLine($"You somehow manage to throw yourself off balance and smash your face into the wall!\n" +
                                  $"you take {DamageToPlayer = player.Atk + 3} damage.");
                player.HP = player.HP - DamageToPlayer;
            }
            else if (playerAccuracy > 1 && playerAccuracy <= 20)
            {
                Console.WriteLine("You violently cut the air!");
            }
            else if (playerAccuracy > 20 && playerAccuracy <= 35)
            {
                Console.WriteLine($"The {enemy.enemyType.ToString()} raises its guard! You deal {DamageToEnemy = player.Atk - enemy.Def - 2} damage.");
                enemy.HP = enemy.HP - DamageToEnemy;
            }
            else if (playerAccuracy > 35 && playerAccuracy <= 40)
            {
                Console.WriteLine($"The {enemy.enemyType.ToString()} swiftly steps to the side and dodges the attack!");
            }
            else if (playerAccuracy > 40 && playerAccuracy <= 98)
            {
                Console.WriteLine($"You deal {DamageToEnemy = player.Atk - enemy.Def} damage!");
                enemy.HP = enemy.HP - DamageToEnemy;
            }
            else if (playerAccuracy > 98)
            {
                Console.WriteLine($"Your aim is true and you hit a weakpoint on the {enemy.enemyType.ToString()}! " +
                                  $"You deal {DamageToEnemy = player.Atk * 2 + 3 - enemy.Def} critical damage!");
                enemy.HP = enemy.HP - DamageToEnemy;
            }
        }
        static void EnemyAccuracy(Player player, Enemy enemy)
        {
            Random rand = new Random();
            int enemyAccuracy = Convert.ToInt32(rand.Next(1, 100));
            int DamageToEnemy;
            int DamageToPlayer;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{enemy.enemyType.ToString()} attacks:> ");
            Program.KWStop();
            if (enemyAccuracy == 1)
            {
                Console.WriteLine($"The {enemy.enemyType.ToString()} overshoots its swing, throws itself off balance and smashes its skull into the wall!\n" +
                                  $"The {enemy.enemyType.ToString()} takes {DamageToEnemy = enemy.Atk + 3} damage.");
                enemy.HP = enemy.HP - DamageToEnemy;
            }
            else if (enemyAccuracy > 1 && enemyAccuracy <= 35)
            {
                Console.WriteLine($"The {enemy.enemyType.ToString()} misses!");
            }
            else if (enemyAccuracy > 35 && enemyAccuracy <= 50)
            {
                if ((DamageToPlayer = enemy.Atk - player.Def - 2) < 0)
                {
                    Console.WriteLine("You raise your guard and deftly block the attack with your shield!");
                }
                else
                {
                    Console.WriteLine($"You raise your guard and deftly block the attack with your shield! You take {DamageToPlayer = enemy.Atk - player.Def - 2} damage.");
                    player.HP = player.HP - DamageToPlayer;
                }
            }
            else if (enemyAccuracy > 50 && enemyAccuracy <= 65)
            {
                Console.WriteLine("You quickly react to the incoming swing and dodge the attack!");
            }
            else if (enemyAccuracy > 65 && enemyAccuracy <= 99)
            {
                Console.WriteLine($"The {enemy.enemyType.ToString()} deals {DamageToPlayer = enemy.Atk - player.Def} damage.");
                player.HP = player.HP - DamageToPlayer;
            }
            else if(enemyAccuracy == 100)
            {
                Console.WriteLine($"The fearsome mass of bones suddenly move with incredible speed and steps past your guard.\n" +
                                  $"The blow hits a weak point! You take {DamageToPlayer = enemy.Atk * 2 + 3 - player.Def} critical damage!");
                player.HP = player.HP - DamageToPlayer;
            }
        }
        static void BossAccuracy(Player player, Enemy enemy)
        {
            Random rand = new Random();
            int BossAccuracy = Convert.ToInt32(rand.Next(1, 100));
            int DamageToBoss;
            int DamageToPlayer;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{enemy.enemyType.ToString()} attacks:> ");
            Program.KWStop();
            if (BossAccuracy == 1)
            {
                    Console.WriteLine($"The Lich entangles itself in its long robes, slips and hits itself in the face with its staff!\n" +
                                      $"The Lich takes {DamageToBoss = enemy.Atk + 3} damage.");
                    enemy.HP = enemy.HP - DamageToBoss;
                }
                else if (BossAccuracy > 1 && BossAccuracy <= 25)
                {
                    Console.WriteLine("The Lich misses!");
                }
                else if (BossAccuracy > 25 && BossAccuracy <= 45)
                {
                    Console.WriteLine($"You raise your guard and block the attack with your shield! You take {DamageToPlayer = (enemy.Atk - 2) - player.Def} damage.");
                    player.HP = player.HP - DamageToPlayer;
                }
                else if (BossAccuracy > 45 && BossAccuracy <= 55)
                {
                    Console.WriteLine("You quickly react to the incoming swing and dodge the attack!");
                }
                else if (BossAccuracy > 55 && BossAccuracy <= 70)
                {
                    Console.WriteLine($"The Lich aims its staff towards you while uttering alien words. A bolt of lightning shoots out at you!\n" +
                                      $"You take {DamageToPlayer = (enemy.Atk + 1) - player.Def} damage.");
                    player.HP = player.HP - DamageToPlayer;
                }
                else if (BossAccuracy > 70 && BossAccuracy <= 99)
                {
                    Console.WriteLine($"The Lich deals {DamageToPlayer = enemy.Atk - player.Def} damage.");
                    player.HP = player.HP - DamageToPlayer;
                }
                else if (BossAccuracy == 100)
                {
                    Console.WriteLine($"You hear the Lich utter what you assume is a curse. The staff in its hands starts glowing in an eerie red light!\n" +
                                      $"The staff finds a weak point in your armour. You take {DamageToPlayer = enemy.Atk * 2 + 2 - player.Def} critical damage!");
                    player.HP = player.HP - DamageToPlayer;
                }
            }
        }
}