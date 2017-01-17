using System;

namespace Zoolandia
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; } 
        public string Eat()
        {
            return "Yum!";
        }
    }
}