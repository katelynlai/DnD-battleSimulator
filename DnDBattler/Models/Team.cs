using System;
using System.Collections.Generic;
using System.Linq;

namespace DnDBattler.Models
{
    //represents a team of characters
    public class Team
    {
        public string TeamName { get; set; } //gets name of the team
        public List<Character> Members { get; set; } = new List<Character>();
        private static Random rand = new Random();

        public Team(string name)
        {
            TeamName = name;
        }

        //check if team still has living members
        public bool HasLivingMembers() => Members.Any(m => m.IsAlive);

        //get a random alive member (used as attack target)
        public Character GetRandomAliveMember()
        {
            var aliveMembers = Members.Where(m => m.IsAlive).ToList();
            if (aliveMembers.Count == 0) return null;
            return aliveMembers[rand.Next(aliveMembers.Count)]; //picks random index in aliveMembers list 
        }
    }
}
