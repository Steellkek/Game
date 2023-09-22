using Game.Enum;

namespace Game.Interface;

/// <summary>
/// Интерфейс для фабрики армии
/// </summary>
public abstract class IArmyFabric
{
    /// <summary>
    /// Страна
    /// </summary>
    public abstract CountryEnum CountryEnum { get; set; }

    /// <summary>
    /// Получить лучника
    /// </summary>
    /// <returns></returns>
    public abstract IArcher GetArcher();

    /// <summary>
    /// Получить всадника
    /// </summary>
    /// <returns></returns>
    public abstract IHorseman GetHorseman();

    /// <summary>
    /// Получить пехотинца
    /// </summary>
    /// <returns></returns>
    public abstract IInfantryman GetInfantryman();

    /// <summary>
    /// Получить война
    /// </summary>
    /// <returns></returns>
    public abstract IWarrior GetWarrior();
}