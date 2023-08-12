using System.Collections.Generic;

namespace GUI
{
    public abstract class Control
    {
        public Control(params Control[] children)
        {
            this.Children = children;
        }

        /// <summary>
        /// Gets a collection containing all controls situated within this control.
        /// </summary>
        public ICollection<Control> Children { get; }

        /// <summary>
        /// Gets the size of the control in screen-units.
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// Gets the position of the control in screen-units.
        /// </summary>
        public Vector Position { get; set; }

        // TODO: Reconsider this.
        public Control AddControl(Control element)
        {
            Children.Add(element);

            return element;
        }
    }
}
