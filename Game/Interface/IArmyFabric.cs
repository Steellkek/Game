using Game.Enum;

namespace Game.Interface;

/// <summary>
/// Интерфейс для фабрики армии
/// </summary>
public abstract class IArmyFabric
{
    public abstract IWarrior ChoiceWarrior();
}