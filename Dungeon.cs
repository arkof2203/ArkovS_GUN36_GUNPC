namespace Classes
{
    
    public class Dungeon
    {
        Room[] room = new Room[]

            new Room(new Unit("Unit1", new interval (2, 4)), new Weapon("Sword", 2, 4, 1f))
            new Room(new Unit("Unit2", new interval (6, 8)), new Weapon("Spear", 6, 8, 1f))
            new Room(new Unit("Unit3", new interval (10, 12)), new Weapon("Knife", 10, 12, 1f))
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