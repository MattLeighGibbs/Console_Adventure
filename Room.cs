using System;
using System.Collections.Generic;
using System.Linq;
using static ConsoleAdventure.Enums;

namespace ConsoleAdventure
{
    public class Room
    {
        private const int MAX = 999;

        public int North { get; set; } = MAX;
        public int South { get; set; } = MAX;
        public int West { get; set; } = MAX;
        public int East { get; set; } = MAX;
        public int ID { get; set; } = MAX;
        public List<int> Neighbors { get; set; } = new List<int>();
        public string Description { get; set; } = "";

        public void Query(List<Room> rooms)
        {
            Neighbors.ForEach(a => rooms.Where(b => b.ID == a).ToList().ForEach(a => a.Print()));
        }
        public void AddRoom(List<Room> rooms, Room room, TypeMovement typeMovement )
        {
            List<int> ids = new List<int>();
            rooms.ForEach(a => ids.Add(a.ID));
            if (ids.Contains(room.ID))
            {
                Neighbors.Add(1);
            }
        }
        public void Print()
        {
            Console.WriteLine(Description);
        }

    }
}