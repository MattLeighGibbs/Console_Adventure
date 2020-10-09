namespace ConsoleAdventure
{
    public interface INonPlayerCharacter
    {
        string Message { get; set; }
        void Talk();
    }
}