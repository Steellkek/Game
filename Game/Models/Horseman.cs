namespace Game.Interface;
/// <summary>
/// Лошадь
/// </summary>
public class Horseman : IWarrior
{
    public Horseman()
    {
        attack = 1;
    }
    public override void Info()
    {
        Console.WriteLine(nameof(Horseman));
    }
}