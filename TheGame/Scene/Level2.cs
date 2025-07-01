using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.Core;
using TheGame.Engine;

namespace TheGame.Scene
{
    internal class Level2 : Component
    {
        MapTexture[] level2 = new MapTexture[3];

        internal override void LoadContent(ContentManager content)
        {
            Texture2D level2_B = content.Load<Texture2D>("Level2_Background");
            Rectangle level2_BDR = new(0, 0, Data.ScreenWidth, Data.ScreenHeight);
            Rectangle level2_BSR = new(0, 0, level2_B.Width, level2_B.Height);

            level2[0] = new(
                level2_B,
                level2_BDR,
                level2_BSR,
                Data.ColorWhite
                );

            Texture2D level2_T = content.Load<Texture2D>("Level2_Tiles");
            Rectangle level2_TDR = new(0, 0, Data.ScreenWidth, Data.ScreenHeight);
            Rectangle level2_TSR = new(0, 0, level2_T.Width, level2_T.Height);

            level2[1] = new(
                level2_T,
                level2_TDR,
                level2_TSR,
                Data.ColorWhite
                );

            Texture2D level2_O = content.Load<Texture2D>("Level2_Object");
            Rectangle level2_ODR = new(0, 0, Data.ScreenWidth, Data.ScreenHeight);
            Rectangle level2_OSR = new(0, 0, level2_O.Width, level2_O.Height);

            level2[2] = new(
                level2_O,
                level2_ODR,
                level2_OSR,
                Data.ColorWhite
                );
        }

        internal override void Update(GameTime gameTime)
        {

        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(level2[0].Texture, level2[0].Display, level2[0].Source, level2[0].Color);
            spriteBatch.Draw(level2[1].Texture, level2[1].Display, level2[1].Source, level2[1].Color);
            spriteBatch.Draw(level2[2].Texture, level2[2].Display, level2[2].Source, level2[2].Color);
        }
    }
}
