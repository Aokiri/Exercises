// Link to the exercise: https://exercism.org/tracks/csharp/exercises/wizards-and-warriors

using System;

abstract class Character
{
    private readonly string _characterType;
    public bool vulnerability;
    protected Character(string characterType, bool vuln)
    {
        _characterType = characterType;
        vulnerability = vuln;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() =>
        false;

    public override string ToString() =>
        $"Character is a {_characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior", false)
    {
    }

    public override int DamagePoints(Character target) =>
        target.vulnerability ? 10 : 6;

    public override string ToString() =>
        base.ToString();

    public override bool Vulnerable() =>
        base.Vulnerable();
 
}

class Wizard : Character
{
    public Wizard() : base("Wizard", true)
    {
    }

    public override int DamagePoints(Character target) => 
        vulnerability ? 3 : 12;

    public void PrepareSpell() =>
        vulnerability = false;

    public override string ToString() =>
            base.ToString();

    public override bool Vulnerable() =>
        vulnerability;
}