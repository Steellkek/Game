using Game.Enum;

namespace Game.Interface.Russia;
/// <summary>
/// Фабрика по созданию российской армии
/// </summary>
public class RussiaArmyFabric : IArmyFabric
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

    public Bear GetBear()
    {
        return new Bear();
    }
}