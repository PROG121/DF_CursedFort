using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using textAdventure;

namespace SecretEvent
{
    public class NecklaceEvent
    {
        public static void EventStart()
        {
            Console.Clear();
            Console.WriteLine("The necklace clasps around her neck. The painting turns dark, as a swirling vortex appears.\n" +
                              "It continuously grows until it is the size of a portal.\n" +
                              "Before you have a chance to react, it sucks you in.\n");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("As your vision return, you see the shape of a man and a woman standing close together on a balcony.\n" +
                              "You recognize them from the paintings.\n" +
                              "They seem ephemeral as they look into each others eyes.\n" +
                              "A tear falls from the man's face, as he gently embraces his wife.\n\n" +
                              "Moments later, he releases the embrace as they both slowly float away, upwards towards the full moon.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Everything fades to black. You open your eyes, and you're back in the room.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Program.secretEventWatched = true;
            Program.magicTrinket = false;
            Program.ExtravagantRoom();
        }
    }
}