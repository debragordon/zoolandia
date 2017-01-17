using System;

namespace Zoolandia.animals {
    public class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public string Type { get; set; }
        public string Color { get; set; } 
        public virtual void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
        public string Eat()
        {
            return "Yum!";
        }
    }
}