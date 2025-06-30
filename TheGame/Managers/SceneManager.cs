using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheGame.Core;
using TheGame.Scene;

namespace TheGame.Managers
{
    internal class SceneManager : Component
    {
        MenuScene Menu = new();
        Level1 level1 = new();
        Level2 level2 = new();


        internal override void LoadContent(ContentManager content)
        {
            switch (Data.CurrentState)
            {
                case Data.Scenes.Menu:
                    {
                        Menu.LoadContent(content);
                    break;
                    }
                case Data.Scenes.Level1:
                    {
                        level1.LoadContent(content);
                    break;
                    }
                case Data.Scenes.Level2:
                    {
                        level2.LoadContent(content);
                    break;
                    }
            }
        }

        internal override void Update(GameTime gameTime)
        {
            switch (Data.CurrentState)
            {
                case Data.Scenes.Menu:
                    {
                        Menu.Update(gameTime);
                        break;
                    }
                case Data.Scenes.Level1:
                    {
                        level1.Update(gameTime);
                        break;
                    }
                case Data.Scenes.Level2:
                    {
                        level2.Update(gameTime);
                        break;
                    }
            }
        }
        internal override void Draw(SpriteBatch spriteBatch)
        {
            switch (Data.CurrentState)
            {
                case Data.Scenes.Menu:
                    {
                        Menu.Draw(spriteBatch);
                        break;
                    }
                case Data.Scenes.Level1:
                    {
                        level1.Draw(spriteBatch);
                        break;
                    }
                case Data.Scenes.Level2:
                    {
                        level2.Draw(spriteBatch);
                        break;
                    }
            }
        }
    }
}
