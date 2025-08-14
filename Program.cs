﻿using System;
using DnDBattler.Models;
using DnDBattler.Services;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the DnD Battler!");

        bool playAgain = true;

        while (playAgain)
        {
            // Create Team 1
            var team1 = CreateTeam(1);

            // Create Team 2
            var team2 = CreateTeam(2);

            // Start battle
            var battle = new Battle(team1, team2);
            battle.Simulate();

            // Replay option
            Console.WriteLine("\nDo you want to play again? (Y/N):");
            string replayChoice = Console.ReadLine()?.Trim().ToLower();
            playAgain = replayChoice == "y" || replayChoice == "yes";
        }

        Console.WriteLine("\nThanks for playing DnD Battler!");
    }

    // Create a team with 3 characters
    static Team CreateTeam(int teamNumber)
    {
        string teamName;

        // Validate team name
        while (true)
        {
            Console.Write($"\nEnter name for Team {teamNumber}: ");
            teamName = Console.ReadLine()?.Trim();

            if (!string.IsNullOrEmpty(teamName))
                break;

            Console.WriteLine("Team name cannot be empty. Please enter a valid name.");
        }

        var team = new Team(teamName);

        for (int i = 1; i <= 3; i++)
        {
            string choice = "";

            // Check for valid character type
            while (true)
            {
                Console.WriteLine($"Choose character {i} for {teamName} (Fighter[F]/Wizard[W]/Cleric[C]):");
                choice = Console.ReadLine().Trim().ToLower();

                // Allow both full names and shortcuts
                if (choice == "fighter" || choice == "f")
                {
                    choice = "fighter";
                    break;
                }
                else if (choice == "wizard" || choice == "w")
                {
                    choice = "wizard";
                    break;
                }
                else if (choice == "cleric" || choice == "c")
                {
                    choice = "cleric";
                    break;
                }

                Console.WriteLine("Invalid choice. Please enter Fighter (F), Wizard (W), or Cleric (C).");
            }

            string charName;

            // Validate character name
            while (true)
            {
                Console.Write($"Enter name for this {choice}: ");
                charName = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(charName))
                    break;

                Console.WriteLine("Character name cannot be empty. Please enter a valid name.");
            }

            // Create character based on validated choice
            switch (choice)
            {
                case "fighter":
                    team.Members.Add(new Fighter(charName));
                    break;
                case "wizard":
                    team.Members.Add(new Wizard(charName));
                    break;
                case "cleric":
                    team.Members.Add(new Cleric(charName));
                    break;
            }
        }

        return team;
    }
}
