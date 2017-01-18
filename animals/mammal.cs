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
        public int LegCount { get; set; }

        public override void sleep ()
        {
            Console.WriteLine("Hibernation time ...");
        }
        public Mammal (string sound)
        {
            this.Sound = sound;
        }
    }
}