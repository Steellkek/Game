namespace Game.Interface;

public class Warrior : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Warrior));
    }
}