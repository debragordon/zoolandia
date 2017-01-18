using System;

namespace Zoolandia.animals
{
    public class Macrosphenidae : Bird
    {
        public string Warble { get; set; }

        public Macrosphenidae () : base("warble")
        {
        }
        public Macrosphenidae (string sound) : base(sound)
        {
        }
    }    
}