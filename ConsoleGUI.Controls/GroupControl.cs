using ConsoleGUI.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGUI.Controls
{
    public class GroupControl : UIControl
    {

        public GroupControl(params UIControl[] children)
            : base(children)
        {
        }
    }
}
