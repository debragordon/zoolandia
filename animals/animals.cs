using System;

namespace Zoolandia.animals {
    public class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }
        public string Power { get; set; }
        public void SetPower()
        {
            Power = "strong";
        }
        public void SetPower(string power)
        {
            Power = power;
        }
        public string Type { get; set; }
        public string Color { get; set; } 
        public void SetColor()
        {
            Color = "black";
        }
        public void SetColor(string color)
        {
            Color = color;
        }
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