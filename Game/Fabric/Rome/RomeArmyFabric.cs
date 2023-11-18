using Game.Enum;

namespace Game.Interface.Russia;
/// <summary>
/// Фабрика по созданию римской армии
/// </summary>
public class RomeArmyFabric : IArmyFabric
{
    public override Archer GetArcher()
    {
        return new Archer();
    }

    public override Horseman GetHorseman()
    {
        return new Horseman();
    }

    public override Infantryman GetInfantryman()
    {
        return new Infantryman();
    }

    public override Warrior GetWarrior()
    {
        return new Warrior();
    }
}