namespace Game.Interface.Rome;
/// <summary>
/// Римский пехотинец
/// </summary>
public class RomeInfantryman : IInfantryman
{
    public void Info()
    {
        Console.WriteLine(nameof(RomeInfantryman));
    }
}