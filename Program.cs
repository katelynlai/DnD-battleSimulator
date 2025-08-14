﻿using System;
using DnDBattler.Models;
using DnDBattler.Services;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the DnD Battler!");

        //create Team 1
        var team1 = CreateTeam(1);

        //create Team 2
        var team2 = CreateTeam(2);

        //start battle
        var battle = new Battle(team1, team2);
        battle.Simulate();
    }

    //create a team with 3 characters
    static Team CreateTeam(int teamNumber)
    {
        string teamName;

        //validate team name
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

            //check for valid character type
            while (true)
            {
                Console.WriteLine($"Choose character {i} for {teamName} (Fighter/Wizard/Cleric):");
                choice = Console.ReadLine().Trim().ToLower();

                if (choice == "fighter" || choice == "wizard" || choice == "cleric")
                    break; //valid input, exit loop

                Console.WriteLine("Invalid choice. Please enter Fighter, Wizard, or Cleric.");
            }

            string charName;

            //validate character name
            while (true)
            {
                Console.Write($"Enter name for this {choice}: ");
                charName = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(charName))
                    break;

                Console.WriteLine("Character name cannot be empty. Please enter a valid name.");
            }

            //create character based on validated choice
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
