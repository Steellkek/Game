namespace Game.Interface;
/// <summary>
/// Лошадь
/// </summary>
public class Horseman : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Horseman));
    }
}