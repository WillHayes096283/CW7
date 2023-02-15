/*
 * @file: TextField.cs
 * @author: William Hayes
 * @date: 2/15/2023
 * @brief: Concrete Component File
 * 
 * This file acts as the Concrete Component file.
 * it implements the draw() method to print to console the
 * width and height values entered in it's constructor.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW7
{
    public class TextField : Widget
    {
        int height;
        int width;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        public void draw()
        {
            Console.WriteLine("TextField: " + width + ", " + height);
        }
    }
}
