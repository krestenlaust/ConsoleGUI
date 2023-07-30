using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    /// <summary>
    /// TODO: Turn into interface, to allow custom implementation of window.
    /// </summary>
    public class Window
    {
        public Window()
        {
        }

        public Control FocusControl { get; }

        public ICollection<Control> Controls { get; } = new List<Control>();

        public Control AddControl(Control control)
        {
            Controls.Add(control);

            return control;
        }
    }
}
