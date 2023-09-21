using Game.Enum;
using Game.Interface;
using Game.Models;

namespace Game.Fabric;

/// <summary>
/// Фабрика по созданию войнов
/// </summary>
public class WarriorFabric
{
    public IWarrior CreateWarrior(WarriorEnum warriorEnum)
    {
        switch (warriorEnum)
        {
            case WarriorEnum.Warrior:
                return new Warrior();
            case WarriorEnum.Archer:
                return new Archer();
            case WarriorEnum.Horseman:
                return new Horseman();
            case WarriorEnum.Infantryman:
                return new Infantryman();  
            default:
                throw new Exception("Такого класса нет");
        }
    }
}