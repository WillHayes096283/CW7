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
