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
