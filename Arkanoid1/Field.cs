using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    public class Field
    {
        public int x,y,w,h;

        public uint color;

        public Field(uint color, int x, int y, int w, int h)
        {

            this.color = color;

            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public void RenderField(ConsoleGraphics graphics)
        {
            graphics.FillRectangle(color, x, y, w, h);
        }
    }
}
