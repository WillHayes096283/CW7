/*
 * @file: BorderDecorator.cs
 * @author: William Hayes
 * @date: 2/15/2023
 * @brief: A decorator file, calls draw() for parent.
 * 
 * This is the BorderDecorator file, it calls draw() for its
 * parent before printing its own name to console.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w)
        {
        }

        public override void draw()
        {
            base.draw();
            Console.WriteLine("Border Decorator");
        }
    }
}
