namespace Game.Interface.Rome;
/// <summary>
/// Римский воин
/// </summary>
public class RomeWarrior : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(RomeWarrior));
    }
}