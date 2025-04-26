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