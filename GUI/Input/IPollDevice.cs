namespace GUI.Input
{
    /// <summary>
    /// Represents a class polling inputs for an input device.
    /// </summary>
    public interface IPollDevice
    {
        /// <summary>
        /// Refreshes all inputs when called.
        /// </summary>
        void Poll();
    }
}
