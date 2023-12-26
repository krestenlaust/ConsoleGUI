using UI.Input;
using System.Collections.Generic;

namespace UI
{
    public interface IInputHandler
    {
        ICollection<IPollDevice> PollDevices { get; }

        void AddPollDevice(IPollDevice device);
    }
}
