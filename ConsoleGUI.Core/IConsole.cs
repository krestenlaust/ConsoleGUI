namespace ConsoleGUI.Core
{
    public interface IConsole
    {
        int BufferWidth { get; }
        int BufferHeight { get; }

        int ScreenWidth { get; }
        int ScreenHeight { get; }
        int ScreenTop { get; set; }
        int ScreenLeft { get; set; }

        void SetCursorPosition(int left, int top);
    }
}
