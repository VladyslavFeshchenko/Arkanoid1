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
        public int X { get; set; }
        public int Y { get; set; }
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }
        public int W { get; set; }
        public int H { get; set; }

        public uint Color { get; set; }

        public ConsoleImage Image { get; set; }

        public virtual void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, OffsetX, OffsetY, W, H, X, Y);
        }

    }
}
