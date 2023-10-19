namespace Game.Interface;
/// <summary>
/// Пехотинец
/// </summary>
public class Infantryman : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Infantryman));
    }
}