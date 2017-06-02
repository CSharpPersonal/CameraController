using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camera_controller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SystemManager.PortController = new PortControl();
        }

        private void OpenCamButton_Click(object sender, EventArgs e)
        {
            CameraControl cam1 = new CameraControl();
            cam1.ShowCam(CamImageBox);
        }

        private void openPortButton_Click(object sender, EventArgs e)
        {
            String portName = PortNameTextBox.Text;
            SystemManager.PortController.PortName = portName;
            bool success = SystemManager.PortController.Open();
            StatusLabel.Text = "Open Port success: " + success.ToString();
        }

        private void SendSthButton_Click(object sender, EventArgs e)
        {
            bool success = SystemManager.PortController.SendOrder(1);
            StatusLabel.Text = "Send Order success: " + success.ToString();
        }
    }
}
