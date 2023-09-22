using Game.Enum;

namespace Game.Interface;

public class Army
{
    /// <summary>
    /// Лучники
    /// </summary>
    public List<IArcher> Archers = new();
    /// <summary>
    /// Войны
    /// </summary>
    public List<IWarrior> Warriors = new();
    /// <summary>
    /// Всадники
    /// </summary>
    public List<IHorseman> Horsemens = new();
    /// <summary>
    /// Пехотинцы
    /// </summary>
    public List<IInfantryman> Infantrymens = new();
    /// <summary>
    /// Страна
    /// </summary>
    public  CountryEnum CountryEnum { get; set; }

    /// <summary>
    /// Конструктор через фабрику
    /// </summary>
    /// <param name="armyFabric"></param>
    public Army(IArmyFabric armyFabric)
    {
        CountryEnum = armyFabric.CountryEnum;
        
        Archers.Add(armyFabric.GetArcher());
        
        Warriors.Add(armyFabric.GetWarrior());
        
        Horsemens.Add(armyFabric.GetHorseman());
        
        Infantrymens.Add(armyFabric.GetInfantryman());
    }
    /// <summary>
    /// Информация о Армии
    /// </summary>
    public void GetInfo()
    {
        Console.WriteLine($"{CountryEnum} army:");

       Archers.ForEach(x=> x.Info());
       Warriors.ForEach(x=> x.Info());
       Horsemens.ForEach(x=> x.Info());
       Infantrymens.ForEach(x=> x.Info());
    }
}