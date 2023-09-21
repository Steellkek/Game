namespace Game.Interface;

/// <summary>
/// Интерфейс для фабрики армии
/// </summary>
public interface IArmyFabric
{
    IArcher GetArcher();
    IHorseman GetHorseman();
    IInfantryman GetInfantryman();
    IWarrior GetWarrior();
}