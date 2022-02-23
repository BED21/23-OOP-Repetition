using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard
{
    public class Animal // Basklass
    {
        public void AnimalSound()
        {
            Console.WriteLine("Djuret låter.");
        }
    }

    class Pig : Animal  // Barnklass
    {
        public void AnimalSound()
        {
            Console.WriteLine("Grisen säger nöff nöff");
        }
    }

    class Dog : Animal
    {
        public new void AnimalSound()
        {
            Console.WriteLine("Hunden säger vov vov");
        }
    }
}
