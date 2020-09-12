using ConsoleAdventure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;

namespace ConsoleAdventure
{

    class Enums
    {
        enum TypeMovement
        {
            NORTH,
            SOUTH,
            WEST,
            EAST
        }
    }
    class Room
    {
        public Room North { get; set; } = null;
        public Room South { get; set; } = null;
        public Room West { get; set; } = null;
        public Room East { get; set; } = null;
        public List<Room> AllRooms { get; set; }
        public string Description { get; set; } = "";
    }
    class Movement
    {
        public static void Query(Room room)
        {
            room.AllRooms.ForEach(a => Console.WriteLine(a.Description));
        }
    }
    public class JSONRoomReader
    {
        public JSONRoomReader()
        {

            using (StreamReader file = File.OpenText("..\\..\\..\\json1.json"))
            {
                List<Room> output = JsonConvert.DeserializeObject<List<Room>>(file);
                var stuff = 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            JSONRoomReader roomReader = new JSONRoomReader();
        }
    }
}