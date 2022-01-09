namespace DesignPatterns.Structural.Flyweight;

public class Soldier
{
    public Soldier(string race, string specialization)
    {
        Race = race;
        Specialization = specialization;
    }

    public Soldier(string race, string specialization, int strength, int stamina)
        : this(race, specialization)
    {
        Strength = strength;
        Stamina = stamina;
    }

    public string Specialization { get; set; } // Swordsman, archer, etc.
    public string Race { get; set; } // Human, elf, orc, etc.

    public int Strength { get; set; }
    public int Stamina { get; set; }
}

public static class SoldierHelper
{
    public static string GetHash(this Soldier soldier) 
        => $"{soldier.Race}_{soldier.Specialization}";
}
