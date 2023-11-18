using Game.Enum;

namespace Game.Interface;

/// <summary>
/// Интерфейс для фабрики армии
/// </summary>
public abstract class IArmyFabric
{
    /// <summary>
    /// Получить лучника
    /// </summary>
    /// <returns></returns>
    public abstract Archer GetArcher();

    /// <summary>
    /// Получить всадника
    /// </summary>
    /// <returns></returns>
    public abstract Horseman GetHorseman();

    /// <summary>
    /// Получить пехотинца
    /// </summary>
    /// <returns></returns>
    public abstract Infantryman GetInfantryman();

    /// <summary>
    /// Получить война
    /// </summary>
    /// <returns></returns>
    public abstract Warrior GetWarrior();
}