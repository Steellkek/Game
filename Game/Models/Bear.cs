namespace Game.Interface;
/// <summary>
/// Медведь
/// </summary>
public class Bear : IWarrior
{
    public void Info()
    {
        Console.WriteLine(nameof(Bear));
    }
}