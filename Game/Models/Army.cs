namespace Game.Interface;

public class Army
{
    public List<IArcher> Archers = new();
    public List<IWarrior> Warriors = new();
    public List<IHorseman> Horsemens = new();
    public List<IInfantryman> Infantrymens = new();
}