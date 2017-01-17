using System;

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
            Lion.HasLegs = true;

            Console.WriteLine($"I have an animal that is a {Lion.Name} that is a {Lion.Type}. It is {Lion.Color} in color and it {Lion.HasLegs} have legs.");
        }
    }
}
