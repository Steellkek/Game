using Game.Enum;
using Game.Interface;
using Game.Interface.Russia;

namespace Game.Fabric;

public class FabricArmyFabric
{
    static IArmyFabric GetArmy(CountryEnum countryEnum)
    {
        switch (countryEnum)
        {
            case CountryEnum.Russia:
                return new RussiaArmyFabric();
            case CountryEnum.Rome:
                return new RomeArmyFabric();
            case CountryEnum.Japan:
                return new JapanArmyFabric();
            default:
                throw new Exception("Такого класса нет");
        }
    }
}