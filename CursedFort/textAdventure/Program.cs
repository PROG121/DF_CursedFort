using BattleSystem;
using System;
using backpack;
using Puzzle;
using SecretEvent;

namespace textAdventure
{
    public class Program
    {
        public static string move;
        public static int guardQuarterKey = 1;
        public static int guardQuarterKeyUnlocked = 0;
        public static int hallOfTorchesKey = 1;
        public static int hallOfTorchesKeyUnlocked = 0;
        public static int treasuryKey = 1;
        public static int treasuryKeyUnlocked = 0;
        public static Player player;
        public static int SWBhealthPotion = 1;
        public static int EWBhealthPotion = 1;
        public static int NWLhealthPotion = 1;
        public static int Mace = 1;
        public static int OakShield = 1;
        public static bool southwingskeleton = true;
        public static bool dampcellarskeleton = true;
        public static bool northstairwellskeleton = true;
        public static bool throneroomlich = true;
        public static string decide;
        public static bool puzzleSolved = false;
        public static bool lockedChest = true;
        public static bool magicTrinket = false;
        public static bool trinketActivated = false;
        public static bool puzzleActivated = false;
        public static bool secretEventWatched = false;
        public static void controls()
        {
            Console.WriteLine($"\n\n{player.name}\nStats:\nHP: {player.HP} | ATK: {player.Atk} | DEF: {player.Def}" +
                              $"\nCommands:> NORTH[N] WEST[W] SOUTH[S] EAST[E] BACKPACK[B] MAP[M] [EXIT]");
            Console.Write("Input:> ");
            move = Console.ReadLine();
            move = move.ToUpper();
            if (move == "BACKPACK" || move == "B")
            {
                player.backpack.ShowBackpack();
            }
            if (move =="MAP" || move == "M")
            {
                mapSystem.Map();
            }
            if (move == "EXIT")
            {
                while (decide != "YES" || decide != "Y" || decide != "NO" || decide != "N")
                {
                    Console.Clear();
                    Console.WriteLine($"Are you sure you want to stop playing, {player.name}? There is no save function. Sorry.");
                    Console.Write("[Y]ES/[N]O:> ");
                    decide = Console.ReadLine().ToUpper();
                    if (decide == "YES" || decide == "Y")
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
                        menu();
                    }
                    else if (decide == "NO" || decide == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("You decide against leaving. You shake your head as to say: I've come this far, there's no point in turning back now!");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
        public static void menu()
        {
        guardQuarterKey = 1;
        guardQuarterKeyUnlocked = 0;
        hallOfTorchesKey = 1;
        hallOfTorchesKeyUnlocked = 0;
        treasuryKey = 1;
        treasuryKeyUnlocked = 0;
        SWBhealthPotion = 1;
        EWBhealthPotion = 1;
        NWLhealthPotion = 1;
        Mace = 1;
        OakShield = 1;
        southwingskeleton = true;
        dampcellarskeleton = true;
        northstairwellskeleton = true;
        throneroomlich = true;
        puzzleSolved = false;
        lockedChest = true;
        magicTrinket = false;
        trinketActivated = false;
        puzzleActivated = false;
        secretEventWatched = false;
            while (true) 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" _____ _   _______  _____ ___________  ______ ___________ _____ ");
                Console.WriteLine("/  __ \\ | | | ___ \\/  ___|  ___|  _  \\ |  ___|  _  | ___ \\_   _|");
                Console.WriteLine("| /  \\/ | | | |_/ /\\ `--.| |__ | | | | | |_  | | | | |_/ / | |  ");
                Console.WriteLine("| |   | | | |    /  `--. \\  __|| | | | |  _| | | | |    /  | |  ");
                Console.WriteLine("| \\__/\\ |_| | |\\ \\ /\\__/ / |___| |/ /  | |   \\ \\_/ / |\\ \\  | |  ");
                Console.WriteLine(" \\____/\\___/\\_| \\_|\\____/\\____/|___/   \\_|    \\___/\\_| \\_| \\_/  \n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("A text based RPG created by Daniel 'Lefuden' Frykman\n\n");
                Console.ResetColor();
                Console.WriteLine("1. New game");
                Console.WriteLine("2. Exit\n\n");
                Console.Write("Input:> ");
                move = Console.ReadLine();
                if (move == "1")
                {
                    Console.Write("Enter your name:> ");
                    player = new Player(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"This all started in a tavern in a sleepy hamlet, quite a few hours from where you now stand.\n" +
                                      $"After hearing stories of a 'cursed fort' on a remote island, and people never to be seen again,\n" +
                                      $"you -drunkenly- proclaimed that YOU - {player.name}, mighty adventurer - shall free these poor souls\n" +
                                      $"from whatever dangers hiding in this so called 'cursed fort'.\n\n" +
                                      $"And so, your adventure begins.\n");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Entrance();
                }
                else if (move == "2")
                {
                    Environment.Exit(-1);
                }
            }
        }
        public static void KWStart()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public static void KWStop()
        { 
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Default Title: {0}", Console.Title);
            Console.Title = "Cursed Fort by Lefuden v.1.1.2";
            Console.WriteLine("Changed Title: {0}", Console.Title);
            Console.Clear();
            menu();
        }
        static void Entrance()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"You stand in front of a large black gate.\nIt is surrounded by water on both sides.\nBehind you is the boat you arrived on.\n" +
                                  $"The sun is starting to set.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You gaze out over the dark, foreboding water. You cannot hear any sounds of animals nor wind.\n" +
                                      "Weird -you think to yourself- I could hear the screeching seagulls up until I set foot on this island.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("You look around, your eyes following the side of the fort.\n" +
                                      "You notice a balcony higher up protruding from the east fort walls.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("As you step closer to the black gate, you see it has been reinforced with some form of metal,\nshaped in intricate designs." +
                                      "\nThinking back to the previous night in the Tavern, you know why you are here.\n\n" +
                                      "The large sum of gold that will be yours once you've successfully investigated this godforsaken place.\n" +
                                      "Who knows what sort of riches you'll find inside?\n\n" +
                                      "You muster your courage and steel yourself for whatever is to come.\n\n" +
                                      "You open the gate and step inside.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Hallway();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You turn south to your boat, do you really wish to abandon this adventure and return home to safety?");
                    Console.Write("[Y]ES/[N]O:> ");
                    string decide = Console.ReadLine().ToUpper();
                    if (decide == "YES" || decide == "Y")
                    {
                        Console.Clear();
                        Console.WriteLine("You thought being an adventurer was what you wanted to be, but a sudden realisation convinces you\n" +
                                          "that your real calling is goat herding. \nYou step on to the boat and raise the sail.\n\n");
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
                        menu();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You decide against leaving. You shake your head as to say: I've come this far, there's no point in turning back now!");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        Entrance();
                    }
                }
            }
        }
        static void Hallway()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You enter a large hallway.\n" +
                                  "The light is dim and the pillars and broken furniture is covered in dust and spiderwebs.\n" +
                                  "The air is cold and feels heavy, like moments before a thunderstorm.\n" +
                                  "This place must have been abandoned a long time ago.\nYou see two doors, one to the west and the other to the east.\n" +
                                  "The large open gate is to the south.");
                controls();
                if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("A lone torch fitted to a sconce. It barely lights up the area enough for you to not stumble blindly.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "EAST" || move == "E")
                {
                    if (guardQuarterKey == 0)
                    {
                        Console.Clear();
                        Console.Write("You try the ");
                        KWStart();
                        Console.Write("small silver key ");
                        KWStop();
                        Console.Write("you found in the Guards Quarter.\nWith a gentle click the door is unlocked. You step inside.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        guardQuarterKeyUnlocked = 1;
                        guardQuarterKey = 1;
                        SouthWingStairwell();
                    }
                    else if (guardQuarterKeyUnlocked == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("You open the door.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        SouthWingStairwell();
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("The door is locked. Perhaps there's a ");
                        KWStart();
                        Console.Write("key ");
                        KWStop();
                        Console.Write("somewhere.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You decide against exploring this dreary place and go back out.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Entrance();
                }
                else if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("The door creaks open.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    GuardsQuarter();
                }
            }
        }
        static void GuardsQuarter()
        {
            while (true)
            {
                if(guardQuarterKey == 1)
                {
                    Console.Clear();
                    Console.WriteLine("As you step into the room via the south door, you see what looks like a small Guards Quarters. \nThere are weapons along the side of the east wall," +
                                      " and an empty fireplace straight ahead to the north.\nTo the west you see a wooden table with something shiny on top of it.");
                    controls();
                }
                else if (guardQuarterKey == 0)
                {
                    Console.Clear();
                    Console.WriteLine("As you step into the room via the south door, you see what looks like a small Guards Quarters. \nThere are weapons along the side of the east wall," +
                                      " and an empty fireplace straight ahead to the north.\nTo the west you see a wooden table.");
                    controls();
                }
                
                if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("There is nothing of interest in the fireplace.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("You glance over the weaponry on the wall, what once probably was a rather impressive display\n" +
                                      "has with time been reduced to worthless trinkets. They have degraded beyond repair.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You leave the Guards Quarters and return to the Hallway.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Hallway();
                }
                else if (move == "WEST" || move == "W")
                {
                    if (guardQuarterKey == 1)
                    {
                        Console.Clear();
                        Console.Write("The shiny object on the table is a ");
                        KWStart();
                        Console.Write("small silver key");
                        KWStop();
                        Console.Write(", you pocket it.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        guardQuarterKey--;
                    }
                    else if (guardQuarterKey == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing else of value on the table.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
        static void SouthWingStairwell()
        {
            while (true)
            {
                if (southwingskeleton)
                {
                    Console.Clear();
                    Console.WriteLine("You find yourself in a short corridor, but before you have time to look around you notice a Skeleton in front of you.\n" +
                                      "The skull cap on its head is rusted. It has an axe and a wooden shield in its hands.\n" +
                                      "It turns around and looks at you through empty eye sockets.\n" +
                                      "Suddenly it starts moving towards you - Prepare for battle!");
                    CombatSystem.Combat(player, new Enemy(EnemyType.Skeleton));
                    southwingskeleton = false;
                }
                else if (!southwingskeleton)
                {
                    Console.Clear();
                    Console.WriteLine("You stand in a short corridor. There are sconces on the walls, lighting up the area.\n" +
                                      "A moldy red carpet leads between the two doors, west and east.\n" +
                                      "The remains of the Skeleton you fought lie in a pile on the floor. There is an eerie calm in this room now.");
                    controls();
                    if (move == "NORTH" || move == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("You look through a window, you can see a large stone bridge slightly to the east.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (move == "SOUTH" || move == "S")
                    {
                        Console.Clear();
                        Console.WriteLine("You inspect the sturdy wall. This is some fine stone masonry.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (move == "WEST" || move == "W")
                    {
                        Console.Clear();
                        Console.WriteLine("You leave the short corridor and enter the hallway.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        Hallway();
                    }
                    else if (move == "EAST" || move == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You see an open door, leading to a stairwell going up.\nYou ascend.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        SouthWingLanding();
                    }
                }
            }
        }
        static void SouthWingLanding()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You arrive in a large square room. This area is a lot more open,\n" +
                                  "there's no need for any lit torches here.\nYou can feel a chill breeze coming in from the north archway,\n" +
                                  "flowing through the room and out the south arch.\nThere are four stone pillars in a square shape, " +
                                  "a few meters apart in the middle of the room.\nThe stairwell is to the west,\nand there's another door to the east.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You descend the stairs.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWingStairwell();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("You move towards the breeze and step through the archway.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthBrokenBridge();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You decide to explore the south archway.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWingBalcony();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("You try the east door, it creaks open.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWingCorridor();
                }
            }
        }
        static void SouthWingBalcony()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You arrive on a balcony through the north door. The fresh air fill your lungs as you stand there,\nleaning against the railing for a while.\n" +
                                  "Looking around this small space, you don't see much of value. Perhaps it's worth a closer look either way.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You gaze out over the water, it's quiet. Too quiet. No birds, no fish - only the soft whispers of the wind.\n" +
                                      "You can see your boat slightly to the west, anchored close to the entrance of the fort.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("You turn back and step through the archway.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWingLanding();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    if (SWBhealthPotion == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("As you put your hand on the cold stone railing, a part of it comes loose and falls into the water with a splash.\n" +
                                          "You push back with your other hand, and as you re-adjust you notice something in the corner of your eye.\n");
                        Console.Write("There's a ");
                        KWStart();
                        Console.Write("glass bottle ");
                        KWStop();
                        Console.Write("with a red liquid inside laying on the ground.\nYou pocket it.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        SWBhealthPotion--;
                        player.backpack.backPack.Add(Item.HPpotion);
                    }
                    else if (SWBhealthPotion == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You take another careful look around, in case of other items scattered around.\n" +
                                          "There is nothing else of value.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("You decide to lean over the railing a bit out of curiosity.\n" +
                                      "I could probably survive this fall - you think to yourself.\n" +
                                      "You step away from the railing, shaking your head.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
            }
        }
        static void SouthBrokenBridge()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You stand on what once was a rather impressive stone bridge. Heavy winds hit you from the west.\n" +
                                  "The middle part of the bridge, to the north, has fallen apart and you see no way of getting to the other side.\n" +
                                  "You notice something on the ground to the east.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You face the heavy wind, the pressure makes it hard to breathe.\n" +
                                      "Covering your face with one arm, you turn back around.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("Taking a quick look at the fallen bridge, you decide it's not worth risking your life trying to find a way over.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You shiver from the heavy winds. You decide there's nothing to be gained here besides a cold.\n" +
                                      "You return to the previous room.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWingLanding();
                }
                else if (move == "EAST" || move == "E")
                {
                    if (Mace == 1)
                    {
                        Console.Clear();
                        Console.Write("The dark towering stone walls of the fort fills you with an ominous feeling.\n" +
                                      "A fallen adventurer is slumped against the wall. The ");
                        KWStart();
                        Console.Write("mace ");
                        KWStop();
                        Console.Write("in his hand looks like it's made of high quality steel.\n");
                        Console.WriteLine("You carefully take it, trying not to anger any potential spirits hanging around.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        Mace--;
                        player.backpack.backPack.Add(Item.SteelMace);
                    }
                    else if (Mace == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("The dark towering stone walls of the fort fills you with an ominous feeling.\n" +
                                          "A fallen adventurer is slumped against the wall.\n" +
                                          "He's probably one of many would-be adventurers taking on the 'cursed fort'.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
        static void SouthWingCorridor()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You find yourself in a short and narrow corridor, a trickle of light emanates from a crack in the wall.\n" +
                                  "The sides are littered with rubble. East and west has one door each.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You decide to return to the South Wing Landing.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWingLanding();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("You glance over the rubble, you find nothing of value.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You stand in the sliver of light shining through the worn down wall.\n" +
                                      "Somehow you find a moment of respite. You stand tall and stretch for a bit.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("Another unlocked door, you leave the small corridor.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWing3WayRoom();
                }
            }
        }
        static void SouthWing3WayRoom()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Another dimly lit room, this area is also full of rubble.\n" +
                                  "There must've been some heavy fighting going on in this part of the fort.\n" +
                                  "There's an archway to the north, a door to the west. You spot a stairwell to the east.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You return to the small corridor.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWingCorridor();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("You walk through the archway.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    EastStairwell();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("The southern wall has partly disintegrated, you can smell the salt of the ocean.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("As you descend the stairwell, you feel the air getting colder and humid.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    DampCellar();
                }
            }
        }
        static void DampCellar()
        {
            while (true)
            {
                if (dampcellarskeleton)
                {
                    Console.Clear();
                    Console.WriteLine("As you take the last step of the stairwell and enter the damp cellar, you hear the rattling of bones.\n" +
                                      "A menacing Skeleton soldier stands in your way. It holds a large spiked club in its hands.\n" +
                                      "Before you get a chance to react it charges you. Prepare to fight!");
                    CombatSystem.Combat(player, new Enemy(EnemyType.Skeleton));
                    dampcellarskeleton = false;
                }
                else if (!dampcellarskeleton)
                {
                    Console.Clear();
                    Console.WriteLine("Stepping foot in the damp cellar, you feel like leaving as soon as possible. The smell is horrendous.\n" +
                                      "You quickly dart your eyes around the room, you see nothing that stands out.\n" +
                                      "The stairwell is to the west, an open door to the south.");
                    controls();
                    if (move == "WEST" || move == "W")
                    {
                        Console.Clear();
                        Console.WriteLine("You ascend the stairwell. You instantly feel better.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        SouthWing3WayRoom();
                    }
                    else if (move == "NORTH" || move == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("You could swear you saw something moving in the corner of your eye.\n" +
                                          "The skittering of what you can only assume are rats silently echo across the damp cellar.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (move == "SOUTH" || move == "S")
                    {
                        Console.Clear();
                        Console.WriteLine("Through the open door to the south, you see a very brightly lit room, you decide to investigate.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        HallOfTorches();
                    }
                    else if (move == "EAST" || move == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("Pools of knee high water fills the east part of the cellar.\n" +
                                          "Your nose catches a whiff of what can only be described as putrifying corpses.\n" +
                                          "You begin to feel nauseous.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
        static void HallOfTorches()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You step into a large hall full of lit sconces along the walls.\nThe cellar is through the north door.\n" +
                                  "There's a large, rather impressive reinforced door to the south.\n" +
                                  "You notice four unlit torches to the east of the door, curious..");
                controls();
                if (move == "WEST" || move == "W")
                {
                    if (puzzleActivated == false){
                        Console.Clear();
                        Console.WriteLine("A small part of the wall has no light reaching it.\n" +
                                          "It looks like something's written here, but you can't quite make it out.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (puzzleActivated == true)
                    {
                        Console.Clear();
                        Console.WriteLine("The light from the torches illuminates the previously dark part of the wall.\n" +
                                          "You make out the writing as 'XOXO'. Interesting..");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("You brace yourself for the disgusting odor, as you return to the damp cellar.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    DampCellar();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    if (puzzleSolved == true)
                    {
                        Console.WriteLine("It seems the loud noise you heard was the door unlocking.\n" +
                                          "You enter the room.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        Treasury();
                    }
                    else
                    {
                        Console.WriteLine("The door is locked, with no discernable keyhole.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (move == "EAST" || move == "E")
                {
                    if (!puzzleSolved)
                    {
                        puzzleActivated = true;
                        Puzzle.Puzzle.controlPuzzle();
                    }
                    else if (puzzleSolved)
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing else of value.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
        static void Treasury()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("This room is very slightly lit up by the light from the previous hall.\n" +
                                  "There's lots of chests along the walls, this has to be the fort treasury!");
                controls();
                if (move == "WEST" || move == "W")
                {
                    if (Mace == 1 && lockedChest == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Sadly, all of the chests are locked and secured by heavy reinforced metal.\n" +
                                          "You notice one of the chests has a slightly worn lock on it." +
                                          "You unsuccessfully try to pry it open.\n" +
                                          "Disappointed you decide it's not worth ruining your weapon for this.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (Mace == 0 && lockedChest == true && player.Atk == 7)
                    {
                        Console.Clear();
                        Console.WriteLine("All of the chests are locked and secured by heavy reinforced metal.\n" +
                                          "You notice one of the chests has a slightly worn lock on it.\n" +
                                          "You decide to give it a proper bashing with your old weapon.\n\n" +
                                          "After a couple well aimed swings, you successfully remove the lock!\n" +
                                          "Your old weapon breaks, luckily you found that steel mace earlier.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        Console.Write("Resting on a bed of fine, red silk, you find a beautiful ");
                        KWStart();
                        Console.Write("rose necklace");
                        KWStop();
                        Console.Write(". The bud is made out of black opal.\n");
                        Console.WriteLine("As you take a closer look, it feels like you're gazing at the night sky.\n" +
                                          "This must be worth a fortune!\n" +
                                          "You carefully place it in your pouch.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        lockedChest = false;
                        magicTrinket = true;
                        player.backpack.backPack.Add(Item.RoseNecklace);
                    }
                    else if (Mace == 0 && lockedChest == false)
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing else of value. Your old broken weapon is on the ground.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Sadly, all of the chests are locked and secured by heavy reinforced metal.\n" +
                                          "You notice one of the chests has a slightly worn lock on it." +
                                          "You unsuccessfully try to pry it open.\n" +
                                          "Dissapointed you decide it's not worth ruining your weapon for this.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("After taking another look around, you decide it's time to leave.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    HallOfTorches();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    if (treasuryKey == 1)
                    {
                        Console.Clear();
                        Console.Write("You find a finely crafted ");
                        KWStart();
                        Console.Write("ornate key!\n");
                        KWStop();
                        Console.Write("You pocket it.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        treasuryKey--;
                    }
                    else if (treasuryKey == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("There is nothing else of value, yet you insist of taking another close look,\n" +
                                          " just in case.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (move == "EAST" || move == "E")
                {
                    if (OakShield == 1)
                    {
                        Console.Clear();
                        Console.Write("You find a very sturdy ");
                        KWStart();
                        Console.Write("oak shield ");
                        KWStop();
                        Console.Write("on top of one of the many locked chests.\nThis will surely come in handy!\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        OakShield--;
                        player.backpack.backPack.Add(Item.OakShield);
                    }
                    else if (OakShield == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You take another careful look around, in case of other items scattered around.\n" +
                                          "There is nothing else of value, besides the heavily reinforced chests.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
        static void EastStairwell()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("This area has seen better days. A large pile of stone and wooden beams lie in the middle of the room.\n" +
                                  "You look up and notice the roof has caved in. There's a door to the north and the south.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You dart your eyes around a bit, you see nothing of interest.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "NORTH" || move == "N")
                {
                    if (puzzleSolved && hallOfTorchesKeyUnlocked == 0)
                    {
                        Console.Clear();
                        Console.Write("You try the ");
                        KWStart();
                        Console.Write("heavy key ");
                        KWStop();
                        Console.Write("you found in the Hall of Torches.\nWith a gentle click the door is unlocked. You step inside\n" +
                                      "to find another stairwell. You ascend.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        hallOfTorchesKeyUnlocked = 1;
                        EastWingLanding();
                    }
                    else if (!puzzleSolved)
                    {
                        Console.Clear();
                        Console.Write("The door is locked. Perhaps there's a ");
                        KWStart();
                        Console.Write("key ");
                        KWStop();
                        Console.Write("somewhere.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (hallOfTorchesKeyUnlocked == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("You ascend the stairwell.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        EastWingLanding();
                    }
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You leave through the south archway.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    SouthWing3WayRoom();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("You take a look around, the debris is blocking access to most of the room.\n" +
                                      "The east side of the wall has crumbled in a few places.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
            }
        }
        static void EastWingLanding()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You enter a surprisingly well kept room. There are lit sconces along the walls,\n" +
                                  "there's even furniture here. A large wooden table surrounded by chairs in the middle of the room.\n" +
                                  "You see a rather impressive fireplace to the west.\n" +
                                  "A gentle breeze flows into the room from the east. You have a door to the north and a stairwell to the south.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("Inspecting the fireplace, it's made of stone with some metal decorations in intricate patterns.\n" +
                                      "Must've cost a fortune, it does feel a bit out of place. You see nothing else of value.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("You open the door.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    NorthStairwell();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You descend the stairs.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    EastStairwell();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("You step out on a balcony.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    EastWingBalcony();
                }
            }
        }
        static void EastWingBalcony()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You arrive on the balcony through the west door. The fresh air fill your lungs as you stand there,\nleaning against the railing for a while.\n" +
                                  "Looking around this small space, you don't see much of value. Perhaps it's worth a closer look either way.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You decide to return into the fort again.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    EastWingLanding();
                }
                if (move == "NORTH" || move == "N")
                {
                    if (EWBhealthPotion == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("You let your eyes wander for a bit, you spot something on the ground.\n");
                        Console.Write("There's a ");
                        KWStart();
                        Console.Write("glass bottle ");
                        KWStop();
                        Console.Write("with a red liquid inside.\nYou pocket it.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        EWBhealthPotion--;
                        player.backpack.backPack.Add(Item.HPpotion);
                    }
                    else if (EWBhealthPotion == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You take another careful look around, in case of other items scattered around.\n" +
                                          "There is nothing else of value.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You realise you're much higher up than you thought. It's a long way down, to a watery death.\n" +
                                      "You take a step back.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "EAST" || move == "E")
                {
                    if (magicTrinket == false)
                    {
                        Console.Clear();
                        Console.WriteLine("You gaze out over the water, it's quiet. Too quiet. No birds, no fish - only the soft whispers of the wind.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (magicTrinket == true)
                    {
                        trinketActivated = true;
                        Console.Clear();
                        Console.WriteLine("You see the reflections of the night sky in the water. The full moon is accompanied by a handful of stars.\n" +
                                          "You take the rose necklace out from your pouch and lift it to your eye.\n" +
                                          "As the moonlight hits the opal, it starts to glow slightly.\n\n" +
                                          "You stand there in a daze, appreciating the beauty of this moment for a while.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You gaze out over the water, it's calm and silent. only the soft whispers of the wind can be heard.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
        static void NorthStairwell()
        {
            while (true)
            {
                if (northstairwellskeleton)
                {
                    Console.Clear();
                    Console.WriteLine("Before even taking a step into the room, you can already hear the clattering of bones.\n" +
                                      "A skeleton warrior clad in leather armour, wielding a spear lunges at you.\n\n" +
                                      "Prepare for battle!");
                    CombatSystem.Combat(player, new Enemy(EnemyType.Skeleton));
                    northstairwellskeleton = false;
                }
                else if (!northstairwellskeleton)
                {
                    Console.Clear();
                    Console.WriteLine("Another room that has been well kept. There are large glass windows along the east and north walls.\n" +
                                      "Two wooden benches are placed next to the glass windows.\n" +
                                      "The remains of the skeleton warrior lies in a pile of bones.\n" +
                                      "A red carpet leads from the south entrance and to the west stairwell.");
                    controls();
                    if (move == "WEST" || move == "W")
                    {
                        Console.Clear();
                        Console.WriteLine("You descend the stairwell.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        NorthWingLanding();
                    }
                    else if (move == "NORTH" || move == "N")
                    {
                        Console.Clear();
                        Console.WriteLine("You decide to sit down on a bench and look out the window for a bit.\n" +
                                          "Feels good to rest your legs for a little while.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    else if (move == "SOUTH" || move == "S")
                    {
                        Console.Clear();
                        Console.WriteLine("You leave for the south door.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        EastWingLanding();
                    }
                    else if (move == "EAST" || move == "E")
                    {
                        Console.Clear();
                        Console.WriteLine("You look out the window, water as far as the eye can see.\n" +
                                          "A sudden feeling of loneliness hits you for a bit. You shake it off.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
            }
        }
        static void NorthWingLanding()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You stand in a small corridor. The red carpet leads straight through the room,\n" +
                                  "between the door to the west and the stairwell to the east. There are large glass windows on both sides.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("The door creaks open.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    ExtravagantRoom();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("You're impressed by the large glass windows. No ordinary people could afford these.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    if (NWLhealthPotion == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("It's a small miracle these large glass windows are still intact - you think to yourself.\n");
                        Console.Write("There's a ");
                        KWStart();
                        Console.Write("glass bottle ");
                        KWStop();
                        Console.Write("with a red liquid inside, resting on the windowsill.\nYou pocket it.\n");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        NWLhealthPotion = 0;
                        player.backpack.backPack.Add(Item.HPpotion);
                    }
                    else if (NWLhealthPotion == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You take another careful look around, in case of other items scattered around.\n" +
                                          "There is nothing else of value.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("You ascend the stairwell.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    NorthStairwell();
                }
            }
        }
        public static void ExtravagantRoom()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You set foot in what can only be described as a rather extravagant area." +
                                  "\nThe sconces lighting up the room are made of polished steel.\n" +
                                  "There are paintings on the walls, the red carpet splits in the middle of the room, \n" +
                                  "leading to doors to the south, west and east.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    while (decide != "YES" || decide != "Y" || decide != "NO" || decide != "N")
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("This is the point of no return.\n");
                        KWStop();
                        Console.WriteLine($"If you want to keep exploring, I suggest waiting before you go here.\n" +
                                          $"Do you wish to enter, {player.name}?");
                        Console.Write("[Y]ES/[N]O:> ");
                        decide = Console.ReadLine().ToUpper();

                        if ((decide == "YES" && !puzzleSolved) || (decide == "Y" && !puzzleSolved))
                        {
                            Console.Clear();
                            Console.Write("The door is locked, perhaps there's a ");
                            KWStart();
                            Console.Write("key");
                            KWStop();
                            Console.Write(" somewhere.\n");
                            Console.WriteLine("Press Enter to continue.");
                            Console.ReadLine();
                            ExtravagantRoom();
                        }
                        else if (decide == "NO" || decide == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("You decide to keep exploring.");
                            Console.WriteLine("Press Enter to continue.");
                            Console.ReadLine();
                            ExtravagantRoom();
                        }
                        else if ((decide == "YES" && puzzleSolved) || (decide == "Y" && puzzleSolved))
                        {
                            Console.Clear();
                            Console.Write("You try the ");
                            KWStart();
                            Console.Write("ornate key ");
                            KWStop();
                            Console.Write("you found in the Treasury.\nWith a gentle click the door is unlocked. You step inside.\n");
                            Console.WriteLine("Press Enter to continue.");
                            Console.ReadLine();
                            ThroneRoom();
                        }
                    }
                }
                else if (move == "NORTH" || move == "N")
                {
                    if (secretEventWatched == true)
                    {
                        Console.Clear();
                        Console.WriteLine("The paintings are now blank.");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                    }
                    else if (secretEventWatched == false)
                    {
                        Console.Clear();
                        Console.WriteLine("There are paintings of what you assume were the nobles that once lived in this fort.\n" +
                                          "A tall monocled man with no hair except for a rather impressive, twirly mustache.\n" +
                                          "He's dressed in a fancy suit with a purple inlay accompanied by a purple tie.\n\n" +
                                          "The painting next to him must have been his wife. A beautiful red haired lady,\n" +
                                          "wearing a long white dress adorned with red roses. Her eyes almost seem to follow you.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    if (magicTrinket == true && trinketActivated == true)
                    {
                        Console.Clear();
                        Console.Write("Suddenly, the ");
                        KWStart();
                        Console.Write("rose necklace");
                        KWStop();
                        Console.Write(" hums to life and escapes your pouch.\n");
                        Console.WriteLine("It floats towards the paintings as the eyes of the lady follow its movement.");
                        Console.WriteLine("Press Enter to continue.");
                        Console.ReadLine();
                        NecklaceEvent.EventStart();
                    }
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("You step out on a large, broken stone bridge.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    NorthBrokenBridge();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("You leave through the east door.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    NorthWingLanding();
                }
            }
        }
        static void NorthBrokenBridge()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You stand on what once was a rather impressive stone bridge. Heavy winds hit you from the west.\n" +
                                  "The middle part of the bridge, to the south, has fallen apart and you see no way of getting to the other side.");
                controls();
                if (move == "WEST" || move == "W")
                {
                    Console.Clear();
                    Console.WriteLine("You face the heavy wind, the pressure makes it hard to breathe. There is nothing of value.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "NORTH" || move == "N")
                {
                    Console.Clear();
                    Console.WriteLine("You decide to return to the gaudy room.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    ExtravagantRoom();
                }
                else if (move == "SOUTH" || move == "S")
                {
                    Console.Clear();
                    Console.WriteLine("Taking a quick look at the fallen bridge, you decide it's not worth risking your life trying to find a way over.\n" +
                                      "You spot something on the other side of the bridge. It resembles a human, sitting next to one of the walls.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
                else if (move == "EAST" || move == "E")
                {
                    Console.Clear();
                    Console.WriteLine("The dark towering stone walls of the fort fills you with an ominous feeling.");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                }
            }
        }
        static void ThroneRoom()
        {
            while (true)
            {
                if (throneroomlich)
                {
                    Console.Clear();
                    Console.WriteLine("As you step into the throne room, you suddenly feel the air getting significantly heavier,\n" +
                                      "you struggle to breathe. Looking straight ahead you notice a robed figure sitting on the throne.\n" +
                                      "It lifts its head, and as the hood falls off, you realise this is another skeleton.\n" +
                                      "But something is very different to the previous undead you've fought so far.\n\n" +
                                      "This one grabs a gnarled staff that's been leaning on the side of the throne, and stands up.\n" +
                                      "You're filled with doubt as alien voices whisper inside your head.\n\n" +
                                      "This will not be easy..");
                    Console.WriteLine("Prepare for battle!");
                    CombatSystem.Combat(player, new Enemy(EnemyType.Lich));
                    throneroomlich = false;
                }
                else if (!throneroomlich)
                {
                    Console.Clear();
                    Console.WriteLine("As you land the killing blow on the grim lich, the oppressive feeling vanishes from the fort.\n" +
                                      "The one summoning and controlling the undead has been defeated!\n\n" +
                                      "After you've spent some well deserved time of celebratory fist pumping and a silly dance,\n" +
                                      "you take a look around the throne room.\n\n" +
                                      "A wide grin spreads over your face as you uncover a large stash of gold coins!\n" +
                                      "It was all worth it in the end - you think to yourself, as you fill your pouch full of gold.\n\n");
                    Console.WriteLine("Press Enter to continue.");
                    Console.ReadLine();
                    Console.WriteLine($"Thank you {player.name}, for playing my game!\n" +
                                      $"I had a lot of fun creating this small project.\n" +
                                      $"It's my very first game, and I have learned a lot!\n\n" +
                                      $"This is where the adventure draws to a close.\n\n");
                    KWStart();
                    Console.WriteLine(" _____ _   _  _____   _____ _   _______ _ ");
                    Console.WriteLine("|_   _| | | ||  ___| |  ___| \\ | |  _  \\ |");
                    Console.WriteLine("  | | | |_| || |__   | |__ |  \\| | | | | |");
                    Console.WriteLine("  | | |  _  ||  __|  |  __|| . ` | | | | |");
                    Console.WriteLine("  | | | | | || |___  | |___| |\\  | |/ /|_|");
                    Console.WriteLine("  \\_/ \\_| |_/\\____/  \\____/\\_| \\_/___/ (_)\n\n");
                    KWStop();
                    if (secretEventWatched == false){
                        Console.WriteLine("By the way, you might've missed a secret..");
                        Console.WriteLine("Press Enter to return to the main menu.");
                        Console.ReadLine();
                        menu();
                    }
                    else if (secretEventWatched == true)
                    {
                        Console.WriteLine("Press Enter to return to the main menu.");
                        Console.ReadLine();
                        menu();
                    }
                }
            }
        }
    }
}