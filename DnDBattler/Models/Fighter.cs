namespace DnDBattler.Models
{
    //fighter: gets +5 health at creation
    public class Fighter : Character
    {
        public Fighter(string name) : base(name)
        {
            Health += 5; //bonus health
        }
    }
}
