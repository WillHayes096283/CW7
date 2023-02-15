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
