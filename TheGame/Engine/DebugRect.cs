using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.Core;

namespace TheGame.Engine
{
    internal class DebugRect : Component
    {

        internal override void LoadContent(ContentManager content)
        {
            
        }

        internal override void Update(GameTime gameTime)
        {
            
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {

        }

        internal void DrawRectHollow(SpriteBatch spriteBatch, Texture2D debugpixel, Rectangle rect, int thickness)
        {
            spriteBatch.Draw(debugpixel, new Rectangle(rect.X, rect.Y, rect.Width, thickness), Color.Red);
            spriteBatch.Draw(debugpixel, new Rectangle(rect.X, rect.Y + rect.Height - thickness, rect.Width, thickness), Color.Red);
            spriteBatch.Draw(debugpixel, new Rectangle(rect.X, rect.Y, thickness, rect.Height), Color.Red);
            spriteBatch.Draw(debugpixel, new Rectangle(rect.X + rect.Width - thickness, rect.Y, thickness, rect.Height), Color.Red);
        }
    }
}
