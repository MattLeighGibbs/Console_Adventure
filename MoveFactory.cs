namespace ConsoleAdventure
{
    public class MoveFactory
    {
        public static void ProcessMove(ICombatableBeing attacker, ICombatableBeing victim)
        {
            int hitAmount = attacker.Attack() - victim.Block();
            victim.HP -= hitAmount;
            AttackBroadcast.Broadcast(attacker, victim, hitAmount);
        }
    }
}