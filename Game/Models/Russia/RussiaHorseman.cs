namespace Game.Interface.Russia;
/// <summary>
/// Русский всадник
/// </summary>
public class RussiaHorseman : IHorseman
{
    public void Info()
    {
        Console.WriteLine(nameof(RussiaHorseman));
    }
}