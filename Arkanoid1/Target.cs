using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    public class Target : GameObject
    {

        public Target(ConsoleGraphics graphics, int x, int y, int w, int h)
        {

            X = x;
            Y = y;
            W = w;
            H = h;

            Image = graphics.LoadImage("breakout_sprites.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, 160, 1, W, H, X, Y);
        }
    }
}
