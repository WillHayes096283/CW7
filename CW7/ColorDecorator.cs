/*
 * @file: ColorDecorator.cs
 * @author: William Hayes
 * @date: 2/15/2023
 * @brief: Newly added decorator
 * 
 * This file is a decorator that calls it's
 * parent's draw() before printing it's name to
 * console.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    public class ColorDecorator : Decorator
    {
        
        public ColorDecorator(Widget w) : base(w)
        {
        }

        public override void draw()
        {
            base.draw();
            Console.WriteLine("Color Decorator");
        }

    }
}
