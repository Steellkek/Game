using Game.Enum;

namespace Game.Interface.Russia;
/// <summary>
/// Фабрика по созданию российской армии
/// </summary>
public class RussiaArmyFabric : IArmyFabric
{
    public override CountryEnum CountryEnum { get; set; } = CountryEnum.Russia;

    public override IArcher GetArcher()
    {
        return new RussiaArcher();
    }

    public override IHorseman GetHorseman()
    {
        return new RussiaHorseman();
    }

    public override IInfantryman GetInfantryman()
    {
        return new RussiaInfantryman();
    }

    public override IWarrior GetWarrior()
    {
        return new RussiaWarrior();
    }
}