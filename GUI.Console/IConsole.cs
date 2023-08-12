namespace GUI.Console
{
    public interface IConsole
    {
        /// <summary>
        /// Gets the width of the buffer area measured in columns.
        /// </summary>
        int BufferWidth { get; }

        /// <summary>
        /// Gets the height of the buffer area measured in rows.
        /// </summary>
        int BufferHeight { get; }

        /// <summary>
        /// Gets the width of the window measured in columns.
        /// </summary>
        int ScreenWidth { get; }

        /// <summary>
        /// Gets the height of the window measured in rows.
        /// </summary>
        int ScreenHeight { get; }

        /// <summary>
        /// Gets the uppermost console window position measured in rows.
        /// </summary>
        int ScreenTop { get; set; }

        /// <summary>
        /// Gets the leftmost console window position measured in columns.
        /// </summary>
        int ScreenLeft { get; set; }

        /// <summary>
        /// Sets the cursor position in the console buffer.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        void SetCursorPosition(int left, int top);

        /// <summary>
        /// Writes text at the location the cursor is currently at.
        /// </summary>
        /// <param name="text"></param>
        void Write(string text);
    }
}
