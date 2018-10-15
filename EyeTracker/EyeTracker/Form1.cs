using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace EyeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region variables
        bool flag_connect_camera = false;
        VideoCaptureDevice videoSourse = null; //var choose device
        object object_lock = new object();
        #endregion


        /// <summary>
        /// Connect/disconnect with camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_connect_camera_Click(object sender, EventArgs e)
        {
            if (flag_connect_camera)
            {
                if (!(videoSourse == null) & (videoSourse.IsRunning))
                {
                    videoSourse.SignalToStop();
                    videoSourse = null;
                }
                
                flag_connect_camera = false;
                button_connect_camera.Text = "Connect";
                radioButton_date_image.Enabled = true;
                radioButton_date_point.Enabled = true;
            }
            else
            {
                VideoCaptureDeviceForm vcdForm = new VideoCaptureDeviceForm();
                if (vcdForm.ShowDialog() == DialogResult.OK)
                {
                    videoSourse = vcdForm.VideoDevice;
                }
                videoSourse.NewFrame += new NewFrameEventHandler(video_NewFrame);
                videoSourse.Start();

                flag_connect_camera = true;
                button_connect_camera.Text = "Disconnect";
                radioButton_date_image.Enabled = false;
                radioButton_date_point.Enabled = false;
            }
        }


        /// <summary>
        /// Get image with camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            lock (object_lock)
                pictureBox_eye.Image = (Bitmap)eventArgs.Frame.Clone();
        }


        /// <summary>
        /// Close form and disconnect camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(videoSourse == null) & (videoSourse.IsRunning))
            {
                videoSourse.SignalToStop();
                videoSourse = null;
            }
        }
    }
}
