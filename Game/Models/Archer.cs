namespace Game.Interface;
/// <summary>
/// Лучник
/// </summary>
public class Archer : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Archer));
    }
}