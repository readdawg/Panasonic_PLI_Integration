using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TokenAuth;
using MjpegProcessor;
using System.Drawing.Drawing2D;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Panasonic_PLI_Integration
{
    public partial class Form1 : Form
    {

        // Declare variables
        string sEncryptedToken = "";
        //string adderess = Properties.Settings.Default.ApiAddress;
        //string user = Properties.Settings.Default.UserName;
        //string password = Properties.Settings.Default.Password;
        long timeout = 31622400;
        string cameraid = "785451355";
        
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //If Connection Settings have not been set, open Connection Settings on opening
            if (Properties.Settings.Default.IsConfigured == false)
            {
                ConnectionSettings connSet = new ConnectionSettings();
                connSet.Show();
                connSet.TopMost = true;
            }

            

        }

        private void btn_Open_Click(object sender, EventArgs e)
        {

            string user = Properties.Settings.Default.UserName;
            string password = Properties.Settings.Default.Password;
            string adderess = Properties.Settings.Default.ApiAddress;
            string sendTrigger = Properties.Settings.Default.SendTriggerLoc;
            string port = "4011";
            string channel = "15";


            var argus = user + "," + password + "," + adderess + "," + port + "," + channel;

            //MessageBox.Show(argus);
            //MessageBox.Show(sendTrigger + @"\SendTrigger.exe");

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = sendTrigger + @"\SendTrigger.exe";
            startInfo.Arguments = argus;
            Process.Start(startInfo);

        }

        private void btn_Lockdown_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {            

            //Declare variables
            string user = Properties.Settings.Default.UserName;
            string password = Properties.Settings.Default.Password;
            string adderess = Properties.Settings.Default.ApiAddress;

            lb_cameras.SelectedItem.

            //Generate encrypted user token
            var oUserToken = new TokenAuth.UserToken(user, password, timeout);
            var encryptedToken = oUserToken.Encrypt();
            sEncryptedToken = encryptedToken;

            //Pull camera list from API
            string url = "http://" + adderess + ":9000/api/v1/cameras";

            //Create Data Table of JSON results
            DataTable jsonDataDisplay()
            {
                using (var webClient = new WebClient())
                {
                    String rawJSON = webClient.DownloadString(url);
                    var table = JsonConvert.DeserializeObject<DataTable>(rawJSON);
                    return table;
                }
            }            

            //Populate list from JSON objects
            lb_cameras.DataSource = jsonDataDisplay();
            lb_cameras.DisplayMember = "Name";
            lb_cameras.ValueMember = "ID";

            //Load MJPEG stream into picture box
            try
            {
                string url3 = "http://" + adderess + ":9000/api/v1/video/" + cameraid + "/mjpeg?token=" + sEncryptedToken;                

                MjpegDecoder mjpeg = new MjpegDecoder();
                mjpeg.FrameReady += mjpeg_FrameReady;
                mjpeg.ParseStream(new Uri(url3));
            }
            catch (System.Net.WebException e1)
            {
                MessageBox.Show("Web Exception Thrown: {0}", e1.Message);
            }
        }        

        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show Connection settings form
            ConnectionSettings connSet = new ConnectionSettings();
            connSet.Show();
            connSet.TopMost = true;
        }

        private void lb_Cameras_SelectedIndex(object sender, EventArgs e)
        {
            //Declare variables
            string adderess = Properties.Settings.Default.ApiAddress;

            if (lb_cameras.SelectedIndex != -1)
            {

                MessageBox.Show("List Item Has Changed");

            }

            //try
            //{

            //    string url3 = "http://" + adderess + ":9000/api/v1/video/" + cameraid + "/mjpeg?token=" + sEncryptedToken;

            //    MjpegDecoder mjpeg = new MjpegDecoder();
            //    mjpeg.FrameReady += mjpeg_FrameReady;
            //    mjpeg.ParseStream(new Uri(url3));
            //}
            //catch (System.Net.WebException e1)
            //{

            //    MessageBox.Show("Web Exception Thrown: {0}", e1.Message);
            //}
        }

        void mjpeg_FrameReady(object sender, FrameReadyEventArgs e)
        {
            Bitmap bmp = e.Bitmap;

            RectangleF rectf = new RectangleF(70, 90, 500, 70);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString("Test Text", new Font("Thamoa", 50), Brushes.Black, rectf);

            g.Flush();

            pb_Video.Image = bmp;

        }

        private void lb_Cameras_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (lb_cameras.SelectedItems.Count == -1)
            {
                MessageBox.Show("Selected Item Changed");
            }
            else
            {

                MessageBox.Show("New Item Changed");
            }

        }
    }
        
}