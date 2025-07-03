using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using TheGame.Core;
using TheGame.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Scene
{
    internal class Level1 : Component
    {

        MapTexture[] level1 = new MapTexture[3];
        GameTile[] invTile = new GameTile[15];


        internal override void LoadContent(ContentManager content)
        {
            Texture2D level1_B = content.Load<Texture2D>("Level1_Background");
            Rectangle level1_BDR = new(0, 0, Data.ScreenWidth, Data.ScreenHeight);
            Rectangle level1_BSR = new(0, 0, level1_B.Width, level1_B.Height);

            level1[0] = new(
                level1_B,
                level1_BDR,
                level1_BSR,
                Data.ColorWhite
                );

            Texture2D level1_T = content.Load<Texture2D>("Level1_Tiles");
            Rectangle level1_TDR = new(0, 0, Data.ScreenWidth, Data.ScreenHeight);
            Rectangle level1_TSR = new(0, 0, level1_T.Width, level1_T.Height);

            level1[1] = new(
                level1_T,
                level1_TDR,
                level1_TSR,
                Data.ColorWhite
                );

            Texture2D level1_O = content.Load<Texture2D>("Level1_Object");
            Rectangle level1_ODR = new(0, 0, Data.ScreenWidth, Data.ScreenHeight);
            Rectangle level1_OSR = new(0, 0, level1_O.Width, level1_O.Height);

            level1[2] = new(
                level1_O,
                level1_ODR,
                level1_OSR,
                Data.ColorWhite
                );

            invTile[0] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(0, 0), new(1, 0), 30);
            invTile[1] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(0, 1), new(0, 1), 19);
            invTile[2] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(29, 1), new(0, 1), 19);
            invTile[3] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(1, 14), new(1, 0), 13);
            invTile[4] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(13, 15), new(0, 1), 5);
            invTile[5] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(20, 11), new(1, 0), 9);
            invTile[6] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(20, 12), new(0, 1), 8);
            invTile[7] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(26, 8), new(1, 0), 3);
            invTile[8] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(20, 5), new(1, 0), 5);
            invTile[9] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(1, 3), new(1, 0), 3);
            invTile[10] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(4, 4), new(1, 0), 2);
            invTile[11] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(6, 5), new(1, 0), 8);
            invTile[12] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(1, 4), new(1, 0), 3);
            invTile[13] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(3, 5), new(1, 0), 3);
            invTile[14] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(5, 6), new(1, 0), 9);
        }

        internal override void Update(GameTime gameTime)
        {

        }


        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(level1[0].Texture, level1[0].Display, level1[0].Source, level1[0].Color); // background

            spriteBatch.Draw(level1[1].Texture, level1[1].Display, level1[1].Source, level1[1].Color); // Tile

            #region TILES
            for (int i = 0; i < invTile.Length; i++)
            {
                invTile[i].Draw(spriteBatch);
            }
            #endregion

            spriteBatch.Draw(level1[2].Texture, level1[2].Display, level1[2].Source, level1[2].Color); //object

        }
    }
}
