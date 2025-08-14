# DnD Battler

## Description
DnD Battler is a **simple console-based battle simulator** for two teams of 3 characters each.  
Players can choose Fighters, Wizards, or Clerics, and the battle is simulated automatically until one team is defeated.

---

## How to Run
1. Clone the repository:  

   ``` git clone <repo-url> ```
2. Navigate to the project folder:

    ``` cd DnDBattler ```
3. Run the console app:

    ``` dotnet run  ```
4. Follow the prompts to:
    - Enter team names
    - Select 3 characters per team (Fighter/Wizard/Cleric)
    - Watch the battle simulation in the console

## Gameplay Rules 
Each team has 3 characters.

Character types:
- Fighter: +5 bonus health
- Wizard: Double attack, loses 1 health when attacking
- Cleric: Heals 1 health whenever they attack

The battle alternates turns:
- All living members of Team A attack random living members of Team B
- All living members of Team B attack random living members of Team A
- Repeat until one team has no living members

Characters with 0 HP are displayed as DEAD

## Assumptions
- The battle order is automatic; users do not select attack targets.
- Input validation ensures only Fighter, Wizard, or Cleric can be chosen.
- Health and attack values are randomly generated (1–10) on character creation.
- Dead characters are displayed as "DEAD" in the console.