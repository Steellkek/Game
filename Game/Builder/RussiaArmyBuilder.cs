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
        Army.warriors.Add(new Archer());
    }

    public override void BuildBear()
    {
        Army.warriors.Add(new Bear());
    }

    public override void BuildHorseman()
    {
        Army.warriors.Add(new Horseman());
    }

    public override void BuildInfantryman()
    {
        Army.warriors.Add(new Infantryman());
    }

    public override void BuildWarrior()
    {
        Army.warriors.Add(new Warrior());
    }
}