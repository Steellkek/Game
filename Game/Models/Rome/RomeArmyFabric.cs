using Game.Enum;
using Game.Interface.Rome;

namespace Game.Interface.Russia;
/// <summary>
/// Фабрика по созданию римской армии
/// </summary>
public class RomeArmyFabric : IArmyFabric
{
    public override CountryEnum CountryEnum { get; set; } = CountryEnum.Rome;

    public override IArcher GetArcher()
    {
        return new RomeArcher();
    }

    public override IHorseman GetHorseman()
    {
        return new RomeHorseman();
    }

    public override IInfantryman GetInfantryman()
    {
        return new RomeInfantryman();
    }

    public override IWarrior GetWarrior()
    {
        return new RomeWarrior();
    }
}