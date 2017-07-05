using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.Util;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace camera_controller
{
    public class CameraControl
    {
        public ImageBox CamImageBox;
        Capture capture;
        public CameraControl(ImageBox CamImageBox)
        {
            this.CamImageBox = CamImageBox;
        }
        public bool ShowCam()
        {
            try
            {
                CamImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
                capture = new Capture(0); //create a camera captue in surface 1 for front camera
                Application.Idle += new EventHandler(cam_th);
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool CloseCam()
        {
            try
            {
                Application.Idle -= cam_th;
                return true;
            }
            catch
            {
                return false;
            }

        }
        private void cam_th(object sender, EventArgs e)
        {  //run this until application closed (close button click on image viewer)
                CamImageBox.Image = capture.QueryFrame(); //draw the image obtained from camera
        }
        public bool saveImage()
        {
            try
            {
                string screenshot_dir = Application.StartupPath + "\\screenshot";
                if (!Directory.Exists(screenshot_dir))
                {
                    Directory.CreateDirectory(screenshot_dir);
                }
                string filename = screenshot_dir + "\\image.jpeg";
                this.CamImageBox.Image.Save(@filename);
                if (SystemManager.recordTimerStarted)
                {
                    string record_dir = "F:\\melb\\development\\record";
                    if (!Directory.Exists(record_dir))
                    {
                        Directory.CreateDirectory(record_dir);
                    }
                    DateTime date = DateTime.Now;
                    string format = "yyyy_MM_dd_HH_mm";
                    string dateStr = date.ToString(format);
                    filename = record_dir + "\\screenshot" + dateStr + ".jpeg";
                    this.CamImageBox.Image.Save(@filename);
                }

            }
            catch
            { return false; }
            return true;
        } 
    }
}
