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

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;
        private const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form
        private const int WM_LBUTTONDBLCLK = 0x0203; //client area

        public MainForm()
        {
            InitializeComponent();
            SystemManager.PortController = new PortControl();
            ServerManager.frm = this;
            var kh = new KeyboardHook(true);
            kh.KeyDown += Kh_KeyDown;
            //Application.Run();
            
        }
        ///
        /// Handling the window messages
        ///
        protected override void WndProc(ref Message message)
        {
           
            if (message.Msg == WM_NCLBUTTONDBLCLK)
            {
                return;
            }
            if (message.Msg == WM_LBUTTONDBLCLK)
            {
                return;
            }
            base.WndProc(ref message);
            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
            {
                
                message.Result = (IntPtr)HTCAPTION;
                return;
            }
            

        }

        private void Kh_KeyDown(Keys key, bool Shift, bool Ctrl, bool Alt)
        {
            if (SystemManager.keyPad_enable)
            {
                switch (key)
                {
                    case Keys.Up:
                        {
                            CameraUpButton.PerformClick();
                            break;
                        }
                    case Keys.Down:
                        {
                            CameraDownButton.PerformClick();
                            break;
                        }
                    case Keys.Left:
                        {
                            CameraLeftButton.PerformClick();
                            break;
                        }
                    case Keys.Right:
                        {
                            CameraRightButton.PerformClick();
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void OpenCamButton_Click(object sender, EventArgs e)
        {
            if (!SystemManager.cam_opened)
            {
                SystemManager.cam1 = new CameraControl(CamImageBox);
                bool success = SystemManager.cam1.ShowCam();
                if (success)
                {
                    SystemManager.cam_opened = true;
                    this.OpenCamButton.Text = "Close Cam";
                }
                
            }
            else
            {
                bool success = SystemManager.cam1.CloseCam();
                if (success)
                {
                    this.CamImageBox.Image = null;
                    SystemManager.cam_opened = false;
                    this.OpenCamButton.Text = "Open Cam";
                } 
            }
        }

        private void openPortButton_Click(object sender, EventArgs e)
        {
            if (!SystemManager.port_opened)
            {
                String portName = PortNameTextBox.Text;
                SystemManager.PortController.PortName = portName;
                bool success = SystemManager.PortController.Open();
                StatusLabel.Text = "Open Port success: " + success.ToString();
                if (success)
                {
                    SystemManager.port_opened = true;
                    EnableKeyPadBtn.Enabled = true;
                    EnableServerBtn.Enabled = true;
                    CameraUpButton.Enabled = true;
                    CameraDownButton.Enabled = true;
                    CameraRightButton.Enabled = true;
                    CameraLeftButton.Enabled = true;
                    PortNameTextBox.Enabled = false;
                    openPortButton.Text = "Close Port";
                }
            }
            else
            {
                bool success = SystemManager.PortController.Close();
                StatusLabel.Text = "Close Port success: " + success.ToString();
                if (success)
                {
                    SystemManager.port_opened = false;
                    EnableKeyPadBtn.Enabled = false;
                    EnableServerBtn.Enabled = false;
                    CameraUpButton.Enabled = false;
                    CameraDownButton.Enabled = false;
                    CameraRightButton.Enabled = false;
                    CameraLeftButton.Enabled = false;
                    PortNameTextBox.Enabled = true;
                    openPortButton.Text = "Open Port";
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!SystemManager.keyPad_enable)
            {
                this.EnableKeyPadBtn.Text = "DisableKeyPad";
                SystemManager.keyPad_enable = true;
            }
            else
            {
                this.EnableKeyPadBtn.Text = "EnableKeyPad";
                SystemManager.keyPad_enable = false;
            }
        }
    }
}
