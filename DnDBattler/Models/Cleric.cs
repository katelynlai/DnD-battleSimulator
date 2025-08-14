using System;

namespace DnDBattler.Models
{
    // Cleric: heals 1 health every time they attack
    public class Cleric : Character
    {
        public Cleric(string name) : base(name) { }

        public override void AttackTarget(Character target)
        {
            base.AttackTarget(target); 
            Health += 1; // Heal after attacking
            Console.WriteLine($"{Name} heals 1 health after attacking!");
        }
    }
}
