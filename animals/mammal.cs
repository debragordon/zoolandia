using System;

namespace Zoolandia.animals
{
    public class Mammal : Animal
    {
        public string HasLegs { get 
        {
            return "does";
        }
        }
        public override void sleep ()
        {
            Console.WriteLine("Hibernation time ...");
        }
        public Mammal (string Sound)
        {
            this.Sound = Sound;
        }
    }
}