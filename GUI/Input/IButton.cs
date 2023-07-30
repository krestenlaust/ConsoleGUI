namespace GUI.Input
{
    /// <summary>
    /// Represents a mouse device, which provides button states.
    /// </summary>
    public interface IButton<in T>
    {
        bool ButtonDown(T button);

        bool ButtonPressed(T button);

        bool ButtonReleased(T button);
    }
}
