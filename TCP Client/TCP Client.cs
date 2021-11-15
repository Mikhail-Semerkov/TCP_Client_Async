using System;
using System.Text;
using System.Diagnostics;
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


        String Value_Hex_1;
        String Value_Hex_2;
        String Value_Hex_3;

        

        public Form1()
        {
            InitializeComponent();

            AddLog = new AddLogDeligate(Log);
            UpdateStatusIcons = new AddNotificationDelegate(StatusUpdate);

            StatusUpdate(1, false);

        }

        public static string ToHexString(string str)
        {
            string decString = str;
            byte[] bytes = Encoding.Default.GetBytes(decString);
            string hexString = BitConverter.ToString(bytes);
            hexString = hexString.Replace("-", "");

            return hexString;

        }

        public static string FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return Encoding.Unicode.GetString(bytes); // returns: "Hello world" for "48656C6C6F20776F726C64"
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
                        button_send_1.Enabled = true;
                        button_send_2.Enabled = true;
                        button_send_3.Enabled = true;
                    }
                    else
                    {
                        label_status_connected.Text = "Disconnected";
                        label_status_connected.BackColor = System.Drawing.Color.DarkRed;
                        button_connect.Enabled = true;
                        button_disconnect.Enabled = false;
                        button_send_1.Enabled = false;
                        button_send_2.Enabled = false;
                        button_send_3.Enabled = false;
                    }
                    break;

                case 2:
                    if (status)
                    {
                        label_tx.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        label_tx.ForeColor = System.Drawing.Color.DimGray;
                    }
                    break;

                case 3:
                    if (status)
                    {
                       label_rx.ForeColor = System.Drawing.Color.White;
                    }
                    else
                    {
                        label_rx.ForeColor = System.Drawing.Color.DimGray;
                    }
                    break;

                default:
                    break;
            }
        }

        private void Log(string _data)
        {

            textBox_log.AppendText(_data + "\r\n");
            //textBox_log.Text = textBox_log.Text + _data + "\n\n";
            //textBox_log.SelectionStart = textBox_log.Text.Length;
            //textBox_log.ScrollToCaret();
        }


        private void button_disconnect_Click(object sender, EventArgs e)
        {
            tcp.Disconnect();
        }


        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_log.Clear();
        }

        private void timer_notifications_Tick(object sender, EventArgs e)
        {
            label_tx.ForeColor = System.Drawing.Color.DimGray;
            label_rx.ForeColor = System.Drawing.Color.DimGray;
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Mikhail-Semerkov/TCP_Client_Async/");
        }


        public void send_data(int Send_Data)
        {

            StatusUpdate(2, true);

            try
            {
                switch (Send_Data)
                {
                    case 1:
                        if (tcp.Write((textBox_send_1.Text)))
                        {
                            Log("Write (Success) : " + textBox_send_1.Text + "\n");
                        }
                        else
                        {
                            Log("Write (Failed) : Disconnected");
                        }
                        break;


                    case 2:
                        if (tcp.Write(textBox_send_2.Text))
                        {
                            Log("Write (Success) : " + textBox_send_2.Text + "\n");
                        }
                        else
                        {
                            Log("Write (Failed) : Disconnected");
                        }
                        break;


                    case 3:
                        if (tcp.Write(textBox_send_3.Text))
                        {
                            Log("Write (Success) : " + textBox_send_3.Text + "\n");
                        }
                        else
                        {
                            Log("Write (Failed) : Disconnected");
                        }
                        break;

                    case 4:
                        if (tcp.Write(Value_Hex_1))
                        {
                            Log("Write (Success) : " + Value_Hex_1);
                        }
                        else
                        {
                            Log("Write (Failed) : Disconnected");
                        }
                        break;

                    case 5:
                        if (tcp.Write(Value_Hex_2))
                        {
                            Log("Write (Success) : " + Value_Hex_2);
                        }
                        else
                        {
                            Log("Write (Failed) : Disconnected");
                        }
                        break;

                    case 6:
                        if (tcp.Write(Value_Hex_3))
                        {
                            Log("Write (Success) : " + Value_Hex_3);
                        }
                        else
                        {
                            Log("Write (Failed) : Disconnected");
                        }
                        break;
                }

            }
            catch (Exception ex)
            {
                Log("Error : " + ex.ToString());
            }
        }







        private void button_send_1_Click(object sender, EventArgs e)
        {

            if(checkBox_hex_1.Checked == true)
            {
                Value_Hex_1 = ToHexString(textBox_send_1.Text);
                send_data(4);
            }

            else if (checkBox_hex_1.Checked == false)
            {
                send_data(1);
            }

        }

        private void button_send_2_Click(object sender, EventArgs e)
        {
            if (checkBox_hex_2.Checked == true)
            {
                Value_Hex_2 = ToHexString(textBox_send_2.Text);
                send_data(5);
            }

            else if (checkBox_hex_2.Checked == false)
            {
                send_data(2);
            }
        }

        private void button_send_3_Click(object sender, EventArgs e)
        {
            if (checkBox_hex_3.Checked == true)
            {
                Value_Hex_3 = ToHexString(textBox_send_3.Text);
                send_data(6);
            }

            else if (checkBox_hex_3.Checked == false)
            {
                send_data(3);
            }
        }
    }
    

}

