namespace Game.Interface.Russia;
/// <summary>
/// Японский пехотинец
/// </summary>
public class JapanInfantryman : IInfantryman
{
    public void Info()
    {
        Console.WriteLine(nameof(JapanInfantryman));
    }
}