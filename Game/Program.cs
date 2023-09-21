using Game.Enum;
using Game.Fabric;
using Game.Interface;


var fabric = new WarriorFabric();

List<WarriorEnum> warriorEnums = Enum.GetValues(typeof(WarriorEnum))
    .Cast<WarriorEnum>()
    .ToList();

List<IWarrior> warriors = new List<IWarrior>();

foreach (var warriorEnum in warriorEnums)
{
    try
    {
        warriors.Add(fabric.CreateWarrior(warriorEnum));
    }
    catch
    {
        
    }
}

foreach (var warrior in warriors)
{
    warrior.Info();
}