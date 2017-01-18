namespace Zoolandia.animals
{
    public class Feline : Mammal
    {
        public string Claws { get; set; }
        public void SetClaws(string sharp)
        {
            Claws = sharp;
        }        
        public Feline () : base("bark")
        {
        }
        public Feline (string sound) : base(sound)
        {
        }
    }
}