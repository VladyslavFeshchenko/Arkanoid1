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

        public Target(ConsoleGraphics graphics, int x, int y)
        {

            X = x;
            Y = y;

            Image = graphics.LoadImage("breakout_sprites.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, 160, 1, 32, 32, X, Y);
        }
    }
}
