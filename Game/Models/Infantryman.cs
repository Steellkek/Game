namespace Game.Interface;
/// <summary>
/// Пехотинец
/// </summary>
public class Infantryman : IWarrior
{
    public Infantryman()
    {
        attack = 1;
    }
    
    public override void Info()
    {
        Console.WriteLine(nameof(Infantryman));
    }
}