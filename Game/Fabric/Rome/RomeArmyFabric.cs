﻿using Game.Enum;

namespace Game.Interface.Russia;
/// <summary>
/// Фабрика по созданию римской армии
/// </summary>
public class RomeArmyFabric : IArmyFabric
{
    public override IWarrior ChoiceWarrior()
    {
        Console.WriteLine(
            @"Выберите война!
1. Лучник;
2. Скакун;
3. Пехотинец
4. Воин;
5. Легионер.");
        
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice > 
               5 || choice <= 0)
        {
            Console.WriteLine("Такого варианта нет, введите номер варианта:");
        }

        switch (choice)
        {
            case 1:
                Console.WriteLine("Вы выбрали Лучника");
                return new Archer();
            case 2:
                Console.WriteLine("Вы выбрали скакуна");
                return new Horseman();
            case 3:
                Console.WriteLine("Вы выбрали Пехотинца");
                return new Infantryman();
            case 4:
                Console.WriteLine("Вы выбрали Воина");
                return new Warrior();
            case 5:
                Console.WriteLine("Вы выбрали Легионера");
                return new Legionnair();
        }

        return null;
    }
}