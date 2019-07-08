using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    class Level
    {

        public void Level_1(ConsoleGraphics graphics)
        {

            Field field = new Field(0xFFFFFF00, 0, 0, graphics.ClientWidth, graphics.ClientHeight);
            Bat bat = new Bat(graphics, 100, 600, 130, 30);
            Ball ball = new Ball(graphics, 20, 300, 20, 20);

            Target[] targets = new Target[20];

            for (int i = 0; i < targets.Length; i++)
            {

                if (i % 2 == 0)
                    targets[i] = new Target(graphics, graphics.ClientWidth * (i+1) / targets.Length - 32, 50, 32 , 32);

                else
                    targets[i] = new Target(graphics, graphics.ClientWidth * (i+1) / targets.Length - 32, 25, 32, 32);
            }

            while (ball.speedX != 0 && ball.count < targets.Length * 10)
            {

                field.RenderField(graphics);

                bat.Render(graphics);
                bat.UpdateBat(graphics);

                ball.Render(graphics);
                ball.ToBeatOfTheField(field);
                ball.ToBeatOfTheBat(bat);

                for (int i = 0; i < targets.Length; i++)
                {

                    targets[i].Render(graphics);
                    ball.ToBeatOfTheTargets(targets[i]);
                }

                graphics.FlipPages();
                System.Threading.Thread.Sleep(10);
            }

            Console.Clear();
            Console.WriteLine($"Your Score is {ball.count} points");
        }
    }
}
