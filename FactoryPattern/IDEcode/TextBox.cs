using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEcode
{
    public class TextBox : GUIComponent
    {
        private string defaultText;

        public TextBox(string t)
        {
            this.defaultText = t;
        }
    }
}
