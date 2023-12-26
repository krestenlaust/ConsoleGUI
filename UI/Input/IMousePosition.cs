namespace UI.Input
{
    /// <summary>
    /// Represents a mouse device, that provides coordinates of the cursors current location in relation to the window.
    /// </summary>
    public interface IMousePosition
    {
        /// <summary>
        /// The X position of the mouse cursor, in rendered units, from the top-left corner of the window.
        /// </summary>
        int X { get; }

        /// <summary>
        /// The Y position of the mouse cursor, in rendered units, from the top-left corner of the window.
        /// </summary>
        int Y { get; }
    }
}
