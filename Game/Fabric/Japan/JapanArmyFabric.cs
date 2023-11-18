using Game.Enum;

namespace Game.Interface.Russia;
/// <summary>
/// Фабрика по созданию японской армии
/// </summary>
public class JapanArmyFabric : IArmyFabric
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

    public Samurai GetSamurai()
    {
        return new Samurai();
    }
}