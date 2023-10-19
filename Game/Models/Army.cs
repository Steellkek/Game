using Game.Enum;

namespace Game.Interface;

public class Army
{
    /// <summary>
    /// Лучники
    /// </summary>
    public List<Archer> Archers { get; set; } = new();
    
    /// <summary>
    /// Войны
    /// </summary>
    public List<Warrior> Warriors { get; set; } = new();
    
    /// <summary>
    /// Всадники
    /// </summary>
    public List<Horseman> Horsemens { get; set; } = new();
    
    /// <summary>
    /// Пехотинцы
    /// </summary>
    public List<Infantryman> Infantrymens { get; set; } = new();
     
    /// <summary>
    /// Медведи
    /// </summary>
    public List<Bear> Bears { get; set; } = new();
    
    /// <summary>
    /// Самураи
    /// </summary>
    public List<Samurai> Samurais { get; set; } = new();
    
    /// <summary>
    /// Легионеры
    /// </summary>
    public List<Legionnair> Legionnairs { get; set; } = new();

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
        
        Archers.ForEach(x=> x.Info());
        Warriors.ForEach(x=> x.Info());
        Horsemens.ForEach(x=> x.Info());
        Infantrymens.ForEach(x=> x.Info());
        Bears.ForEach(x => x.Info());
        Samurais.ForEach(x => x.Info());
        Legionnairs.ForEach(x => x.Info());
        Console.WriteLine();
    }
}