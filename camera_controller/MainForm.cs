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
            ServerManager.frm = this;
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
            if (!SystemManager.server_control_enable)
            {
                SystemManager.server_control_enable = true;
                ServerManager.runMonitor();
                this.EnableServerBtn.Text = "Disable Derver";
            }
            else
            {
                this.StatusLabel.Text = "server control disabled";
                SystemManager.server_control_enable = false;
                ServerManager.stopMonitor();
                this.EnableServerBtn.Text = "Enable Derver";
            }
        }

        private void CameraUpButton_Click(object sender, EventArgs e)
        {
            if (SystemManager.server_control_enable)
            {
                ServerManager.trySend(1);
            }
            else
            {
                bool success = SystemManager.PortController.SendOrder(1);
                StatusLabel.Text = "Send 'UP' Order success: " + success.ToString();
            }
        }

        private void CameraDownButton_Click(object sender, EventArgs e)
        {
            if (SystemManager.server_control_enable)
            {
                ServerManager.trySend(4);
            }
            else
            {
                bool success = SystemManager.PortController.SendOrder(4);
                StatusLabel.Text = "Send 'DOWN' Order success: " + success.ToString();
            }
        }

        private void CameraLeftButton_Click(object sender, EventArgs e)
        {
            if (SystemManager.server_control_enable)
            {
                ServerManager.trySend(3);
            }
            else
            {
                bool success = SystemManager.PortController.SendOrder(3);
                StatusLabel.Text = "Send 'LEFT' Order success: " + success.ToString();
            }
        }

        private void CameraRightButton_Click(object sender, EventArgs e)
        {
            if (SystemManager.server_control_enable)
            {
                ServerManager.trySend(2);
            }
            else
            {
                bool success = SystemManager.PortController.SendOrder(2);
                StatusLabel.Text = "Send 'RIGHT' Order success: " + success.ToString();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
