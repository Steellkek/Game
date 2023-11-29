using Game.Enum;

namespace Game.Interface;

/// <summary>
/// Строитель армиии Японии
/// </summary>
public class JapanArmyBuilder : BaseArmyBuilder
{
    public override void CreateArmy()
    {
        Country = CountryEnum.Japan;
        Army = new Army(){Country = Country};
    }

    public override void BuildArcher()
    {
        Army.warriors.Add(new Archer());
    }

    public override void BuildSamurai()
    {
        Army.warriors.Add(new Samurai());
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