/*
 * @file: ScrollDecorator.cs
 * @author: William Hayes
 * @date: 2/15/2023
 * @brief: A decorator file, calls draw() for parent.
 * 
 * This is the ScrollDecorator file, it calls draw() for its
 * parent before printing its own name to console.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {
        }

        public override void draw()
        {
            base.draw();
            Console.WriteLine("Scroll Decorator");
        }
    }
}
