using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGUI.Core
{
    public abstract class UIControl
    {
        readonly ICollection<UIControl> children;

        public UIControl(params UIControl[] children)
        {
            this.children = children;
        }

        public UIControl AddControl(UIControl element)
        {
            children.Add(element);

            return element;
        }
    }
}
