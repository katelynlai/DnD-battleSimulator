using System;

namespace DnDBattler.Models
{
    //base class for all character types
    public abstract class Character
    {
        public string Name { get; set; }
        public int Health { get; set; } //current health points
        public int Attack { get; set; }
        public bool IsAlive => Health > 0; //true if still alive

        protected static Random rand = new Random(); //shared random generator

        public Character(string name)
        {
            Name = name;
            Health = rand.Next(1, 11); //1 to 10
            Attack = rand.Next(1, 11); //1 to 10
        }

        //method for attacking another character
        public virtual void AttackTarget(Character target)
        {
            if (!IsAlive) return; //dead characters cannot attack

            target.Health -= Attack;
            if (target.Health < 0) target.Health = 0; //no negative health

            Console.WriteLine($"{Name} attacks {target.Name} for {Attack} damage!");
        }
    }
}
