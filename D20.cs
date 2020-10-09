using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventure
{
    public class D20 
    {
        public static int Roll()
        {
            Random random = new Random();
            return random.Next(1, 20);
        }
    }
}
