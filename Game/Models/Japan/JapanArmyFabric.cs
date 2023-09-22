using Game.Enum;

namespace Game.Interface.Russia;
/// <summary>
/// Фабрика по созданию японской армии
/// </summary>
public class JapanArmyFabric : IArmyFabric
{
    public override CountryEnum CountryEnum { get; set; } = CountryEnum.Japan;

    public override IArcher GetArcher()
    {
        return new JapanArcher();
    }

    public override IHorseman GetHorseman()
    {
        return new JapanHorseman();
    }

    public override IInfantryman GetInfantryman()
    {
        return new JapanInfantryman();
    }

    public override IWarrior GetWarrior()
    {
        return new JapanWarrior();
    }
}