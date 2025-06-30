using System;

namespace TheGame
{
    static internal class Program
    {
        [STAThread]
        static void Main()
        {
            using var game = new TheGame.Core.MainGame();
            game.Run();
        }
    }
}