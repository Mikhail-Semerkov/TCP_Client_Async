
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
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_connect = new System.Windows.Forms.Panel();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.panel_port = new System.Windows.Forms.Panel();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.panel_ip = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name_programs = new System.Windows.Forms.Label();
            this.panel_log_data = new System.Windows.Forms.Panel();
            this.lblWrite = new System.Windows.Forms.Label();
            this.lblRead = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label_log = new System.Windows.Forms.Label();
            this.panel_left.SuspendLayout();
            this.panel_connect.SuspendLayout();
            this.panel_port.SuspendLayout();
            this.panel_ip.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_log_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_left.Controls.Add(this.panel_connect);
            this.panel_left.Controls.Add(this.panel_port);
            this.panel_left.Controls.Add(this.panel_ip);
            this.panel_left.Controls.Add(this.panel3);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(209, 314);
            this.panel_left.TabIndex = 0;
            // 
            // panel_connect
            // 
            this.panel_connect.Controls.Add(this.button_disconnect);
            this.panel_connect.Controls.Add(this.label_status);
            this.panel_connect.Controls.Add(this.button_connect);
            this.panel_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_connect.Location = new System.Drawing.Point(0, 188);
            this.panel_connect.Name = "panel_connect";
            this.panel_connect.Size = new System.Drawing.Size(209, 126);
            this.panel_connect.TabIndex = 4;
            // 
            // button_disconnect
            // 
            this.button_disconnect.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_disconnect.Location = new System.Drawing.Point(26, 42);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(161, 30);
            this.button_disconnect.TabIndex = 2;
            this.button_disconnect.Text = "disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // label_status
            // 
            this.label_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_status.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_status.Location = new System.Drawing.Point(0, 95);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(209, 31);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "Status";
            this.label_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_connect
            // 
            this.button_connect.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connect.Location = new System.Drawing.Point(26, 6);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(161, 30);
            this.button_connect.TabIndex = 0;
            this.button_connect.Text = "connect server";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // panel_port
            // 
            this.panel_port.Controls.Add(this.textBox_port);
            this.panel_port.Controls.Add(this.label_port);
            this.panel_port.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_port.Location = new System.Drawing.Point(0, 128);
            this.panel_port.Name = "panel_port";
            this.panel_port.Size = new System.Drawing.Size(209, 60);
            this.panel_port.TabIndex = 3;
            // 
            // textBox_port
            // 
            this.textBox_port.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold);
            this.textBox_port.Location = new System.Drawing.Point(9, 22);
            this.textBox_port.Multiline = true;
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(194, 26);
            this.textBox_port.TabIndex = 4;
            this.textBox_port.Text = "4001";
            this.textBox_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_port
            // 
            this.label_port.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_port.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_port.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_port.Location = new System.Drawing.Point(0, 0);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(209, 19);
            this.label_port.TabIndex = 3;
            this.label_port.Text = "PORT";
            this.label_port.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_ip
            // 
            this.panel_ip.Controls.Add(this.label2);
            this.panel_ip.Controls.Add(this.textBox_ip);
            this.panel_ip.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ip.Location = new System.Drawing.Point(0, 68);
            this.panel_ip.Name = "panel_ip";
            this.panel_ip.Size = new System.Drawing.Size(209, 60);
            this.panel_ip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "IP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ip.Location = new System.Drawing.Point(9, 22);
            this.textBox_ip.Multiline = true;
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(194, 26);
            this.textBox_ip.TabIndex = 4;
            this.textBox_ip.Text = "10.200.72.31";
            this.textBox_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label_name_programs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 68);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(0, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "by M.Semerkov";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_name_programs
            // 
            this.label_name_programs.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_name_programs.Font = new System.Drawing.Font("BankGothic Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name_programs.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_name_programs.Location = new System.Drawing.Point(0, 0);
            this.label_name_programs.Name = "label_name_programs";
            this.label_name_programs.Size = new System.Drawing.Size(209, 31);
            this.label_name_programs.TabIndex = 0;
            this.label_name_programs.Text = "TCP CLIENT";
            this.label_name_programs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_log_data
            // 
            this.panel_log_data.Controls.Add(this.lblWrite);
            this.panel_log_data.Controls.Add(this.lblRead);
            this.panel_log_data.Controls.Add(this.button_send);
            this.panel_log_data.Controls.Add(this.button_clear);
            this.panel_log_data.Controls.Add(this.textBox_send);
            this.panel_log_data.Controls.Add(this.textBox_log);
            this.panel_log_data.Controls.Add(this.label_log);
            this.panel_log_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_log_data.Location = new System.Drawing.Point(209, 0);
            this.panel_log_data.Name = "panel_log_data";
            this.panel_log_data.Size = new System.Drawing.Size(497, 314);
            this.panel_log_data.TabIndex = 1;
            // 
            // lblWrite
            // 
            this.lblWrite.BackColor = System.Drawing.Color.Red;
            this.lblWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrite.ForeColor = System.Drawing.Color.White;
            this.lblWrite.Location = new System.Drawing.Point(106, 5);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(83, 23);
            this.lblWrite.TabIndex = 12;
            this.lblWrite.Text = "Write";
            this.lblWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWrite.Visible = false;
            // 
            // lblRead
            // 
            this.lblRead.BackColor = System.Drawing.Color.Red;
            this.lblRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRead.ForeColor = System.Drawing.Color.White;
            this.lblRead.Location = new System.Drawing.Point(6, 5);
            this.lblRead.Name = "lblRead";
            this.lblRead.Size = new System.Drawing.Size(94, 23);
            this.lblRead.TabIndex = 11;
            this.lblRead.Text = "Read";
            this.lblRead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRead.Visible = false;
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(382, 277);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(109, 30);
            this.button_send.TabIndex = 7;
            this.button_send.Text = "SEND";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click_1);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(6, 242);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(485, 30);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "CLEAR";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_send
            // 
            this.textBox_send.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_send.Location = new System.Drawing.Point(6, 278);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(370, 26);
            this.textBox_send.TabIndex = 6;
            this.textBox_send.Text = "1b 47 73 30 33 04";
            this.textBox_send.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.textBox_log.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_log.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox_log.Location = new System.Drawing.Point(6, 31);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(485, 205);
            this.textBox_log.TabIndex = 5;
            // 
            // label_log
            // 
            this.label_log.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_log.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.label_log.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label_log.Location = new System.Drawing.Point(0, 0);
            this.label_log.Name = "label_log";
            this.label_log.Size = new System.Drawing.Size(497, 31);
            this.label_log.TabIndex = 3;
            this.label_log.Text = "LOG DATA";
            this.label_log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(706, 314);
            this.Controls.Add(this.panel_log_data);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "TCP Client";
            this.panel_left.ResumeLayout(false);
            this.panel_connect.ResumeLayout(false);
            this.panel_port.ResumeLayout(false);
            this.panel_port.PerformLayout();
            this.panel_ip.ResumeLayout(false);
            this.panel_ip.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_log_data.ResumeLayout(false);
            this.panel_log_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_port;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.Panel panel_ip;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label_name_programs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_connect;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Panel panel_log_data;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Label lblWrite;
        private System.Windows.Forms.Label lblRead;
    }
}

