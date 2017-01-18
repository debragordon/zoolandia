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
            Console.WriteLine($"I have an animal that is a/an {Fido.Name} that is a {Fido.Type}. It is {Fido.Color} in color and it {Fido.HasLegs} swim. Fido are {Fido.Power} in power."); 

            var Garfield = new Canine();
            Garfield.Name = "Della";
            Console.WriteLine($"I have an animal that is a/an {Garfield.Name} that is a {Garfield.Type}. It is {Garfield.Color} in color and it {Garfield.HasLegs} swim. Garfield are {Garfield.Power} in power."); 

            var Dogfish = new Squalidae();
            Dogfish.Name = "Puppy";
            Dogfish.Venom = "on the dorsal";
            Console.WriteLine($"I have an animal that is a/an {Dogfish.Name} that is a {Dogfish.Type}. It is {Dogfish.Color} in color and it {Dogfish.CanSwim} swim. Dogfish are {Dogfish.Power} in power. Dogfish are the only species that are poisonous {Dogfish.Venom} fin."); 
            
            var Ray = new Rajidae();
            Ray.Name = "Puppy";
            Ray.Tail = "has spikes";
            Console.WriteLine($"I have an animal that is a/an {Ray.Name} that is a {Ray.Type}. It is {Ray.Color} in color and it {Ray.CanSwim} swim. Ray are {Ray.Power} in power. Ray have a tail that {Ray.Tail}."); 
        }
    }
}
