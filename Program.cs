using System;
using Zoolandia.animals;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's build a zoo");

            var Lion = new Mammal("roar");
            Lion.Name = "Lion";
            Lion.Type = "Cat";
            Lion.Color = "gold";
            Lion.sleep();
            Console.WriteLine($"I have an animal that is a/an {Lion.Name} that is a {Lion.Type}. It is {Lion.Color} in color and it {Lion.HasLegs} have legs. Lions sound like this: {Lion.Sound}");

            var Blackbird = new Bird("cawcaw");
            Blackbird.Name = "Blackbird";
            Blackbird.Type = "mysterious bird";
            Blackbird.Color = "black";
            Blackbird.sleep();
            Console.WriteLine($"I have an animal that is a/an {Blackbird.Name} that is a {Blackbird.Type}. It is {Blackbird.Color} in color and it {Blackbird.CanFly} fly. Birds sound like this: {Blackbird.Sound}");

            var Salmon = new Fish();
            Salmon.Name = "Salmon";
            Salmon.Type = "River Swimmer";
            Salmon.Color = "rainbow";
            Salmon.sleep();
            Console.WriteLine($"I have an animal that is a/an {Salmon.Name} that is a {Salmon.Type}. It is {Salmon.Color} in color and it {Salmon.CanSwim} swim."); 

        }
    }
}
