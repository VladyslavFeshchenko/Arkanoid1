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

        public Bat(ConsoleGraphics graphics,int x, int y)
        {
            X = x;
            Y = y;

            Image = graphics.LoadImage("breakout_sprites.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, 0, 280, 130, 30, X, Y);
        }

        public void UpdateBat(ConsoleGraphics graphics)
        {

            if (Input.IsKeyDown(Keys.RIGHT))
            {
                X += 40;

                if (X >= graphics.ClientWidth - 130)
                {
                    X = graphics.ClientWidth - 130;
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