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

## Battle Simulation Details
1. Turn Order
    - Teams alternate turns automatically.
    - Each living member of the active team attacks a random living member of the opposing team.

2. Character Behavior
    - Fighters deal damage equal to their attack.
    - Wizards deal double damage but lose 1 health per attack.
    - Clerics deal damage and heal themselves for 1 HP when attacking.

3. Battle Outcome
    - The battle ends when all members of one team are dead.
    - If all characters from both teams die simultaneously, the battle is declared a draw.
    - After each turn, the health status of all characters is displayed.

## Assumptions
- The battle order is automatic; users do not select attack targets.
- Clerics can exceed their starting health due to self-healing.
- Health and attack values are randomly generated (1–10) on character creation.
- Dead characters cannot attack.
