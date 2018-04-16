using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEcode
{
    public class Button : GUIComponent
    {
        private string text;
        private int fontsize;

        public Button(string text, int fontsize)
        {
            this.text = text;
            this.fontsize = fontsize;
        }
    }
}
