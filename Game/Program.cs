using Game.Game;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = GameDirector.GetInstance();
            game.StartGame();
            game.MainGame();
            game.EndGame();
        }
    }
}