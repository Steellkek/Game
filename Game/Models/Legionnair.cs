namespace Game.Interface;
/// <summary>
/// Легионер
/// </summary>
public class Legionnair : IWarrior
{
    public Legionnair()
    {
        attack = 2;
    }
    
    public override void Info()
    {
        Console.WriteLine(nameof(Legionnair));
    }
}