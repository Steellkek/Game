namespace Game.Interface;

public class Warrior : IWarrior
{
    public Warrior()
    {
        attack = 1;
    }
    
    public override void Info()
    {
        Console.WriteLine(nameof(Warrior));
    }
}