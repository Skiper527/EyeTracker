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

using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Net;

using NetManager;

namespace EyeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region Client event
            Client = new NMClient(this);
            Client.OnError += new EventHandler<EventMsgArgs>(Client_OnError);
            Client.OnStop += new EventHandler(Client_OnStop);
            Client.OnNewClient += new EventHandler<EventClientArgs>(Client_OnNewClient);
            Client.OnDeleteClient += new EventHandler<EventClientArgs>(Client_OnDeleteClient);
            #endregion
        }


        #region variables
        bool flag_connect_camera = false;
        bool flag_sending_message = false;
        VideoCaptureDevice videoSourse = null; //var choose device
        object object_lock = new object();
        byte value_grad = 100;
        NMClient Client;
        byte[] image_array; //array is sending in network
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
                if (!(videoSourse == null))
                    if(videoSourse.IsRunning)
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
            {
                Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
                Point center_point = Detect_eye(bmp, value_grad);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(Pens.OrangeRed, new Point(center_point.X, center_point.Y - 20), new Point(center_point.X, center_point.Y + 20));
                g.DrawLine(Pens.OrangeRed, new Point(center_point.X - 20, center_point.Y), new Point(center_point.X + 20, center_point.Y));
                pictureBox_eye.Image = bmp;
                g.Dispose();

                if (radioButton_date_point.Checked)
                    Send(center_point);
                
                if(radioButton_date_image.Checked)
                    Send(image_array);
            }
        }


        /// <summary>
        /// Close form and disconnect camera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(videoSourse == null))
                if (videoSourse.IsRunning)
            {
                videoSourse.SignalToStop();
                videoSourse = null;
            }
        }


        /// <summary>
        /// Search center eye
        /// </summary>
        /// <param name="bmp">Image eye</param>
        /// <param name="value">Border black/white pixel </param>
        /// <returns></returns>
        private Point Detect_eye(Bitmap bmp, byte value)
        {
            System.Drawing.Point res_point = new System.Drawing.Point(1, 1);
            int k_numeric = 0;

            PixelFormat pxf = PixelFormat.Format24bppRgb;
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite, pxf);
            IntPtr ptr = bmpData.Scan0;
            int numBytes = bmpData.Stride * bmp.Height;
            int widthBytes = bmpData.Stride;
            byte[] rgbValues = new byte[numBytes];
            Marshal.Copy(ptr, rgbValues, 0, numBytes);


            int x_sr = 0;
            int y_sr = 0;
            for (int counter = 0; counter < rgbValues.Length - 6; counter += 3)
            {
                if ((rgbValues[counter] < value) && (rgbValues[counter + 1] < value) && (rgbValues[counter + 2] < value))
                {
                    x_sr += (counter / 3) % bmp.Width;
                    y_sr += (counter / 3) / bmp.Width;
                    k_numeric++;
                }
            }

            if (radioButton_date_image.Checked)
                image_array = rgbValues;

            Marshal.Copy(rgbValues, 0, ptr, numBytes);
            bmp.UnlockBits(bmpData);

            res_point.X = x_sr / k_numeric;
            res_point.Y = y_sr / k_numeric;
            return res_point;
        }

        #region Network function

        /// <summary>
        /// Send result point
        /// </summary>
        /// <param name="_point">result_point</param>
        private void Send(Point _point)
        {
            int[] Addresses = new int[chClients.CheckedItems.Count];
            for (int I = 0; I < chClients.CheckedItems.Count; I++)
                Addresses[I] = (chClients.CheckedItems[I] as ClientAddress).Id;

            byte[] Data = new byte[2 * sizeof(int)];

            Array.Copy(BitConverter.GetBytes((int)18), Data, sizeof(int));
            Array.Copy(BitConverter.GetBytes(_point.X), 0, Data, sizeof(int), sizeof(int));
            Array.Copy(BitConverter.GetBytes(_point.Y), 0, Data, sizeof(int), sizeof(int));
            Client.SendData(Addresses, Data);
            DateTime dt = DateTime.Now;
        }


        /// <summary>
        /// Send result image
        /// </summary>
        /// <param name="bmp_array">result_image</param>
        private void Send(byte[] bmp_array)
        {
            int[] Addresses = new int[chClients.CheckedItems.Count];
            for (int I = 0; I < chClients.CheckedItems.Count; I++)
                Addresses[I] = (chClients.CheckedItems[I] as ClientAddress).Id;

            byte[] Data = new byte[sizeof(int) + sizeof(int)*bmp_array.Length];

            Array.Copy(BitConverter.GetBytes((int)18), Data, sizeof(int));
            Array.Copy(bmp_array, 0, Data, sizeof(int), sizeof(int));
            Client.SendData(Addresses, Data);
            DateTime dt = DateTime.Now;
        }

        /// <summary>
        /// Error network
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Client_OnError(object sender, EventMsgArgs e)
        {
            MessageBox.Show(e.Msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Stop network
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Client_OnStop(object sender, EventArgs e)
        {
            tbIP.Enabled = true;
            tbName.Enabled = true;
            tbPort.Enabled = true;
            btnConnect.Enabled = true;
            btnConnect.Text = "Connect";

            chClients.Items.Clear();
        }

        /// <summary>
        /// Delete client network
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Client_OnDeleteClient(object sender, EventClientArgs e)
        {
            ClientAddress Cl = new ClientAddress(e.ClientId, e.Name);
            int I = chClients.Items.Count - 1;
            while ((I >= 0) && (Cl.ToString() != chClients.Items[I].ToString()))
                I--;
            if (I >= 0)
                chClients.Items.RemoveAt(I);
        }

        /// <summary>
        /// Add new client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Client_OnNewClient(object sender, EventClientArgs e)
        {
            ClientAddress Cl = new ClientAddress(e.ClientId, e.Name);
            chClients.Items.Add(Cl);
        }

        /// <summary>
        /// Button start connect with network
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!Client.Running)
            {
                tbIP.Enabled = false;
                tbName.Enabled = false;
                tbPort.Enabled = false;
                btnConnect.Text = "Disconnect";
                btnStart.Enabled = true;

                Client.Port = int.Parse(tbPort.Text);
                Client.IPServer = IPAddress.Parse(tbIP.Text);
                Client.Name = tbName.Text;
                Client.RunClient();
            }
            else
            {
                btnConnect.Enabled = false;
                btnStart.Enabled = false;
                Client.StopClient();
            }
        }


        /// <summary>
        /// Button start sending message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start sending")
            {
                flag_sending_message = true;
                btnStart.Text = "Stop sending";
            }
            else
            {
                flag_sending_message = false;
                btnStart.Text = "Start sending";
            }
        }

        #endregion
    }
}
