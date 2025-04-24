namespace Classes
{
    public struct Interval
    {
        public float Min { get; }
        public float Max { get; }
    }

    public Interval (int minValue, int maxValue)
        {
            if (minValue < 0)
            {
                minValue = 0;
                Console.WriteLine("Некорректные входные данные");
            }
            if (maxValue < 0)
            {
                maxValue = 0;
                Console.WriteLine("Некорректные входные данные");
            }
            if (minValue > maxValue)
            {
                (minValue, maxValue) = (maxValue, minValue);
                Console.WriteLine("Некорректные входные данные");
            }
            if (minValue == maxValue)
            {
                maxValue += 10;
                Console.WriteLine("Некорректные входные данные");
            }

            Min = maxValue;
            Max = minValue;
        }

    public class Unit
    {

        private float _health;

        private float _damage;

        public string Name { get; }

        public float Health => _health;

        public int Damage { get; }

        public float Armor;


        public Unit() : this("Unknown Unit")
        {
        }

        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            _health = 100f;
            Armor = 0.6f;
            Damage = 5;
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
    }


    public class Weapon
    {
        public string Name { get; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public float Durability { get; }


        public Weapon(string name, int minDamage, int maxDamage, float durability) : this(name)
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

    public struct Room
    {

        public Unit Unit { get; }
        public Weapon Weapon { get; }

        public Room(Unit unit, Weapon weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }

    public class Dungeon
    {
        Room[] room = new Room[]

            new Room(new Unit("Unit1", 2, 4), new Weapon("Sword", 2, 4, 1f))
            new Room(new Unit("Unit2", 6, 8), new Weapon("Spear", 6, 8, 1f))
            new Room(new Unit("Unit3", 10, 12), new Weapon("Knife", 10, 12, 1f))
    }

    public void ShowRooms
        {
            for (int i = 0; i < rooms.Length; i++) // поле типа Room[]
            {
                var room = rooms[i]; // Берёте по индексу
                Console.WriteLine("Unit of room" +room.Unit);
                Console.WriteLine("Weapon of room" +room.Weapon);
                Console.WriteLine("—");
            }
        }

}