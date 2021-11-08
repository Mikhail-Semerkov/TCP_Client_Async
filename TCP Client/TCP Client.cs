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
            label_status.Invoke(UpdateStatusIcons, 1, status);
        }


        private void OnRecieved(string data)
        {
            lblRead.Invoke(UpdateStatusIcons, 3, true);
            textBox_log.Invoke(AddLog, "Recieved : " + data);
        }

        private void StatusUpdate(int type, bool status)
        {
            switch (type)
            {
                case 1:
                    if (status)
                    {
                        label_status.Text = "Connected";
                        label_status.BackColor = System.Drawing.Color.Green;
                        button_connect.Enabled = false;
                        button_disconnect.Enabled = true;
                        button_send.Enabled = true;
                    }
                    else
                    {
                        label_status.Text = "Disconnected";
                        label_status.BackColor = System.Drawing.Color.Red;
                        button_connect.Enabled = true;
                        button_disconnect.Enabled = false;
                        button_send.Enabled = false;
                    }
                    break;

                case 2:
                    if (status)
                    {
                       lblWrite.Visible = true;
                    }
                    else
                    {
                       lblWrite.Visible = false;
                    }
                    break;

                case 3:
                    if (status)
                    {
                       lblRead.Visible = true;
                    }
                    else
                    {
                      lblRead.Visible = false;
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


        private void timClear_Tick(object sender, EventArgs e)
        {
            lblWrite.Visible = false;
            lblRead.Visible = false;
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
    }

}

