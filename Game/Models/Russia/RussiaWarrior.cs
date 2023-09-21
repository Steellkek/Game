namespace Game.Interface;
/// <summary>
/// Русский воин
/// </summary>
public class RussiaWarrior : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(RussiaWarrior));
    }
}