namespace Game.Interface.Russia;
/// <summary>
/// Русский пехотинец
/// </summary>
public class RussiaInfantryman : IInfantryman
{
    public void Info()
    {
        Console.WriteLine(nameof(RussiaInfantryman));
    }
}