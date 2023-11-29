using Game.Enum;
using Game.Interface;

namespace Game.Fabric;

public class FabricBuilder
{
    public static BaseArmyBuilder GetBuilder(CountryEnum countryEnum)
    {
        switch (countryEnum)
        {
            case CountryEnum.Russia:
                return new RussiaArmyBuilder();
            case CountryEnum.Rome:
                return new RomeArmyBuilder();
            case CountryEnum.Japan:
                return new JapanArmyBuilder();
            default:
                throw new Exception("Такого класса нет");
        }
    }
}