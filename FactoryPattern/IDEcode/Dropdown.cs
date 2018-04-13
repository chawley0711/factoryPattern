using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEcode
{
    public class Dropdown : GUIComponent
    {
        private List<string> contents;

        public Dropdown(List<string> c)
        {
            this.contents = c;
        }
    }
}
