﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace Arkanoid1
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();

            game.PlayGame();

            Console.Clear();
        }
    }
}
