using Game.Interface;

namespace Game.Models;
/// <summary>
/// Всадник
/// </summary>
public class Horseman : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Horseman));
    }
}