namespace Zoolandia.animals
{
    public class Canine : Mammal
    {
        public string Teeth  { get; set; }

        public Canine () : base("bark")
        {
        }
        public Canine (string sound) : base(sound)
        {
        }
    }
}