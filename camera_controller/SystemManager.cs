using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace camera_controller
{
    public static class SystemManager
    {
        public static bool server_control_enable = false;
        public static bool keyPad_enable = false;
        public static bool port_opened = false;
        public static bool cam_opened = false;
        public static bool recordTimerStarted = false;
        public static PortControl PortController;
        public static CameraControl cam1;
        
    }
}
