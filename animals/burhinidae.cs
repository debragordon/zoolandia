namespace Zoolandia.animals
{
    public class Burhinidae : Bird
    {
        public string Nocturnal { get; set; }

        public Burhinidae () : base("wail")
        {
        }
        public Burhinidae (string sound) : base(sound)
        {
        }
    }    
}