using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace TheGame.Engine
{
    internal class Tiles
    {
        public static Tiles[][] AllTileGroups;

        public Texture2D tileTexture; // Do you want this to be just Texture? or want it to be specific because we will connect this tile class to all level1 and 2 classes
        public Rectangle tileDisplay;
        public Rectangle tileSource;
        public Color tileColor;

        // public bool isSolid;
        // public bool isInteract;
        // public bool collect;
        // public bool isDamaged;
      

        public Tiles(Texture2D tileTexture, Rectangle tileDisplay, Rectangle tileSource, Color tileColor)
        {
            this.tileTexture = tileTexture;
            this.tileDisplay = tileDisplay;
            this.tileSource = tileSource;
            this.tileColor = tileColor;
        }

       
        public Rectangle TileDisplay { get => tileDisplay; }
        public Rectangle TileSource { get => tileSource; }
        public Color TileColor { get => tileColor; }
    }
}