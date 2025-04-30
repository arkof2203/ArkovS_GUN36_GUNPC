namespace Classes;


public class Unit
{

    private float _health;

    private float _damage;

    public string Name { get; }

    public float Health => _health;

    public Interval DamageInterval { get; private set; }

    public float Armor;


    public Unit() : this("Unknown Unit", new Interval(0, 10))
    {
    }

    public Unit(string name, Interval damage)
    {
        Name = name;
       _health = 100f;
        Armor = 0.6f;
        DamageInterval = damage
    }

    public Unit(string name, int minDamage, int maxDamage)
            : this(name, new Interval(minDamage, maxDamage))
    {
    }

    public float GetRealHealth()
    {
        return _health * (1f + Armor);
    }

    public bool SetDamage(float value)
    {
        _health -= value * Armor;
        return _health <= 0f;

    }

    public override string ToString()
    {
        return $"{Name} (Damage: [{DamageInterval.Min}, {DamageInterval.Max}])";
    }
}


