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

            var Fido = new Canine();
            Fido.Name = "Della";
            Console.WriteLine($"I have an animal that is a/an {Fido.Name}."); 

            var Garfield = new Canine();
            Garfield.Name = "Garfield";
            Garfield.Type = "trouble maker";
            Garfield.Color = "striped";
            Console.WriteLine($"I have an animal that is a/an {Garfield.Name} that is a {Garfield.Type}. It is {Garfield.Color} in color."); 

            var Dogfish = new Squalidae();
            Dogfish.Name = "Puppy";
            Dogfish.Venom = "on the dorsal";
            Console.WriteLine($"I have an animal that is a/an {Dogfish.Name}. Dogfish are the only species that are poisonous {Dogfish.Venom} fin."); 
            
            var Ray = new Rajidae();
            Ray.Name = "Raymond";
            Ray.Tail = "has spikes";
            Console.WriteLine($"I have an animal that is a/an {Ray.Name}. Ray have a tail that {Ray.Tail}."); 
        }
    }
}
