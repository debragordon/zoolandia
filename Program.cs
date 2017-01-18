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
            Lion.sleep();
            Lion.SetColor("gold");
            Console.WriteLine($"I have an animal that is a/an {Lion.Name} that is a {Lion.Type}. It is {Lion.Color} in color and it {Lion.HasLegs} have legs. Lions sound like this: {Lion.Sound}. Lions are {Lion.Power}.");

            var Blackbird = new Bird("cawcaw");
            Blackbird.Name = "Blackbird";
            Blackbird.Type = "mysterious bird";
            Blackbird.sleep();
            Blackbird.SetPower("weak");
            Console.WriteLine($"I have an animal that is a/an {Blackbird.Name} that is a {Blackbird.Type}. It is {Blackbird.Color} in color and it {Blackbird.CanFly} fly. Birds sound like this: {Blackbird.Sound}. Blackbirds are {Blackbird.Power}.");

            var Salmon = new Fish();
            Salmon.Name = "Salmon";
            Salmon.Type = "River Swimmer";
            Salmon.SetColor("rainbow");
            Salmon.sleep();
            Salmon.SetPower("so so");
            Console.WriteLine($"I have an animal that is a/an {Salmon.Name} that is a {Salmon.Type}. It is {Salmon.Color} in color and it {Salmon.CanSwim} swim. Salmon are {Salmon.Power} in power."); 

            var Horse = new Mammal("nhayyyyy");
            Horse.Name = "Horse";
            Horse.Type = "Equine";
            Horse.sleep();
            Horse.SetColor("paint");
            Console.WriteLine($"I have an animal that is a/an {Horse.Name} that is a {Horse.Type}. It is {Horse.Color} in color and it {Horse.HasLegs} have legs. Horses sound like this: {Horse.Sound}. Horses are {Horse.Power}.");

            var Hummingbird = new Bird("hmmmmmmmm");
            Hummingbird.Name = "Hummingbird";
            Hummingbird.Type = "Bird";
            Hummingbird.sleep();
            Hummingbird.SetPower("weak");
            Console.WriteLine($"I have an animal that is a/an {Hummingbird.Name} that is a {Hummingbird.Type}. It is {Hummingbird.Color} in color and it {Hummingbird.CanFly} fly. Birds sound like this: {Hummingbird.Sound}. Hummingbirds are {Hummingbird.Power}.");

            var Catfish = new Fish();
            Catfish.Name = "Catfish";
            Catfish.Type = "River Swimmer";
            Catfish.SetColor("blue");
            Catfish.sleep();
            Catfish.SetPower("weak");
            Console.WriteLine($"I have an animal that is a/an {Catfish.Name} that is a {Catfish.Type}. It is {Catfish.Color} in color and it {Catfish.CanSwim} swim. Catfish are {Catfish.Power} in power."); 

        }
    }
}
