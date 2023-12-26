using UI.Input;
using System.Collections.Generic;

namespace UI.Handler
{
    /// <summary>
    /// Keeps track of inputs and polls them for inputs.
    /// </summary>
    public class InputHandler : IInputHandler, IHandler
    {
        public void Update()
        {
            foreach (var item in PollDevices)
            {
                item.Poll();
            }
        }

        public ICollection<IPollDevice> PollDevices { get; } = new List<IPollDevice>();

        public void AddPollDevice(IPollDevice device) => PollDevices.Add(device);
    }
}
