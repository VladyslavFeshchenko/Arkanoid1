using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    public class StartButton : GameObject
    {
        public bool pushStart;

        public StartButton(ConsoleGraphics graphics, int x, int y)
        {

            X = x;
            Y = y;

            Image = graphics.LoadImage("30_buttons_set.png");
        }

        public override void Render(ConsoleGraphics graphics)
        {
            graphics.DrawImagePart(Image, 0, 0, 200, 50, X, Y);
        }

        public bool PushStart()
        {
            pushStart = false;

            if (Input.MouseX >= X-150 && Input.MouseX <= X + 50 && Input.MouseY >= Y-50 && Input.MouseY <= Y)
            {
                if (Input.IsMouseLeftButtonDown)
                {
                    pushStart = true;
                }
            }

            return pushStart;
        }

    }
}
