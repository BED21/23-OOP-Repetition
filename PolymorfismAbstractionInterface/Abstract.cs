using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Animal
    {
        // Abstract metod (har ingen kropp)
        public abstract void AnimalSound();

        // Vanlig metod (har en kropp, alltså körbar kod)
        public void Sleep()
        {
            Console.WriteLine("Zzzzz...");
        }

        // Virtuell metod (har kropp, KAN skrivas över)
        public virtual void Dream()
        {
            Console.WriteLine("Djuret drömmer om mat...");
        }
    }

    // Barnklass
    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Grisen säger nöff nöff");
        }

        public override void Dream()
        {
            Console.WriteLine("Grisen drömmer om att springa i skogen");
        }
    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Hunden säger vov vov");
        }
    }
}
