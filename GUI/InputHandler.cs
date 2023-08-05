using GUI.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace GUI
{
    /// <summary>
    /// Keeps track of inputs and polls them for inputs.
    /// </summary>
    public class InputHandler : IHandler
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
