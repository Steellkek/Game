namespace Game.Interface.Russia;
/// <summary>
/// Русский лучник
/// </summary>
public class RussiaArcher : IArcher
{
    public void Info()
    {
        Console.WriteLine(nameof(RussiaArcher));
    }
}