using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    public class Ball : GameObject
    {

        public int speedX = 10, speedY = -10;

        public int count = 0;

        public Ball(ConsoleGraphics graphics, int x, int y, int w, int h)
        {

            X = x;
            Y = y;
            W = w;
            H = h;

            Image = graphics.LoadImage("breakout_sprites.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {

            graphics.DrawImagePart(Image, 160, 200, W, H, X, Y);

        }

        public void ToBeatOfTheField(Field field)
        {

            if (X <= 5 || X >= field.w - W)
            {
                speedX *= -1;
            }

            if (Y <= 0)
            {
                speedY *= -1;
            }

            if (Y > field.h - H)
            {
                speedX = 0;
                speedY = 0;
            }

            X += speedX;
            Y += speedY;
        }

        public void ToBeatOfTheBat(Bat bat)
        {

            if (Y + H >= bat.Y && X + W >= bat.X && X <= bat.X + bat.W)
            {
                speedY = -10;

                if (speedX > 0)
                {
                    if (X + W >= bat.X && X <= bat.X + bat.W/7)
                    {
                        speedX = -13;
                        speedY = -7;
                    }
                    if (X + W >= bat.X + 20 && X <= bat.X + bat.W/2)
                    {
                        speedX = -7;
                        speedY = -13;
                    }
                    if (X + W >= bat.X + 65 && X <= bat.X + bat.W*6/7)
                    {
                        speedX = 7;
                        speedY = -13;
                    }
                    if (X + W >= bat.X + 110 && X <= bat.X + bat.W)
                    {
                        speedX = 13;
                        speedY = -7;
                    }
                }

                if (speedX < 0)
                {
                    if (X + W >= bat.X && X <= bat.X + bat.W/7)
                    {
                        speedX = -13;
                        speedY = -7;
                    }
                    if (X + W >= bat.X + 20 && X <= bat.X + bat.W/2)
                    {
                        speedX = -7;
                        speedY = -13;
                    }
                    if (X + W >= bat.X + 65 && X <= bat.X + bat.W*6/7)
                    {
                        speedX = 7;
                        speedY = -13;
                    }
                    if (X + W >= bat.X + 110 && X <= bat.X + bat.W)
                    {
                        speedX = 13;
                        speedY = -7;
                    }
                }
            }
        }

        public void ToBeatOfTheTargets(Target targets)
        {
            if (X <= targets.X + targets.W && X + W >= targets.X && Y <= targets.Y + targets.H && Y + H >= targets.Y)
            {
                speedY *= -1;

                targets.X = targets.X * 1000;
                targets.Y = targets.Y * 1000;

                count += 10;
            }
        }

    }
}
