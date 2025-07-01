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
        Rectangle[] invTileRects;
        GameTile[] invTile;


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
             

            invTile[0] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(1, 0), new(1, 0), 29);
            invTile[1] = new GameTile(content.Load<Texture2D>("InvisibleTile"), Data.ColorWhite, new(0, 0), new(1, 0), 5);

            


        }

        internal override void Update(GameTime gameTime)
        {
            
        }

      
        internal override void Draw(SpriteBatch spriteBatch)
        {   
            spriteBatch.Draw(level1[0].Texture, level1[0].Display, level1[0].Source, level1[0].Color); // background
            
            spriteBatch.Draw(level1[1].Texture, level1[1].Display, level1[1].Source, level1[1].Color); // Tile

            #region TILES
            invTile[0].Draw(spriteBatch);
            invTile[1].Draw(spriteBatch);

            #endregion


            spriteBatch.Draw(level1[2].Texture, level1[2].Display, level1[2].Source, level1[2].Color); //object

        }
    }
}
