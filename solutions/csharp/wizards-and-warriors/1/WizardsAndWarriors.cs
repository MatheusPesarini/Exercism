abstract class Character
{
    protected string _characterType;

    protected Character(string characterType)
    {
        _characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {_characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable() == true)
        {
            return 10;
        }

        return 6;
    }
}

class Wizard : Character
{
    protected bool _PreparingSpell;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (_PreparingSpell)
        {
            return 12;
        }

        return 3;
    }

    public override bool Vulnerable()
    {
        if (!_PreparingSpell)
        {
            return true;
        }

        return false;
    }

    public void PrepareSpell()
    {
        _PreparingSpell = true;
    }
}
