using System;
using System.Collections.Generic;
using System.Text;

namespace GUI.Console
{
    /// <summary>
    /// Takes care of translating GUI controls into text-based representations, to be displayed in the console window.
    /// </summary>
    public class ConsoleRenderer : IRenderer
    {
        readonly IConsole console;

        public ConsoleRenderer(IConsole console)
        {
            this.console = console;
        }
    }
}
