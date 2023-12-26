using System.Collections.Generic;

namespace UI
{
    /// <summary>
    /// TODO: Maybe turn into interface, to allow custom implementation of window.
    /// </summary>
    public class Window
    {
        public Window()
        {
        }

        public Control FocusControl { get; set; }

        public ICollection<Control> Controls { get; } = new List<Control>();

        public Control AddControl(Control control)
        {
            Controls.Add(control);

            return control;
        }
    }
}
