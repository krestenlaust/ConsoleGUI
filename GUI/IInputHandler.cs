using GUI.Input;
using System.Collections.Generic;

namespace GUI
{
    public interface IInputHandler
    {
        ICollection<IPollDevice> PollDevices { get; }

        void AddPollDevice(IPollDevice device);
    }
}
