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
    public partial class tvForm : Form
    {
        ITVInterface tv = new myTV();
        Boolean on;
        Boolean set = false;

        int[] setSet = new int[4];
        int setCount = 0;

        int currentChannel;

        public tvForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            set = false;

            if (button1.Text == "Turn On")
            {
                pictureBox1.Visible = true;
                on = true;

                tv.Power();

                button1.Text = "Turn Off";
            }
            else
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;

                on = false;

                tv.Power();

                button1.Text = "Turn On";

                tv.mute();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (on == true)
            {
                tv.VolumeUp();

                label1.Text = "Volume: " + tv.VolumeUp().ToString();
                label1.Visible = true;

                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible = false;

            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (on == true)
            {
                tv.VolumeDown();

                label1.Text = "Volume: " + tv.VolumeDown().ToString();
                label1.Visible = true;

                timer1.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (on == true)
            {
                tv.mute();

                label1.Text = "Volume: " + tv.mute().ToString();
                label1.Visible = true;

                timer1.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (on == true)
            {
                Channel f = new Channel(tv);

                f.ShowDialog();
            }

            if (on == true && tv.getChannel() > 0)
            {
                label2.Text = "Channel: " + tv.getChannel().ToString();
                label2.Visible = true;

                setCount++;

                set = true;

                currentChannel = tv.getChannel();

                timer2.Enabled = true;
            }

            if (setCount == 1)
            {
                setSet[0] = currentChannel;
            }

            if (setCount == 2)
            {
                setSet[1] = currentChannel;
            }

            if (setCount == 3)
            {
                setSet[2] = currentChannel;
            }

            if (setCount == 4)
            {
                setSet[3] = currentChannel;
            }

            if (setCount == 5)
            {
                setSet[4] = currentChannel;
            }

            if (tv.getChannel() == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;

                MessageBox.Show("Sorry, this is the highest channel!", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tv.getChannel() > 5)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                MessageBox.Show("Channel 5 is the max, this channel doesn't exist", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            set = false;

            if (on == true && tv.getChannel() > 0)
            {
                tv.ChannelUp();

                currentChannel++;

                label2.Text = "Channel: " + tv.getChannel().ToString();

                label2.Visible = true;

                timer2.Enabled = true;
            }
            if (on == true && tv.getChannel() <= 0)
            {
                tv.ChannelUp();
                currentChannel++;
            }

            if (tv.getChannel() == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;

                MessageBox.Show("Sorry, this is the highest channel!", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tv.getChannel() > 5)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                MessageBox.Show("Channel 5 is the max, this channel doesn't exist", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            set = false;

            if (on == true && tv.getChannel() != 1)
            {
                tv.ChannelDown();

                currentChannel--;

                label2.Text = "Channel: " + tv.getChannel().ToString();
                label2.Visible = true;

                timer2.Enabled = true;
            }

            if (tv.getChannel() == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;

                MessageBox.Show("Sorry, this is the highest channel!", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tv.getChannel() > 5)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                MessageBox.Show("Channel 5 is the max, this channel doesn't exist", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;

            timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            currentChannel = tv.getChannel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            /*if (on == true)
            {
                if (set == false)
                {
                    if (currentChannel - 1 != 0)
                    {
                        tv.SetChannel(currentChannel - 1);

                        if (tv.getChannel() == 1)
                        {
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = true;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                        }
                        if (tv.getChannel() == 2)
                        {
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = true;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                        }
                        if (tv.getChannel() == 3)
                        {
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = true;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;
                        }
                        if (tv.getChannel() == 4)
                        {
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = true;
                            pictureBox6.Visible = false;
                        }
                        if (tv.getChannel() == 5)
                        {
                            pictureBox1.Visible = false;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = true;

                            MessageBox.Show("Sorry, this is the highest channel!", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (tv.getChannel() > 5)
                        {
                            pictureBox1.Visible = true;
                            pictureBox2.Visible = false;
                            pictureBox3.Visible = false;
                            pictureBox4.Visible = false;
                            pictureBox5.Visible = false;
                            pictureBox6.Visible = false;

                            MessageBox.Show("Channel 5 is the max, this channel doesn't exist", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tv.SetChannel(currentChannel -1);

                            if (tv.getChannel() == 1)
                            {
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = true;
                                pictureBox3.Visible = false;
                                pictureBox4.Visible = false;
                                pictureBox5.Visible = false;
                                pictureBox6.Visible = false;
                            }
                            if (tv.getChannel() == 2)
                            {
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = true;
                                pictureBox4.Visible = false;
                                pictureBox5.Visible = false;
                                pictureBox6.Visible = false;
                            }
                            if (tv.getChannel() == 3)
                            {
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox4.Visible = true;
                                pictureBox5.Visible = false;
                                pictureBox6.Visible = false;
                            }
                            if (tv.getChannel() == 4)
                            {
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox4.Visible = false;
                                pictureBox5.Visible = true;
                                pictureBox6.Visible = false;
                            }
                            if (tv.getChannel() == 5)
                            {
                                pictureBox1.Visible = false;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox4.Visible = false;
                                pictureBox5.Visible = false;
                                pictureBox6.Visible = true;

                                MessageBox.Show("Sorry, this is the highest channel!", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            if (tv.getChannel() > 5)
                            {
                                pictureBox1.Visible = true;
                                pictureBox2.Visible = false;
                                pictureBox3.Visible = false;
                                pictureBox4.Visible = false;
                                pictureBox5.Visible = false;
                                pictureBox6.Visible = false;

                                MessageBox.Show("Channel 5 is the max, this channel doesn't exist", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            if (set == true)
            {
                tv.SetChannel(currentChannel = setSet[setCount - 1]);
            }*/

            tv.Previous();

            if (tv.getChannel() == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
            }
            if (tv.getChannel() == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;

                MessageBox.Show("Sorry, this is the highest channel!", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tv.getChannel() > 5)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;

                MessageBox.Show("Channel 5 is the max, this channel doesn't exist", "Maximum Channel Reached", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
    }
}
