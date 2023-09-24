using System;
using System.Collections.Generic;

// Паттерн Фабричный метод
// Интерфейс для создания юнитов
interface IUnitFactory
{
    Unit CreateUnit();
}

// Конкретные фабрики для создания разных типов юнитов
class SoldierFactory : IUnitFactory
{
    public Unit CreateUnit()
    {
        return new Soldier();
    }
}

class ArcherFactory : IUnitFactory
{
    public Unit CreateUnit()
    {
        return new Archer();
    }
}

// Базовый класс для юнитов
abstract class Unit
{
    public abstract void Attack();
    public abstract Unit Clone(); // Паттерн Прототип
}

// Конкретные классы для юнитов
class Soldier : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Солдат атакует!");
    }

    public override Unit Clone()
    {
        return new Soldier();
    }
}

class Archer : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Лучник атакует!");
    }

    public override Unit Clone()
    {
        return new Archer();
    }
}

// Паттерн Абстрактная фабрика
// Интерфейс для создания армии
interface IArmyFactory
{
    List<Unit> CreateArmy();
}

// Конкретные фабрики для создания армий разных типов
class RedArmyFactory : IArmyFactory
{
    public List<Unit> CreateArmy()
    {
        List<Unit> army = new List<Unit>();
        army.Add(new Soldier());
        army.Add(new Soldier());
        army.Add(new Archer());
        army.Add(new Archer());
        return army;
    }
}

class BlueArmyFactory : IArmyFactory
{
    public List<Unit> CreateArmy()
    {
        List<Unit> army = new List<Unit>();
        army.Add(new Soldier());
        army.Add(new Archer());
        army.Add(new Archer());
        return army;
    }
}

// Паттерн Одиночка
// Класс для управления ресурсами (финансами)
class ResourceManager
{
    private static ResourceManager instance;

    private int resources = 1000;

    private ResourceManager() { }

    public static ResourceManager GetInstance()
    {
        if (instance == null)
        {
            instance = new ResourceManager();
        }
        return instance;
    }

    public int GetResources()
    {
        return resources;
    }

    public void SpendResources(int amount)
    {
        if (resources >= amount)
        {
            resources -= amount;
            Console.WriteLine($"Ресурсы уменьшились на {amount}");
        }
        else
        {
            Console.WriteLine("Недостаточно ресурсов!");
        }
    }
}

// Паттерн Строитель
// Класс для организации боевых действий
class BattleDirector
{
    public void ConstructBattle(IBattleBuilder builder)
    {
        builder.BuildArmy();
        builder.BuildTerrain();
        builder.BuildResources();
    }
}

// Интерфейс для создания боя
interface IBattleBuilder
{
    void BuildArmy();
    void BuildTerrain();
    void BuildResources();
    Battle GetBattle();
}

// Класс, представляющий бой
class Battle
{
    public List<Unit> Army { get; set; }
    public string Terrain { get; set; }
    public int Resources { get; set; }

    public void StartBattle()
    {
        Console.WriteLine("Битва началась!");
        foreach (var unit in Army)
        {
            unit.Attack();
        }
    }
}

// Конкретный строитель боя
class BattleBuilder : IBattleBuilder
{
    private Battle battle = new Battle();

    public void BuildArmy()
    {
        battle.Army = new RedArmyFactory().CreateArmy();
    }

    public void BuildTerrain()
    {
        battle.Terrain = "Гористая местность";
    }

    public void BuildResources()
    {
        battle.Resources = ResourceManager.GetInstance().GetResources();
        ResourceManager.GetInstance().SpendResources(200);
    }

    public Battle GetBattle()
    {
        return battle;
    }
}

// Класс для воина
class Warrior : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Воин атакует!");
    }

    public override Unit Clone()
    {
        return new Warrior();
    }
}

// Класс для строителя
class Builder : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Строитель атакует!");
    }

    public override Unit Clone()
    {
        return new Builder();
    }
}

// Класс для мага-целителя
class Healer : Unit
{
    public override void Attack()
    {
        Console.WriteLine("Маг-целитель атакует!");
    }

    public override Unit Clone()
    {
        return new Healer();
    }
}

// Обновленные фабрики для создания разных типов юнитов
class WarriorFactory : IUnitFactory
{
    public Unit CreateUnit()
    {
        return new Warrior();
    }
}

class BuilderFactory : IUnitFactory
{
    public Unit CreateUnit()
    {
        return new Builder();
    }
}

class HealerFactory : IUnitFactory
{
    public Unit CreateUnit()
    {
        return new Healer();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создаем боевой директор
        BattleDirector director = new BattleDirector();

        // Создаем строителя боя
        IBattleBuilder builder = new BattleBuilder();

        // Строим битву
        director.ConstructBattle(builder);

        // Получаем битву
        Battle battle = builder.GetBattle();

        // Начинаем битву
        battle.StartBattle();
    }
}
