using Game.Interface;

namespace Game.Models;
/// <summary>
/// Класс лучника
/// </summary>
public class Archer: IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Archer));
    }
}