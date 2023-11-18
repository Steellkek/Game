using Game.Enum;

namespace Program.Game;

public class Game
{
    private static Game _game;

    public CountryEnum _firstCountry { get; private set; }
    
    public CountryEnum _secondCountry { get; private set; }

    public int Hp { get; set; }
    private Game(CountryEnum firstCountry, CountryEnum secondCountry)
    {
        _firstCountry = firstCountry;
        _secondCountry = secondCountry;
    }

}