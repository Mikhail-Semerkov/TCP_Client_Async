using System;
using System.Windows.Forms;
using TCP_Asynchronous_Client;

namespace TCP_Client
{
    public partial class Form1 : Form
    {

        public delegate void AddLogDeligate(string data);
        public AddLogDeligate AddLog;
        public delegate void AddNotificationDelegate(int type, bool status);
        public AddNotificationDelegate UpdateStatusIcons;

        AsynchronousClient tcp;

        public Form1()
        {
            InitializeComponent();

            AddLog = new AddLogDeligate(Log);
            UpdateStatusIcons = new AddNotificationDelegate(StatusUpdate);

            StatusUpdate(1, false);

        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                tcp = new AsynchronousClient(textBox_ip.Text, int.Parse(textBox_port.Text));
                tcp.OnConnectEvent += new AsynchronousClient.OnConnectEventHandler(OnConnect);
                tcp.OnDataRecievedEvent += new AsynchronousClient.DataReceivedEventHandler(OnRecieved);
                tcp.Connect();
            }
            catch (Exception ex)
            {

                Log("Error : " + ex.ToString());
            }
        }

        private void OnConnect(bool status)
        {
            textBox_log.Invoke(AddLog, "Connection : " + status.ToString());
            label_status_connected.Invoke(UpdateStatusIcons, 1, status);
        }

        private void OnRecieved(string data)
        {
            label_rx.Invoke(UpdateStatusIcons, 3, true);
            textBox_log.Invoke(AddLog, "Recieved : " + data);
        }

        public void StatusUpdate(int type, bool status)
        {
            switch (type)
            {
                case 1:
                    if (status)
                    {
                        label_status_connected.Text = "Connected";
                        label_status_connected.BackColor = System.Drawing.Color.DarkGreen;
                        button_connect.Enabled = false;
                        button_disconnect.Enabled = true;
                        button_send.Enabled = true;
                    }
                    else
                    {
                        label_status_connected.Text = "Disconnected";
                        label_status_connected.BackColor = System.Drawing.Color.DarkRed;
                        button_connect.Enabled = true;
                        button_disconnect.Enabled = false;
                        button_send.Enabled = false;
                    }
                    break;

                case 2:
                    if (status)
                    {
                        label_tx.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        label_tx.ForeColor = System.Drawing.Color.DarkGray;
                    }
                    break;

                case 3:
                    if (status)
                    {
                       label_rx.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        label_rx.ForeColor = System.Drawing.Color.DarkGray;
                    }
                    break;

                default:
                    break;
            }
        }

        private void Log(string _data)
        {
            textBox_log.Text = textBox_log.Text + _data + "\n\n";
            textBox_log.SelectionStart = textBox_log.Text.Length;
            textBox_log.ScrollToCaret();
        }


        private void button_disconnect_Click(object sender, EventArgs e)
        {
            tcp.Disconnect();
        }

        private void button_send_Click_1(object sender, EventArgs e)
        {
            StatusUpdate(2, true);

            try
            {
                if (tcp.Write(textBox_send.Text))
                {
                    Log("Write (Success) : " + textBox_send.Text);
            
                }
                else
                {
                    Log("Write (Failed) : Disconnected");
                }
            }
            catch (Exception ex)
            {
                Log("Error : " + ex.ToString());
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_log.Clear();
        }

        private void timer_notifications_Tick(object sender, EventArgs e)
        {
            label_tx.ForeColor = System.Drawing.Color.DarkGray;
            label_rx.ForeColor = System.Drawing.Color.DarkGray;
        }
    }

}

