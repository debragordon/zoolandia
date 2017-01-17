using System;

namespace Zoolandia.animals
{
    public class Bird : Animal
    {
        public string CanFly { get 
        {
            return "can";
        } }
        public override void sleep ()
        {
            Console.WriteLine("I never sleep");
        }
        public Bird (string Sound)
        {
            this.Sound = Sound;
        }

    }
}