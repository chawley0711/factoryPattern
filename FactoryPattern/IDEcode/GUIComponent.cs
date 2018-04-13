using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEcode
{
    public class GUIComponent
    {
        private int left;
        private int top;
        private int width;
        private int height;

        public void initialize(int l, int t, int w, int h)
        {
            this.left = l;
            this.top = t;
            this.width = w;
            this.height = h;
        }
    }
}
