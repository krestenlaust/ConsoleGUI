using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGUI.Core
{
    public abstract class UIControl
    {
        ICollection<UIControl> Children = new List<UIControl>();

        public UIControl AddUIElement(UIControl element)
        {
            Children.Add(element);

            return this;
        }
    }
}
