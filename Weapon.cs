using System.Security.Cryptography.X509Certificates;

namespace Classes;


public class Weapon
{
    public string Name { get; }
    public float Durability { get; }


    public Weapon(string name, int minDamage, int maxDamage,): this (name)
    {
        SetDamageParams(minDamage, maxDamage);
    }

    public Weapon(string name)
    {
        Name = name;
    }

    public void SetDamageParams(int minDamage, int maxDamage)
    {
        if (minDamage > maxDamage)
        {
            (minDamage, maxDamage) = (maxDamage, minDamage);
            Console.WriteLine("Некорректные входные данные \"{Name}\"");
        }

        if (minDamage < 1f)
        {
            minDamage = 1;
            Console.WriteLine("форсированной установки минимального значения");
        }

        if (maxDamage <= 1)
        {
            maxDamage = 10;
        }

    }

    public int GetDamage()
    {
        return (MinDamage + MaxDamage) / 2;
    }
}
