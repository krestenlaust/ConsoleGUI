namespace GUI.Console
{
    public abstract class ConsoleControl : Control
    {
        public abstract void Render(RectangleSegment<char> writeable);
    }
}
