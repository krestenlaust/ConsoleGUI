namespace GUI.Console
{
    /// <summary>
    /// Takes care of translating GUI controls into text-based representations, to be displayed in the console window.
    /// </summary>
    public class ConsoleRenderer : IRenderer<ConsoleControl>
    {
        readonly IConsole console;
        char[] screen;
        int screenWidth;

        public ConsoleRenderer(IConsole console)
        {
            this.console = console;
        }

        public void RenderScreen()
        {
            screen = new char[console.ScreenWidth * console.ScreenHeight];
            screenWidth = console.ScreenWidth;
        }

        void DrawControl(ConsoleControl control)
        {
            var writeableArea = new RectangleSegment<char>(screen, screenWidth, control.Position.X, control.Position.Y, control.Size.Width, control.Size.Height);
            control.Render(writeableArea);
        }
    }
}
