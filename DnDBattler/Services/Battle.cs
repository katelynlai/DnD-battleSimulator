using System;
using DnDBattler.Models;

namespace DnDBattler.Services
{
    //handles the battle simulation between two teams
    public class Battle
    {
        private Team team1;
        private Team team2;

        public Battle(Team t1, Team t2)
        {
            team1 = t1;
            team2 = t2;
        }

        //runs the battle until one team is fully defeated
        public void Simulate()
        {
            Console.WriteLine("\n--- Battle Start! ---");

            //loop until one team has no living members
            while (team1.HasLivingMembers() && team2.HasLivingMembers())
            {
                TakeTurn(team1, team2); //team 1 attacks
                if (!team2.HasLivingMembers()) break; //stop if team 2 is dead

                TakeTurn(team2, team1); //team 2 attacks
            }

            Console.WriteLine("\n--- Battle Over! ---");
            if (team1.HasLivingMembers())
                Console.WriteLine($"{team1.TeamName} wins!");
            else
                Console.WriteLine($"{team2.TeamName} wins!");
        }

        //executes one team's turn of attacks
        private void TakeTurn(Team attackingTeam, Team defendingTeam)
        {
            Console.WriteLine($"\n{attackingTeam.TeamName}'s turn!");
            foreach (var attacker in attackingTeam.Members)
            {
                if (!attacker.IsAlive) continue; //skip dead members
                var target = defendingTeam.GetRandomAliveMember();
                if (target != null)
                {
                    attacker.AttackTarget(target);
                }
            }
            //show health status after the turn
            PrintTeamStatus(attackingTeam);
            PrintTeamStatus(defendingTeam);
        }

        //prints current health of each team member
        private void PrintTeamStatus(Team team)
        {
            Console.WriteLine($"{team.TeamName} status:");
            foreach (var member in team.Members)
            {
                if (member.IsAlive)
                    Console.WriteLine($" - {member.Name}: {member.Health} HP");
                else
                    Console.WriteLine($" - {member.Name}: DEAD - 0 HP");
            }
        }
    }
}
