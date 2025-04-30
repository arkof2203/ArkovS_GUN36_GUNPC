using System.Security.Cryptography.X509Certificates;

namespace Classes;


public class Weapon
{
    public string Name { get; }
    public float Durability { get; }
    public Interval DamageInterval { get; private set; }


    public Weapon(string name, int minDamage, int maxDamage,): this (name)
    {
        SetDamageParams(minDamage, maxDamage);
    }

    public Weapon(string name)
    {
        Name = name;
        Durability = 100f;
        DamageInterval = new Interval(minDamage, maxDamage);
    }

    public void SetDamageParams(int minDamage, int maxDamage)
    {
        DamageInterval = new Interval(minDamage, maxDamage);
    }

    public int GetDamage()
    {
        return DamageInterval.Get();
    }

    public override string ToString()
    {
        return $"{Name} (Damage: [{DamageInterval.Min}, {DamageInterval.Max}])";
    }
}
