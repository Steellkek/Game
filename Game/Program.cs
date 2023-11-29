using Game.Countries;
using Program.Game;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameDirector.StartGame();

            GameDirector.MainGame();
            
            GameDirector.EndGame();
        }
    }
}