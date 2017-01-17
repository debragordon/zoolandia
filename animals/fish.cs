using System;

namespace Zoolandia.animals
{
    public class Fish : Animal
    {
        public string CanSwim { get 
        {
            return "can";
        } }    
        public override void sleep ()
        {
            Console.WriteLine("Sleep is overrated");
        }

        public Fish ()
        {           
        }
        public Fish (string Sound)
        {
            this.Sound = Sound;
        }
    }    
}