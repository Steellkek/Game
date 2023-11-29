namespace Game.Interface;
/// <summary>
/// Самурай
/// </summary>
public class Samurai : IWarrior
{
    public Samurai()
    {
        attack = 2;
    }
    
    public override void Info()
    {
        Console.WriteLine(nameof(Samurai));
    }
}