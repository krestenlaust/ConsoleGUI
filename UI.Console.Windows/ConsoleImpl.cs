using System;

namespace UI.Console.Windows
{
    public class ConsoleImpl : IConsole
    {
        public int BufferWidth => System.Console.BufferWidth;

        public int BufferHeight => System.Console.BufferHeight;

        public int ScreenWidth => System.Console.WindowWidth;

        public int ScreenHeight => System.Console.WindowHeight;

        public int ScreenTop { get => System.Console.WindowTop; set => System.Console.WindowTop = value; }
        public int ScreenLeft { get => System.Console.WindowLeft; set => System.Console.WindowLeft = value; }

        public void SetCursorPosition(int column, int row) => System.Console.SetCursorPosition(column, row);

        public void Write(string text)
        {
            throw new NotImplementedException();
        }
    }
}
