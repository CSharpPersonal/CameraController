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

namespace camera_controller
{
    public class CameraControl
    {
        public void ShowCam(ImageBox CamImageBox)
        {
            CamImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Capture capture = new Capture(); //create a camera captue
            Application.Idle += new EventHandler(delegate (object sender, EventArgs e)
            {  //run this until application closed (close button click on image viewer)
                CamImageBox.Image = capture.QueryFrame(); //draw the image obtained from camera
            });
            
        }
    }
}
