using Game.Enum;
using Game.Interface;

namespace Game.Countries;

public class SecondCountry
{
    private static SecondCountry instance;

    public CountryEnum _countryEnum { get; private set; }
    

    public static int _hpSecondCountry { get; set; } = 100;

    public Army _army { get; set; }
    
    protected SecondCountry(CountryEnum countryEnum)
    {
        _countryEnum = countryEnum;
    }
    
    protected SecondCountry()
    {
    }

    public static SecondCountry getInstance(CountryEnum countryEnum)
    {
        if (instance == null)
        {
            instance = new SecondCountry(countryEnum);
        }
        return instance;
    }
    
    public static SecondCountry getInstance()
    {
        if (instance == null)
        {
            instance = new SecondCountry();
        }
        return instance;
    }
    
    public void Attack()
    {
        int damage = _army.ForceCalculation();
        FirstCountry._hpFirstCountry -= _army.ForceCalculation();
        Console.WriteLine($"Вам нанесли {damage}");
        if (FirstCountry._hpFirstCountry < 0)
        {
            Console.WriteLine($"У врага осталось 0 хп");
            return;
        }
        Console.WriteLine($"У вас осталось {FirstCountry._hpFirstCountry} хп");
    }

}