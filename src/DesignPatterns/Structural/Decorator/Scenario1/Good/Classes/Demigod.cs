using DesignPatterns.Structural.Decorator.Scenario1.Good.Interfaces;

namespace DesignPatterns.Structural.Decorator.Scenario1.Good.Classes;

public class Demigod : IGod, IHuman
{
    private God _god = new();
    private Human _human = new();

    int IHuman.Power { get; set; }
    int IGod.Power { get; set; }

    public void LightningStrike() => _god.LightningStrike();

    public void Punch() => _human.Punch();
}
