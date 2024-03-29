﻿using System;
using System.Threading;
using ConsoleStars;
using ConstoleStars;

namespace stars
{
     class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var stars = new Star[]
            {
                new Star(random),
                new Star(random),
                new Star(random),
                new Star(random),
                new Star(random),
                new Star(random),
                new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),
                new MovableStar(random),
            };
            while (true)
            {
                Console.Clear();
                foreach (var star in stars)
                {
                    star.Show();
                    star.Update();
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Thread.Sleep(200);
            }
        }
    }
}
