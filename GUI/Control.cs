using System.Collections.Generic;

namespace GUI
{
    public abstract class Control
    {
        readonly ICollection<Control> children;

        public Control(params Control[] children)
        {
            this.children = children;
        }

        public Control AddControl(Control element)
        {
            children.Add(element);

            return element;
        }
    }
}
