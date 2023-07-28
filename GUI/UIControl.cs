using System.Collections.Generic;

namespace GUI
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
