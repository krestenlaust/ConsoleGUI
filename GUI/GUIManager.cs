using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    /// <summary>
    /// Central manager for the GUI library. Handles controls, event handling and overall GUI control management.
    /// </summary>
    public class GUIManager
    {
        public ICollection<Window> Windows { get; } = new List<Window>();

        public Window AddWindow(Window window)
        {
            Windows.Add(window);

            return window;
        }
    }
}
