/*
 * @file: DecoratorDemo.cs
 * @author: William hayes
 * @date: 2/15/2023
 * @brief: Main program file
 * 
 * This file is the program's Main file. It creates a TextField object
 * before layering different decorators onto it. The program then calls
 * draw() on the top decorator.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    internal class DecoratorDemo
    {
        static void Main(string[] args)
        {
            var text = new TextField(60, 120);

            ScrollDecorator Scroller = new ScrollDecorator(text);

            BorderDecorator Border = new BorderDecorator(Scroller);

            ColorDecorator Color = new ColorDecorator(Border);

            Color.draw();

            Console.ReadKey();
        }
    }
}
