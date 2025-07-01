using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using TheGame.Core;

namespace TheGame.Engine
{
    internal class GameTile
    {
        //texture of the tile
        private Texture2D tileTexture;
        private Rectangle source;
        private Color color;

        private Rectangle[] tiles;
        private Rectangle display;
        private Point position;
        private Point direction;
        private int repeatNumber;

        public GameTile(Texture2D tileTexture, Color color, Point position, Point direction, int repeatNumber)
        {
            this.tileTexture = tileTexture;
            this.source = new Rectangle(0, 0, tileTexture.Width, tileTexture.Height);
            this.color = color;
            this.position = position;
            this.repeatNumber = repeatNumber;
            this.tiles = CreateTileV1(position, direction, repeatNumber);
        }

        public Texture2D TileTexture
        {
            get { return tileTexture; }
        }
        public Rectangle Source
        {
            get { return source; }
        }

        public Rectangle Display
        {
            get { return display; }
        }

        public Color Color
        {   
            get { return color; }
        }

        public Rectangle[] CreateTileV1(Point position, Point direction, int repeat = 0)
        {
            Rectangle[] tiles = new Rectangle[repeat];
            for (int x = 0; x < (Data.ScreenWidth / Data.DisplayTileSize); x++)
            {
                for (int y = 0;  y < (Data.ScreenHeight / Data.DisplayTileSize) ; y++)
                {
                    for (int i = 0; i < repeat; i++)
                    {
                        int tileX = (position.X + direction.X * i) * Data.DisplayTileSize;
                        int tileY = (position.Y + direction.Y * i) * Data.DisplayTileSize;
                        tiles[i] = new Rectangle(tileX, tileY, Data.DisplayTileSize, Data.DisplayTileSize);
                    }
                }
            }
            
            return tiles;
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            foreach (var rect in tiles)
            {
                spriteBatch.Draw(
                    tileTexture,
                    rect,
                    source,
                    color
                    );
            }

        }
    }
}




