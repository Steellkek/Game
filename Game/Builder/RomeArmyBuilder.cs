using Game.Enum;

namespace Game.Interface;

/// <summary>
/// Строитель армиии Рима
/// </summary>
public class RomeArmyBuilder : BaseArmyBuilder
{
    public override void CreateArmy()
    {
        Country = CountryEnum.Rome;
        Army = new Army(){Country = Country};
    }

    public override void BuildArcher()
    {
        Army.Archers.Add(new Archer());
    }

    public override void BuildLegionnair()
    {
        Army.Legionnairs.Add(new Legionnair());
    }

    public override void BuildHorseman()
    {
        Army.Horsemens.Add(new Horseman());
    }

    public override void BuildInfantryman()
    {
        Army.Infantrymens.Add(new Infantryman());
    }

    public override void BuildWarrior()
    {
        Army.Warriors.Add(new Warrior());
    }
}