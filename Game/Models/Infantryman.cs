using Game.Interface;

namespace Game.Models;

/// <summary>
/// Класс пехотинца
/// </summary>
public class Infantryman: IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Infantryman));
    }
}