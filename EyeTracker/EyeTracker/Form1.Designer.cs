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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_camera.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_eye
            // 
            this.pictureBox_eye.Location = new System.Drawing.Point(1, 1);
            this.pictureBox_eye.Name = "pictureBox_eye";
            this.pictureBox_eye.Size = new System.Drawing.Size(574, 351);
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
            this.groupBox_server.Location = new System.Drawing.Point(267, 3);
            this.groupBox_server.Name = "groupBox_server";
            this.groupBox_server.Size = new System.Drawing.Size(304, 114);
            this.groupBox_server.TabIndex = 1;
            this.groupBox_server.TabStop = false;
            this.groupBox_server.Text = "Option connect";
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
            this.groupBox_camera.Size = new System.Drawing.Size(258, 111);
            this.groupBox_camera.TabIndex = 0;
            this.groupBox_camera.TabStop = false;
            this.groupBox_camera.Text = "Option camera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose date for broadcast:";
            // 
            // radioButton_date_image
            // 
            this.radioButton_date_image.AutoSize = true;
            this.radioButton_date_image.Location = new System.Drawing.Point(149, 88);
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
            this.radioButton_date_point.Location = new System.Drawing.Point(149, 65);
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
            this.groupBox_camera.ResumeLayout(false);
            this.groupBox_camera.PerformLayout();
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
    }
}

