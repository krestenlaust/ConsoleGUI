using System.Collections.Generic;

namespace GUI
{
    /// <summary>
    /// Central manager for the GUI library. Handles all UI-related calculations and events. E.g. input events, and ...
    /// </summary>
    public class GUIManager
    {
        readonly IRenderer renderer;
        readonly IInputHandler inputHandler;

        public GUIManager(IRenderer renderer, IInputHandler inputHandler)
        {
            this.renderer = renderer;
            this.inputHandler = inputHandler;
        }

        /// <summary>
        /// Framerate expressed in hertz.
        /// </summary>
        public int FramerateHz { get; set; }

        /// <summary>
        /// Main update loop.
        /// </summary>
        /// <remarks>
        /// Order of updates expressed:
        /// - Poll input
        /// - Perform input calculations and mark clicked-controls and store input in control (either that, or trigger events immediately)
        /// - Perform main update and trigger potential events (if events end up being used)
        /// - Perform rendering
        /// - Wait for next frame
        /// Notes:
        /// I don't think it is going to be easy to make a separate rendering thread.
        /// </remarks>
        public void Update()
        {

        }

        public ICollection<Window> Windows { get; } = new List<Window>();

        public Window AddWindow(Window window)
        {
            Windows.Add(window);

            return window;
        }
    }
}
