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

        /// <summary>
        /// The size of the control in screen-units.
        /// </summary>
        public Size Size { get; set; }
        
        /// <summary>
        /// The position of the control in screen-units.
        /// </summary>
        public Vector Position { get; set; }

        // TODO: Reconsider this.
        public Control AddControl(Control element)
        {
            children.Add(element);

            return element;
        }
    }
}
