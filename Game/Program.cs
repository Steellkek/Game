using Game.Interface;
using Game.Interface.Russia;

var romeFabric = new RomeArmyFabric();
var russiaFabric = new RussiaArmyFabric();
var japanFabric = new JapanArmyFabric();

var romeArmy = new Army(romeFabric);
var russiaArmy = new Army(russiaFabric);
var japanArmy = new Army(japanFabric);

romeArmy.GetInfo();
russiaArmy.GetInfo();
japanArmy.GetInfo();