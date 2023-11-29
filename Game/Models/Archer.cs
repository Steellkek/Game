namespace Game.Interface;
/// <summary>
/// Лучник
/// </summary>
public class Archer : IWarrior
{
    public Archer()
    {
        attack = 1;
    }
    public override void Info()
    {
        Console.WriteLine(nameof(Archer));
    }
}