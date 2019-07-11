using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    class Button : GameObject
    {
        public bool push;

        public Button(ConsoleGraphics graphics, int offsetX, int offsetY, int w, int h, int x, int y)
        {

            X = x;
            Y = y;
            W = w;
            H = h;
            OffsetX = offsetX;
            OffsetY = offsetY;

            Image = graphics.LoadImage("30_buttons_set.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, OffsetX, OffsetY, W, H, X, Y);
        }

        public bool Push()
        {
            push = false;

            if (Input.MouseX >= X - W - 50 && Input.MouseX <= X + 50 && Input.MouseY >= Y - 50 && Input.MouseY <= Y + H )
            {
                if (Input.IsMouseLeftButtonDown)
                {
                    push = true;
                }
            }

            return push;
        }
    }
}
