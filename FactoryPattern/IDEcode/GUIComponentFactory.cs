using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDEcode
{
     abstract public class GUIComponentFactory
     {
        abstract public TextBox createTextBox();
        abstract public Dropdown createDropdown();
     }
}
