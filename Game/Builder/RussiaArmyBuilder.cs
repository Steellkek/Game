using Game.Enum;

namespace Game.Interface;

/// <summary>
/// Строитель армиии России
/// </summary>
public class RussiaArmyBuilder : BaseArmyBuilder
{
    public override void CreateArmy()
    {
        Country = CountryEnum.Russia;
        Army = new Army(){Country = Country};
    }

    public override void BuildArcher()
    {
        Army.Archers.Add(new Archer());
    }

    public override void BuildBear()
    {
        Army.Bears.Add(new Bear());
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