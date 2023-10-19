namespace Game.Interface;
/// <summary>
/// Самурай
/// </summary>
public class Samurai : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Samurai));
    }
}