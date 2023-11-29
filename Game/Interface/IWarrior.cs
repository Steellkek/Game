namespace Game.Interface;

/// <summary>
/// Интерфейс для войнов
/// </summary>
public abstract class IWarrior
{
    public int attack;

    /// <summary>
    /// Информация
    /// </summary>
    public abstract void Info();
}