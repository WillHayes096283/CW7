/*
 * @file: Decorator.cs
 * @author: William Hayes
 * @date: 2/15/2023
 * @brief: The Abstract Decorator file.
 * 
 * This file is the abstract Decorator file
 * that all concrete decorators will rely on.
 * Allows concrete decorators to call parent
 * methods.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    public abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget w)
        {
            wid = w;
        }

        public virtual void draw()
        {
            wid.draw();
        }
    }
}
