using Game.Enum;

namespace Game.Interface;

/// <summary>
/// Базовый класс строителя армии
/// </summary>
public abstract class BaseArmyBuilder
{
    public CountryEnum Country { get; set; }
    /// <summary>
    /// Армия
    /// </summary>
    public Army Army { get; protected set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public virtual void CreateArmy(){}

    /// <summary>
    /// Построить лучника
    /// </summary>
    public virtual void BuildArcher(){}
    
    /// <summary>
    /// Построить война
    /// </summary>
    public virtual void BuildWarrior(){}
    
    /// <summary>
    /// Построить Медведя
    /// </summary>
    public virtual void BuildBear(){}
    
    /// <summary>
    /// Построить всадника
    /// </summary>
    public virtual void BuildHorseman(){}
    
    /// <summary>
    /// Построить пехотинца
    /// </summary>
    public virtual void BuildInfantryman(){}
    
    /// <summary>
    /// Построить легоинер
    /// </summary>
    public virtual void BuildLegionnair(){}
    
    /// <summary>
    /// Построить самурай
    /// </summary>
    public virtual void BuildSamurai(){}
}