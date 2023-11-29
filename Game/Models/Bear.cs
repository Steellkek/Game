namespace Game.Interface;
/// <summary>
/// Медведь
/// </summary>
public class Bear : IWarrior
{
    public Bear()
    {
        attack = 50;
    }
    public override void Info()
    {
        Console.WriteLine(nameof(Bear));
    }
}