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
        public void PlayGame()
        {

            while (true)
            {

                ConsoleGraphics graphics = new ConsoleGraphics();
                Console.CursorVisible = false;

                Button start = new Button(graphics, 0, 0, 200, 50, graphics.ClientWidth / 2 - 100, graphics.ClientHeight / 2 - 150);
                Button exit = new Button(graphics, 200, 270, 190, 50, graphics.ClientWidth / 2 - 95, graphics.ClientHeight / 2);

                while (!exit.Push())
                {
                    start.Render(graphics);
                    exit.Render(graphics);

                    if (start.Push() == true || exit.Push() == true)
                    {
                        break;
                    }

                    graphics.FlipPages();
                    System.Threading.Thread.Sleep(10);
                }

                if (exit.Push() == true)
                {
                    break;
                }

                Level level = new Level();
                level.Level_1(graphics);
            }
        }
    }
}
