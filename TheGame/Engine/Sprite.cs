using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Engine
{
    internal class Sprite
    {
        Texture2D spTexture;
        Rectangle spDisplay;
        Rectangle spSource;
        Color spColor;

        public Sprite(Texture2D spTexture, Rectangle spDisplay, Rectangle spSource, Color spColor)
        {
            this.spTexture = spTexture;
            this.spDisplay = spDisplay;
            this.spSource = spSource;
            this.spColor = spColor;
        }

        public Texture2D SpTexture { get => spTexture; }
        public Rectangle SpDisplay { get => spDisplay; }
        public Rectangle SpSource { get => spSource; }
        public Color SpColor { get => spColor; }
    }
}
