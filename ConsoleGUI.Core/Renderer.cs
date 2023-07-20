using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleGUI.Core
{
    public class Renderer
    {
        readonly IConsole console;

        public Renderer(IConsole console)
        {
            this.console = console;
        }
    }
}
