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
            this.groupBox_camera = new System.Windows.Forms.GroupBox();
            this.groupBox_server = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).BeginInit();
            this.panel1.SuspendLayout();
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
            // groupBox_camera
            // 
            this.groupBox_camera.Location = new System.Drawing.Point(3, 3);
            this.groupBox_camera.Name = "groupBox_camera";
            this.groupBox_camera.Size = new System.Drawing.Size(258, 111);
            this.groupBox_camera.TabIndex = 0;
            this.groupBox_camera.TabStop = false;
            this.groupBox_camera.Text = "Option camera";
            // 
            // groupBox_server
            // 
            this.groupBox_server.Location = new System.Drawing.Point(267, 3);
            this.groupBox_server.Name = "groupBox_server";
            this.groupBox_server.Size = new System.Drawing.Size(304, 114);
            this.groupBox_server.TabIndex = 1;
            this.groupBox_server.TabStop = false;
            this.groupBox_server.Text = "Option connect";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_eye;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_server;
        private System.Windows.Forms.GroupBox groupBox_camera;
    }
}

