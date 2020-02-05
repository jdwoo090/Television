using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVProject
{
    public interface ITVInterface
    {
        void Power();

        int VolumeUp();

        int VolumeDown();

        int ChannelUp();

        int ChannelDown();

        int Previous();

        int mute();

        void SetChannel(int channel);

        int getChannel();
    }
}
