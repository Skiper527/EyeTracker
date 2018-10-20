namespace EyeTracker
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
            this.pictureBox_eye = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_server = new System.Windows.Forms.GroupBox();
            this.groupBox_camera = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton_date_image = new System.Windows.Forms.RadioButton();
            this.radioButton_date_point = new System.Windows.Forms.RadioButton();
            this.button_connect_camera = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lPort = new System.Windows.Forms.Label();
            this.lIP = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chClients = new System.Windows.Forms.CheckedListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_server.SuspendLayout();
            this.groupBox_camera.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_eye
            // 
            this.pictureBox_eye.Location = new System.Drawing.Point(1, 1);
            this.pictureBox_eye.Name = "pictureBox_eye";
            this.pictureBox_eye.Size = new System.Drawing.Size(574, 351);
            this.pictureBox_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_eye.TabIndex = 0;
            this.pictureBox_eye.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_server);
            this.panel1.Controls.Add(this.groupBox_camera);
            this.panel1.Location = new System.Drawing.Point(1, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 120);
            this.panel1.TabIndex = 1;
            // 
            // groupBox_server
            // 
            this.groupBox_server.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_server.Controls.Add(this.btnStart);
            this.groupBox_server.Controls.Add(this.btnConnect);
            this.groupBox_server.Controls.Add(this.groupBox6);
            this.groupBox_server.Controls.Add(this.tbName);
            this.groupBox_server.Controls.Add(this.lIP);
            this.groupBox_server.Controls.Add(this.label3);
            this.groupBox_server.Controls.Add(this.lPort);
            this.groupBox_server.Controls.Add(this.tbIP);
            this.groupBox_server.Controls.Add(this.tbPort);
            this.groupBox_server.Location = new System.Drawing.Point(173, 3);
            this.groupBox_server.Name = "groupBox_server";
            this.groupBox_server.Size = new System.Drawing.Size(398, 114);
            this.groupBox_server.TabIndex = 1;
            this.groupBox_server.TabStop = false;
            this.groupBox_server.Text = "Option connect network";
            // 
            // groupBox_camera
            // 
            this.groupBox_camera.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox_camera.Controls.Add(this.label1);
            this.groupBox_camera.Controls.Add(this.radioButton_date_image);
            this.groupBox_camera.Controls.Add(this.radioButton_date_point);
            this.groupBox_camera.Controls.Add(this.button_connect_camera);
            this.groupBox_camera.Location = new System.Drawing.Point(3, 3);
            this.groupBox_camera.Name = "groupBox_camera";
            this.groupBox_camera.Size = new System.Drawing.Size(164, 111);
            this.groupBox_camera.TabIndex = 0;
            this.groupBox_camera.TabStop = false;
            this.groupBox_camera.Text = "Option camera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose date for broadcast:";
            // 
            // radioButton_date_image
            // 
            this.radioButton_date_image.AutoSize = true;
            this.radioButton_date_image.Location = new System.Drawing.Point(8, 88);
            this.radioButton_date_image.Name = "radioButton_date_image";
            this.radioButton_date_image.Size = new System.Drawing.Size(104, 17);
            this.radioButton_date_image.TabIndex = 2;
            this.radioButton_date_image.Text = "Broadcast image";
            this.radioButton_date_image.UseVisualStyleBackColor = true;
            // 
            // radioButton_date_point
            // 
            this.radioButton_date_point.AutoSize = true;
            this.radioButton_date_point.Checked = true;
            this.radioButton_date_point.Location = new System.Drawing.Point(8, 65);
            this.radioButton_date_point.Name = "radioButton_date_point";
            this.radioButton_date_point.Size = new System.Drawing.Size(99, 17);
            this.radioButton_date_point.TabIndex = 1;
            this.radioButton_date_point.TabStop = true;
            this.radioButton_date_point.Text = "Broadcast point";
            this.radioButton_date_point.UseVisualStyleBackColor = true;
            // 
            // button_connect_camera
            // 
            this.button_connect_camera.Location = new System.Drawing.Point(6, 19);
            this.button_connect_camera.Name = "button_connect_camera";
            this.button_connect_camera.Size = new System.Drawing.Size(75, 23);
            this.button_connect_camera.TabIndex = 0;
            this.button_connect_camera.Text = "Connect";
            this.button_connect_camera.UseVisualStyleBackColor = true;
            this.button_connect_camera.Click += new System.EventHandler(this.button_connect_camera_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(68, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(158, 20);
            this.tbName.TabIndex = 19;
            this.tbName.Text = "Eye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Name";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(41, 16);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(88, 20);
            this.tbIP.TabIndex = 17;
            this.tbIP.Text = "127.0.0.1";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(176, 16);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(50, 20);
            this.tbPort.TabIndex = 16;
            this.tbPort.Text = "9000";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(135, 19);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(29, 13);
            this.lPort.TabIndex = 15;
            this.lPort.Text = "Port:";
            // 
            // lIP
            // 
            this.lIP.AutoSize = true;
            this.lIP.Location = new System.Drawing.Point(6, 19);
            this.lIP.Name = "lIP";
            this.lIP.Size = new System.Drawing.Size(20, 13);
            this.lIP.TabIndex = 14;
            this.lIP.Text = "IP:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chClients);
            this.groupBox6.Location = new System.Drawing.Point(232, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(160, 97);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Client";
            // 
            // chClients
            // 
            this.chClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chClients.FormattingEnabled = true;
            this.chClients.Location = new System.Drawing.Point(6, 25);
            this.chClients.Name = "chClients";
            this.chClients.Size = new System.Drawing.Size(144, 64);
            this.chClients.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(9, 68);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 31;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(126, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 32;
            this.btnStart.Text = "Start sending";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_eye);
            this.Name = "Form1";
            this.Text = "EyeTracker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox_server.ResumeLayout(false);
            this.groupBox_server.PerformLayout();
            this.groupBox_camera.ResumeLayout(false);
            this.groupBox_camera.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_eye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_server;
        private System.Windows.Forms.GroupBox groupBox_camera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton_date_image;
        private System.Windows.Forms.RadioButton radioButton_date_point;
        private System.Windows.Forms.Button button_connect_camera;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox chClients;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnConnect;
    }
}

