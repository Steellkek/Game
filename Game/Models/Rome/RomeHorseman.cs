namespace Game.Interface.Rome;
/// <summary>
/// Римский всадник
/// </summary>
public class RomeHorseman : IHorseman
{
    public void Info()
    {
        Console.WriteLine(nameof(RomeHorseman));
    }
}