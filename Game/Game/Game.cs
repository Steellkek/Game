using Game.Countries;
using Game.Director;
using Game.Enum;
using Game.Fabric;
using Game.Interface;
using Program;

namespace Game.Game;

public class GameDirector
{
    private static GameDirector _instance;

    private GameDirector()
    {
        
    }

    public static GameDirector GetInstance()
    {
        if (_instance==null)
        {
            _instance = new GameDirector();
        }

        return _instance;
    }
    public void StartGame()
    {
        var countris = Utils.GetEnumList<CountryEnum>();
        Console.WriteLine("Выберите страну! Введите номер страны.");
        for (int i = 0; i < countris.Count; i++)
        {
            Console.WriteLine($"{i+1}). {Utils.DescriptionAttr(countris[i])}");
        }

        int choiceFirstCountry;
        while (!int.TryParse(Console.ReadLine(), out choiceFirstCountry) || choiceFirstCountry > 
               countris.Count || choiceFirstCountry <= 0)
        {
            Console.WriteLine("Такого варианта нет, введите номер варианта:");
        }

        FirstCountry firstCountry = FirstCountry.getInstance((CountryEnum)choiceFirstCountry);
        countris.Remove((CountryEnum)choiceFirstCountry);
        
        var random = new Random();
        SecondCountry secondCountry = SecondCountry.getInstance(countris[random.Next(countris.Count)]);
        
        DirectorArmy dir = new DirectorArmy();

        firstCountry._army = dir.CreateArmy(FabricBuilder.GetBuilder((CountryEnum)choiceFirstCountry));
        
        secondCountry._army = dir.CreateArmy(FabricBuilder.GetBuilder(secondCountry._countryEnum));
        
        Console.WriteLine("Ваша армия:");
        firstCountry._army.GetInfo();
        
        Console.WriteLine("Армия врага:");
        secondCountry._army.GetInfo();
    }

    public void MainGame()
    {
        FirstCountry firstCountry = FirstCountry.getInstance();
        SecondCountry secondCountry = SecondCountry.getInstance();

        IArmyFabric firstArmyFabric = FabricArmyFabric.getArmyFabric(firstCountry._countryEnum);

        while (FirstCountry._hpFirstCountry > 0 && SecondCountry._hpSecondCountry > 0)
        {
            Console.WriteLine(
                @"Выберите ваше следующее действие:
1. Атаковать врага
2. Получить юнита");

            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 
                   2 || choice <= 0)
            {
                Console.WriteLine("Такого варианта нет, введите номер варианта:");
            }

            if (choice == 1)
            {
                firstCountry.Attack();
            }
            else
            {
                firstCountry._army.warriors.Add(firstArmyFabric.ChoiceWarrior());
            }

            if (SecondCountry._hpSecondCountry <= 0)
            {
                break;
            }
            
            secondCountry.Attack();
        }
    }

    public void EndGame()
    {
        if (FirstCountry._hpFirstCountry > 0)
        {
            Console.WriteLine("Вы победили!");
            return;
        }
        
        Console.WriteLine("Вы проиграли!");
    }
    
}