using System;
using System.Collections.Generic;
using ConsoleGUI.Core;
using ConsoleInput;

namespace ConsoleGUI
{
    public class ConsoleImpl : IConsole
    {
        public int BufferWidth => Console.BufferWidth;

        public int BufferHeight => Console.BufferHeight;

        public int ScreenWidth => Console.WindowWidth;

        public int ScreenHeight => Console.WindowHeight;

        public void SetCursorPosition(int column, int row) => Console.SetCursorPosition(column, row);
    }
}
