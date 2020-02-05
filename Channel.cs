using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVProject
{
    public partial class Channel : Form
    {
        ITVInterface m_tv;

        public Channel(ITVInterface tv)
        {
            m_tv = tv;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int channel = int.Parse(textBox1.Text);

            m_tv.SetChannel(channel);

            this.Close();
        }
    }
}
