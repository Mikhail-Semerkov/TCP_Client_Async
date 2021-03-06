
namespace TCP_Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_left = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_ip = new System.Windows.Forms.Panel();
            this.label_ip = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.panel_label = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_status_connected = new System.Windows.Forms.Label();
            this.label_name_programs = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.panel_connect = new System.Windows.Forms.Panel();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_rx = new System.Windows.Forms.Label();
            this.label_tx = new System.Windows.Forms.Label();
            this.panel_log_data = new System.Windows.Forms.Panel();
            this.checkBox_hex_3 = new System.Windows.Forms.CheckBox();
            this.checkBox_hex_2 = new System.Windows.Forms.CheckBox();
            this.checkBox_hex_1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send_3 = new System.Windows.Forms.Button();
            this.textBox_send_3 = new System.Windows.Forms.TextBox();
            this.button_send_2 = new System.Windows.Forms.Button();
            this.textBox_send_2 = new System.Windows.Forms.TextBox();
            this.button_send_1 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_send_1 = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label_log = new System.Windows.Forms.Label();
            this.timer_notifications = new System.Windows.Forms.Timer(this.components);
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_ip.SuspendLayout();
            this.panel_label.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_connect.SuspendLayout();
            this.panel_log_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Controls.Add(this.panel_ip);
            this.panel_left.Controls.Add(this.panel_label);
            this.panel_left.Controls.Add(this.panel1);
            this.panel_left.Controls.Add(this.panel_connect);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(232, 342);
            this.panel_left.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::TCP_Client.Properties.Resources.footer_logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.GitHub_Click);
            // 
            // panel_ip
            // 
            this.panel_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ip.Controls.Add(this.label_ip);
            this.panel_ip.Controls.Add(this.textBox_ip);
            this.panel_ip.Location = new System.Drawing.Point(12, 105);
            this.panel_ip.Name = "panel_ip";
            this.panel_ip.Size = new System.Drawing.Size(209, 60);
            this.panel_ip.TabIndex = 3;
            // 
            // label_ip
            // 
            this.label_ip.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ip.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_ip.Location = new System.Drawing.Point(-1, -1);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(209, 18);
            this.label_ip.TabIndex = 5;
            this.label_ip.Text = "IP";
            this.label_ip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ip.Location = new System.Drawing.Point(12, 20);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(185, 29);
            this.textBox_ip.TabIndex = 4;
            this.textBox_ip.Text = "192.168.184.199";
            this.textBox_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_label
            // 
            this.panel_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_label.Controls.Add(this.label1);
            this.panel_label.Controls.Add(this.label_status_connected);
            this.panel_label.Controls.Add(this.label_name_programs);
            this.panel_label.Location = new System.Drawing.Point(12, 12);
            this.panel_label.Name = "panel_label";
            this.panel_label.Size = new System.Drawing.Size(209, 70);
            this.panel_label.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "by M.Semerkov";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_status_connected
            // 
            this.label_status_connected.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status_connected.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_status_connected.Location = new System.Drawing.Point(25, 42);
            this.label_status_connected.Name = "label_status_connected";
            this.label_status_connected.Size = new System.Drawing.Size(161, 21);
            this.label_status_connected.TabIndex = 1;
            this.label_status_connected.Text = "Status";
            this.label_status_connected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name_programs
            // 
            this.label_name_programs.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_name_programs.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_programs.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_name_programs.Location = new System.Drawing.Point(0, 0);
            this.label_name_programs.Name = "label_name_programs";
            this.label_name_programs.Size = new System.Drawing.Size(207, 28);
            this.label_name_programs.TabIndex = 0;
            this.label_name_programs.Text = "TCP CLIENT";
            this.label_name_programs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_port);
            this.panel1.Controls.Add(this.textBox_port);
            this.panel1.Location = new System.Drawing.Point(12, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 60);
            this.panel1.TabIndex = 6;
            // 
            // label_port
            // 
            this.label_port.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_port.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_port.Location = new System.Drawing.Point(-1, -1);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(209, 19);
            this.label_port.TabIndex = 3;
            this.label_port.Text = "PORT";
            this.label_port.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_port
            // 
            this.textBox_port.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox_port.Location = new System.Drawing.Point(12, 24);
            this.textBox_port.Multiline = true;
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(185, 26);
            this.textBox_port.TabIndex = 4;
            this.textBox_port.Text = "4005";
            this.textBox_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_connect
            // 
            this.panel_connect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_connect.Controls.Add(this.button_disconnect);
            this.panel_connect.Controls.Add(this.button_connect);
            this.panel_connect.Location = new System.Drawing.Point(12, 237);
            this.panel_connect.Name = "panel_connect";
            this.panel_connect.Size = new System.Drawing.Size(209, 74);
            this.panel_connect.TabIndex = 6;
            // 
            // button_disconnect
            // 
            this.button_disconnect.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_disconnect.Location = new System.Drawing.Point(3, 39);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(201, 30);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.Text = "disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.Location = new System.Drawing.Point(3, 3);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(201, 30);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "connect server";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(42, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "/";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_rx
            // 
            this.label_rx.AutoSize = true;
            this.label_rx.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label_rx.ForeColor = System.Drawing.Color.DimGray;
            this.label_rx.Location = new System.Drawing.Point(52, 8);
            this.label_rx.Name = "label_rx";
            this.label_rx.Size = new System.Drawing.Size(32, 17);
            this.label_rx.TabIndex = 15;
            this.label_rx.Text = "RX";
            this.label_rx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_tx
            // 
            this.label_tx.AutoSize = true;
            this.label_tx.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label_tx.ForeColor = System.Drawing.Color.DimGray;
            this.label_tx.Location = new System.Drawing.Point(14, 8);
            this.label_tx.Name = "label_tx";
            this.label_tx.Size = new System.Drawing.Size(29, 17);
            this.label_tx.TabIndex = 14;
            this.label_tx.Text = "TX";
            this.label_tx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_log_data
            // 
            this.panel_log_data.Controls.Add(this.checkBox_hex_3);
            this.panel_log_data.Controls.Add(this.checkBox_hex_2);
            this.panel_log_data.Controls.Add(this.checkBox_hex_1);
            this.panel_log_data.Controls.Add(this.label8);
            this.panel_log_data.Controls.Add(this.label2);
            this.panel_log_data.Controls.Add(this.label5);
            this.panel_log_data.Controls.Add(this.label4);
            this.panel_log_data.Controls.Add(this.label_rx);
            this.panel_log_data.Controls.Add(this.label_tx);
            this.panel_log_data.Controls.Add(this.label3);
            this.panel_log_data.Controls.Add(this.button_send_3);
            this.panel_log_data.Controls.Add(this.textBox_send_3);
            this.panel_log_data.Controls.Add(this.button_send_2);
            this.panel_log_data.Controls.Add(this.textBox_send_2);
            this.panel_log_data.Controls.Add(this.button_send_1);
            this.panel_log_data.Controls.Add(this.button_clear);
            this.panel_log_data.Controls.Add(this.textBox_send_1);
            this.panel_log_data.Controls.Add(this.textBox_log);
            this.panel_log_data.Controls.Add(this.label_log);
            this.panel_log_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_log_data.Location = new System.Drawing.Point(232, 0);
            this.panel_log_data.Name = "panel_log_data";
            this.panel_log_data.Size = new System.Drawing.Size(474, 342);
            this.panel_log_data.TabIndex = 1;
            // 
            // checkBox_hex_3
            // 
            this.checkBox_hex_3.AutoSize = true;
            this.checkBox_hex_3.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F);
            this.checkBox_hex_3.ForeColor = System.Drawing.Color.White;
            this.checkBox_hex_3.Location = new System.Drawing.Point(331, 310);
            this.checkBox_hex_3.Name = "checkBox_hex_3";
            this.checkBox_hex_3.Size = new System.Drawing.Size(50, 16);
            this.checkBox_hex_3.TabIndex = 22;
            this.checkBox_hex_3.Text = "HEX";
            this.checkBox_hex_3.UseVisualStyleBackColor = true;
            // 
            // checkBox_hex_2
            // 
            this.checkBox_hex_2.AutoSize = true;
            this.checkBox_hex_2.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F);
            this.checkBox_hex_2.ForeColor = System.Drawing.Color.White;
            this.checkBox_hex_2.Location = new System.Drawing.Point(331, 282);
            this.checkBox_hex_2.Name = "checkBox_hex_2";
            this.checkBox_hex_2.Size = new System.Drawing.Size(50, 16);
            this.checkBox_hex_2.TabIndex = 21;
            this.checkBox_hex_2.Text = "HEX";
            this.checkBox_hex_2.UseVisualStyleBackColor = true;
            // 
            // checkBox_hex_1
            // 
            this.checkBox_hex_1.AutoSize = true;
            this.checkBox_hex_1.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F);
            this.checkBox_hex_1.ForeColor = System.Drawing.Color.White;
            this.checkBox_hex_1.Location = new System.Drawing.Point(331, 253);
            this.checkBox_hex_1.Name = "checkBox_hex_1";
            this.checkBox_hex_1.Size = new System.Drawing.Size(50, 16);
            this.checkBox_hex_1.TabIndex = 20;
            this.checkBox_hex_1.Text = "HEX";
            this.checkBox_hex_1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("BankGothic Md BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label8.Location = new System.Drawing.Point(309, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 12);
            this.label8.TabIndex = 19;
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Location = new System.Drawing.Point(8, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "3.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Location = new System.Drawing.Point(8, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "2.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(8, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "1.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_send_3
            // 
            this.button_send_3.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F);
            this.button_send_3.Location = new System.Drawing.Point(388, 306);
            this.button_send_3.Name = "button_send_3";
            this.button_send_3.Size = new System.Drawing.Size(75, 22);
            this.button_send_3.TabIndex = 11;
            this.button_send_3.Text = "send";
            this.button_send_3.UseVisualStyleBackColor = true;
            this.button_send_3.Click += new System.EventHandler(this.button_send_3_Click);
            // 
            // textBox_send_3
            // 
            this.textBox_send_3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_send_3.Location = new System.Drawing.Point(36, 306);
            this.textBox_send_3.Multiline = true;
            this.textBox_send_3.Name = "textBox_send_3";
            this.textBox_send_3.Size = new System.Drawing.Size(289, 22);
            this.textBox_send_3.TabIndex = 10;
            this.textBox_send_3.Text = "3";
            this.textBox_send_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_send_2
            // 
            this.button_send_2.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F);
            this.button_send_2.Location = new System.Drawing.Point(388, 278);
            this.button_send_2.Name = "button_send_2";
            this.button_send_2.Size = new System.Drawing.Size(75, 22);
            this.button_send_2.TabIndex = 9;
            this.button_send_2.Text = "send";
            this.button_send_2.UseVisualStyleBackColor = true;
            this.button_send_2.Click += new System.EventHandler(this.button_send_2_Click);
            // 
            // textBox_send_2
            // 
            this.textBox_send_2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_send_2.Location = new System.Drawing.Point(36, 278);
            this.textBox_send_2.Multiline = true;
            this.textBox_send_2.Name = "textBox_send_2";
            this.textBox_send_2.Size = new System.Drawing.Size(289, 22);
            this.textBox_send_2.TabIndex = 8;
            this.textBox_send_2.Text = "2";
            this.textBox_send_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_send_1
            // 
            this.button_send_1.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F);
            this.button_send_1.Location = new System.Drawing.Point(387, 250);
            this.button_send_1.Name = "button_send_1";
            this.button_send_1.Size = new System.Drawing.Size(75, 22);
            this.button_send_1.TabIndex = 7;
            this.button_send_1.Text = "send";
            this.button_send_1.UseVisualStyleBackColor = true;
            this.button_send_1.Click += new System.EventHandler(this.button_send_1_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(388, 6);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 22);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_send_1
            // 
            this.textBox_send_1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_send_1.Location = new System.Drawing.Point(36, 250);
            this.textBox_send_1.Multiline = true;
            this.textBox_send_1.Name = "textBox_send_1";
            this.textBox_send_1.Size = new System.Drawing.Size(289, 22);
            this.textBox_send_1.TabIndex = 6;
            this.textBox_send_1.Text = "1";
            this.textBox_send_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox_log.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_log.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_log.Location = new System.Drawing.Point(10, 31);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(452, 209);
            this.textBox_log.TabIndex = 5;
            // 
            // label_log
            // 
            this.label_log.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label_log.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_log.Location = new System.Drawing.Point(11, 8);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(451, 20);
            this.label_log.TabIndex = 3;
            this.label_log.Text = "log data";
            this.label_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_notifications
            // 
            this.timer_notifications.Enabled = true;
            this.timer_notifications.Interval = 500;
            this.timer_notifications.Tick += new System.EventHandler(this.timer_notifications_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(706, 342);
            this.Controls.Add(this.panel_log_data);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_ip.ResumeLayout(false);
            this.panel_ip.PerformLayout();
            this.panel_label.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_connect.ResumeLayout(false);
            this.panel_log_data.ResumeLayout(false);
            this.panel_log_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_label;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Panel panel_ip;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_name_programs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Panel panel_log_data;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Button button_send_1;
        private System.Windows.Forms.TextBox textBox_send_1;
        private System.Windows.Forms.Label label_status_connected;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_connect;
        private System.Windows.Forms.Timer timer_notifications;
        private System.Windows.Forms.Label label_rx;
        private System.Windows.Forms.Label label_tx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_send_3;
        private System.Windows.Forms.TextBox textBox_send_3;
        private System.Windows.Forms.Button button_send_2;
        private System.Windows.Forms.TextBox textBox_send_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_hex_3;
        private System.Windows.Forms.CheckBox checkBox_hex_2;
        private System.Windows.Forms.CheckBox checkBox_hex_1;
        private System.Windows.Forms.Label label8;
    }
}

