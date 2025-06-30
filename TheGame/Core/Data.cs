using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Core
{
    public class Data
    {
        public static int ScreenWidth { get; set; } = 960; //960
        public static int ScreenHeight { get; set; } = 640; //640
        public static bool Exit { get; set; } = false;

        public static int SourceTileSize { get; set; } = 16; //Original pixel size
        public static int DisplayTileSize { get; set; } = 32; //Modified pixel size
        public static Color ColorWhite { get; set; } = Color.White;


        public enum Scenes { Menu, Level1, Level2 }
        public static Scenes CurrentState { get; set; } = Scenes.Level2;
    }
}
