namespace ConsoleAdventure
{
    public interface ICombatableBeing : IBeing
    {
        int MaxHP { get; set; }
        int HP { get; set; }
        int MaxMP { get; set; }
        int MP { get; set; }
        int Atk { get; set; }
        int Def { get; set; }
        int Attack();
        int Block();
    }
}