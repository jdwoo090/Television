using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVProject
{
    public class myTV : ITVInterface
    {
        int m_volume;
        int m_channel;
        int m_previous;
        Boolean tvOn;

        public int ChannelDown()
        {
            if (tvOn == true)
            {
                m_previous = m_channel;
                return m_channel--;
            }

            return 0;
        }

        public int getChannel()
        {
            return m_channel;
        }

        public int ChannelUp()
        {
            if (tvOn == true)
            {
                m_previous = m_channel;
                return m_channel++;
            }

            return 0;
        }

        public int mute()
        {
            if (tvOn == true)
            {
                m_channel = 0;

                return m_channel;
            }

            return 0;
        }

        public void Power()
        {
            if (tvOn == true)
            {
                tvOn = false;
                m_volume = 0;

            }

            tvOn = true;
        }

        public int Previous()
        {
            int channel;

            channel = m_channel;

            m_channel = m_previous;

            m_previous = channel;

            return m_channel;
        }

        public void SetChannel(int channel)
        {
            m_previous = m_channel;

            m_channel = channel;
        }

        public int VolumeDown()
        {
            if (tvOn == true)
            {
                return m_volume--;
            }

            return 0;
        }

        public int VolumeUp()
        {
            if (tvOn == true)
            {
                return m_volume++;
            }

            return 0;
        }
    }
}
