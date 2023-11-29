using Game.Enum;
using Game.Interface;

namespace Game.Countries;

public class FirstCountry
{
    private static FirstCountry instance;

    public CountryEnum _countryEnum { get; private set; }
    
    public static int _hpFirstCountry { get; set; } = 100;

    public Army _army { get; set; }

    protected FirstCountry(CountryEnum countryEnum)
    {
        _countryEnum = countryEnum;
    }
    
    protected FirstCountry( )
    {
    }

    public static FirstCountry getInstance(CountryEnum countryEnum)
    {
        if (instance == null)
        {
            instance = new FirstCountry(countryEnum);
        }
        return instance;
    }
    
    public static FirstCountry getInstance()
    {
        if (instance == null)
        {
            instance = new FirstCountry();
        }
        return instance;
    }
    
    public void Attack()
    {
        int damage = _army.ForceCalculation();
        SecondCountry._hpSecondCountry -= damage;
        Console.WriteLine($"Вы нанесли {damage}");
        if (SecondCountry._hpSecondCountry < 0)
        {
            Console.WriteLine($"У врага осталось 0 хп");
            return;
        }
        Console.WriteLine($"У врага осталось {SecondCountry._hpSecondCountry} хп");
    }
}