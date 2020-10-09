using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAdventure
{
    public class AttackBroadcast : BroadcasterBase
    {
        public string Contents { get; set; }
        public static void Broadcast(ICombatableBeing attacker, ICombatableBeing victim, int damage)
        {
            if (damage <= 0)
            {
                Console.WriteLine("MISSED");
                return;
            }
            Console.WriteLine( $"{ attacker.Name } hits { victim.Name } for { damage }!" );
        }
    }
}
