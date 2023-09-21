namespace Game.Interface.Russia;
/// <summary>
/// Римский лучник
/// </summary>
public class RomeArcher : IArcher
{
    public void Info()
    {
        Console.WriteLine(nameof(RomeArcher));
    }
}