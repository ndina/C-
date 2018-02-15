﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        public int x, y;
        public Food()
        {
            SetRandomPos();
        }
        public Food(int x, int y)
        {
            this.x = x;
            this.y = y;
          
        }
        public void SetRandomPos()
        {
            x = new Random().Next(1, Console.WindowWidth);
            y = new Random().Next(1, Console.WindowHeight);
        }
        public bool foodonwall(Wall w)
        {
            foreach(Point p in w.body)
            {
                if (p.x == x && p.y == y)
                    return false;
            }
            return true;
        }

        public bool foononsnake(Snake s)
        {
            foreach(Point p in s.body)
            {
                if (p.x == x && p.y == y)
                    return false;
            }
            return true;
        }
        public void ShowFood()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("$");
        }
    }
}
