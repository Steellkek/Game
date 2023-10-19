namespace Game.Interface;
/// <summary>
/// Легионер
/// </summary>
public class Legionnair : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Legionnair));
    }
}