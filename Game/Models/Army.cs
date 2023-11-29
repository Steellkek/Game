using Game.Enum;

namespace Game.Interface;

public class Army
{
    public List<IWarrior> warriors = new();

    /// <summary>
    /// Страна
    /// </summary>
    public  CountryEnum Country { get; set; } 


    /// <summary>
    /// Информация о Армии
    /// </summary>
    public void GetInfo()
    {
        Console.WriteLine($"{Country} army:");
        
        warriors.ForEach(x=> x.Info());
        Console.WriteLine();
    }

    public int ForceCalculation()
    {
        int attack = 0;
        
        warriors.ForEach(x=> attack += x.attack);

        return attack;
    }
}