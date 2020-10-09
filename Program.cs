using ConsoleAdventure;
using Newtonsoft.Json;
using System;
using System.Dynamic;
using System.IO;

namespace ConsoleAdventure
{

    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player()
            {
                Name = "Hulk Hogan",
                Atk = 8,
                HP = 20,
                Def = 10
            };
            Goblin goblin = new Goblin()
            {
                Name = "Danny Sexbang",
                Atk = 2,
                HP = 5,
                Def = 5
            };
            while (player.HP > 0 && goblin.HP > 0)
            {


                MoveFactory.ProcessMove(player, goblin);
                MoveFactory.ProcessMove(goblin, player);
           
                

            }
            if (player.HP < 1)
            {
                Console.WriteLine("Player is dead!");
            }
            if (goblin.HP < 1)
            {
                Console.WriteLine("Goblin is dead!");
                Console.Write("You Won!");
            }
        }
    }
}