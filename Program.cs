using System;
using Zoolandia.animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's build a zoo");

            var Lion = new Mammal();
            Lion.Name = "Lion";
            Lion.Type = "Cat";
            Lion.Color = "gold";

            Console.WriteLine($"I have an animal that is a/an {Lion.Name} that is a {Lion.Type}. It is {Lion.Color} in color and it {Lion.HasLegs} have legs.");

            var Flamingo = new Bird();
            Flamingo.Name = "Flamingo";
            Flamingo.Type = "Wading Bird";
            Flamingo.Color = "pink";

            Console.WriteLine($"I have an animal that is a/an {Flamingo.Name} that is a {Flamingo.Type}. It is {Flamingo.Color} in color and it {Flamingo.CanFly} fly.");

            var Salmon = new Fish();
            Salmon.Name = "Salmon";
            Salmon.Type = "River Swimmer";
            Salmon.Color = "rainbow";

            Console.WriteLine($"I have an animal that is a/an {Salmon.Name} that is a {Salmon.Type}. It is {Salmon.Color} in color and it {Salmon.CanSwim} fly."); 

        }
    }
}
