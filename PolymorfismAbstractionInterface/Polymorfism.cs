using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal // Basklass
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Djuret låter.");
        }
    }

    public class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Grisen säger nöff nöff");
        }
    }

    class Dog : Animal
    {
        //public override void AnimalSound()
        //{
        //    Console.WriteLine("Hunden säger vov vov");
        //}
    }

}
