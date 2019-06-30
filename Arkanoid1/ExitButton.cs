using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    class ExitButton : GameObject
    {
        public bool pushExit;

        public ExitButton (ConsoleGraphics graphics, int x, int y)
        {

            X = x;
            Y = y;

            Image = graphics.LoadImage("30_buttons_set.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, 200, 270, 190, 50, X, Y);
        }

        public bool PushExit()
        {
            pushExit = false;

            if (Input.MouseX >= X - 150 && Input.MouseX <= X + 50 && Input.MouseY >= Y - 50 && Input.MouseY <= Y)
            {
                if (Input.IsMouseLeftButtonDown)
                {
                    pushExit = true;
                }
            }

            return pushExit;
        }

    }
}
