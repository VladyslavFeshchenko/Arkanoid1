using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    class Game
    {
        public void PlayGame ()
        {

            while (true)
            {

                Console.CursorVisible = false;
                ConsoleGraphics graphics = new ConsoleGraphics();

                StartButton start = new StartButton(graphics, graphics.ClientWidth / 2 - 100, graphics.ClientHeight / 2 - 150);
                ExitButton exit = new ExitButton(graphics, graphics.ClientWidth / 2 - 95, graphics.ClientHeight / 2);

                while (exit.PushExit() == false)
                {
                    start.Render(graphics);
                    exit.Render(graphics);

                    if (start.PushStart() == true || exit.pushExit == true)
                    {
                        break;
                    }

                    graphics.FlipPages();
                    System.Threading.Thread.Sleep(10);
                }

                if (exit.pushExit == true)
                {
                    break;
                }

                Level level = new Level();
                level.Level_1(graphics);
            }
        }
    }
}
