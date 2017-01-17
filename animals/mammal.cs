using System;

namespace Zoolandia
{
    public class Mammal : Animal
    {
        public bool HasLegs { get(){
            if (HasLegs)
            {
                return "does";
            }
            else 
            {
                return "doesn't";
            }
        }; set; }
    }
}