using System;
using GUI.Console;

namespace ConsoleGUI
{
    public class ConsoleImpl : IConsole
    {
        public int BufferWidth => Console.BufferWidth;

        public int BufferHeight => Console.BufferHeight;

        public int ScreenWidth => Console.WindowWidth;

        public int ScreenHeight => Console.WindowHeight;

        public int ScreenTop { get => Console.WindowTop; set => Console.WindowTop = value; }
        public int ScreenLeft { get => Console.WindowLeft; set => Console.WindowLeft = value; }

        public void SetCursorPosition(int column, int row) => Console.SetCursorPosition(column, row);
    }
}
