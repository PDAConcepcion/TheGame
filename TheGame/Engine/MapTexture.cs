using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGame.Engine
{
    internal class MapTexture
    {
        Texture2D _texture;
        Rectangle _display;
        Rectangle _source;
        Color _color;

        public MapTexture(Texture2D texture, Rectangle display, Rectangle source, Color color)
        {
            _texture = texture;
            _display = display;
            _source = source;
            _color = color;
        }

        public Texture2D Texture { get => _texture; }
        public Rectangle Display { get => _display; }
        public Rectangle Source { get => _source; }
        public Color Color { get => _color; }
    }
}
