using Game.Interface;

namespace Game.Models;
/// <summary>
/// Класс война
/// </summary>
public class Warrior : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Warrior));
    }
}