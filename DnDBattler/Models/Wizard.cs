using System;

namespace DnDBattler.Models
{
    //wizard: double attack value, but lose 1 health every attack
    public class Wizard : Character
    {
        public Wizard(string name) : base(name)
        {
            Attack *= 2; 
        }

        public override void AttackTarget(Character target)
        {
            base.AttackTarget(target); 
            Health -= 1; 
            if (Health < 0) Health = 0; //no negative health

            Console.WriteLine($"{Name} loses 1 health from casting magic!");
        }
    }
}
