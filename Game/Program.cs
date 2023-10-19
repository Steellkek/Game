using Game.Director;
using Game.Interface;

Director dir = new Director();
JapanArmyBuilder japanArmyBuilder = new JapanArmyBuilder();
RussiaArmyBuilder russiaArmyBuilder = new RussiaArmyBuilder();
RomeArmyBuilder romeArmyBuilder = new RomeArmyBuilder();

var japanArmy = dir.CreateArmy(japanArmyBuilder);
var russiaArmy = dir.CreateArmy(russiaArmyBuilder);
var romeArmy = dir.CreateArmy(romeArmyBuilder);

japanArmy.GetInfo();
russiaArmy.GetInfo();
romeArmy.GetInfo();