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
        Army.warriors.Add(new Archer());
    }

    public override void BuildLegionnair()
    {
        Army.warriors.Add(new Legionnair());
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