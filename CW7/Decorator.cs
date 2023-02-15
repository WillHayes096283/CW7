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
