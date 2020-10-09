namespace ConsoleAdventure
{
    public class Player : BeingBaseModel, ICombatableBeing
    {
        public int MaxHP { get; set; } 
        public int HP { get; set; }
        public int MaxMP { get; set; }
        public int MP { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }

        public int Attack()
        {
            return Atk / D20.Roll();
        }

        public int Block()
        {
            return Def / D20.Roll();
        }
    }
}