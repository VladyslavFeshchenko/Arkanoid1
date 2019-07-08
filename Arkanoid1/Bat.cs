using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    public class Bat : GameObject
    {

        public Bat(ConsoleGraphics graphics,int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            W = w;
            H = h;

            Image = graphics.LoadImage("breakout_sprites.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, 0, 280, W, H, X, Y);
        }

        public void UpdateBat(ConsoleGraphics graphics)
        {

            if (Input.IsKeyDown(Keys.RIGHT))
            {
                X += 40;

                if (X >= graphics.ClientWidth - W)
                {
                    X = graphics.ClientWidth - W;
                }
            }

            if (Input.IsKeyDown(Keys.LEFT))
            {
                X -= 40;

                if (X <= 0)
                {
                    X = 0;
                }
            }

        }
    }
}