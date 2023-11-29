using Game.Interface;

namespace Game.Director;
/// <summary>
/// Класс-распорядитель
/// </summary>
public class DirectorArmy
{
    public Army CreateArmy(BaseArmyBuilder armyBuilder)
    {
        armyBuilder.CreateArmy();
        armyBuilder.BuildLegionnair();
        armyBuilder.BuildArcher();
        armyBuilder.BuildInfantryman();
        armyBuilder.BuildBear();
        armyBuilder.BuildSamurai();
        armyBuilder.BuildWarrior();
        armyBuilder.BuildHorseman();
        return armyBuilder.Army;
    }
}