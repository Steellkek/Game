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
        Army.Archers.Add(new Archer());
    }

    public override void BuildSamurai()
    {
        Army.Samurais.Add(new Samurai());
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