using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    public abstract class GameObject
    {
        private int x, y, offsetX, offsetY, w, h;

        private uint color;

        private ConsoleImage image;

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public int OffsetX { get { return offsetX; } set { offsetX = value; } }
        public int OffsetY { get { return offsetY; } set { offsetY = value; } }
        public int W { get { return w; } set { w = value; } }
        public int H { get { return h; } set { h = value; } }

        public uint Color { get { return color; } set { color = value; } }

        public ConsoleImage Image { get { return image; } set { image = value; } }

        public virtual void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, OffsetX, OffsetY, W, H, X, Y);
        }

    }
}
