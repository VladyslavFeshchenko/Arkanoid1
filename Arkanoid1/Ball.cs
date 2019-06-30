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

        public Ball(ConsoleGraphics graphics, int x, int y)
        {

            X = x;
            Y = y;

            Image = graphics.LoadImage("breakout_sprites.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {

            graphics.DrawImagePart(Image, 160, 200, 20, 20, X, Y);

        }

        public void ToBeatOfTheField(Field field)
        {

            if (X <= 5 || X >= field.w - 20)
            {
                speedX *= -1;
            }

            if (Y <= 0)
            {
                speedY *= -1;
            }

            if (Y > field.h - 20)
            {
                speedX = 0;
                speedY = 0;
            }

            X += speedX;
            Y += speedY;
        }

        public void ToBeatOfTheBat(Bat bat)
        {

            if (Y + 20 >= bat.Y && X + 20 >= bat.X && X <= bat.X + 130)
            {
                speedY = -10;

                if (speedX > 0)
                {
                    if (X + 20 >= bat.X && X <= bat.X + 20)
                    {
                        speedX = -13;
                        speedY = -7;
                    }
                    if (X + 20 >= bat.X + 20 && X <= bat.X + 65)
                    {
                        speedX = -7;
                        speedY = -13;
                    }
                    if (X + 20 >= bat.X + 65 && X <= bat.X + 110)
                    {
                        speedX = 7;
                        speedY = -13;
                    }
                    if (X + 20 >= bat.X + 110 && X <= bat.X + 130)
                    {
                        speedX = 13;
                        speedY = -7;
                    }
                }

                if (speedX < 0)
                {
                    if (X + 20 >= bat.X && X <= bat.X + 20)
                    {
                        speedX = -13;
                        speedY = -7;
                    }
                    if (X + 20 >= bat.X + 20 && X <= bat.X + 65)
                    {
                        speedX = -7;
                        speedY = -13;
                    }
                    if (X + 20 >= bat.X + 65 && X <= bat.X + 110)
                    {
                        speedX = 7;
                        speedY = -13;
                    }
                    if (X + 20 >= bat.X + 110 && X <= bat.X + 130)
                    {
                        speedX = 13;
                        speedY = -7;
                    }
                }
            }
        }

        public void ToBeatOfTheTargets(Target targets)
        {
            if (X <= targets.X + 32 && X + 20 >= targets.X && Y <= targets.Y + 32 && Y + 20 >= targets.Y)
            {
                speedY *= -1;

                targets.X = targets.X * 1000;
                targets.Y = targets.Y * 1000;

                count += 10;
            }
        }

    }
}
