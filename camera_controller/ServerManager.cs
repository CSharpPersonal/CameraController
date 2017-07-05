using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace camera_controller
{
    public static class ServerManager
    {
        public static readonly HttpClient client = new HttpClient();
        public static MainForm frm;
        public static System.Threading.Timer scan_timer;
        public static void updateStatusBar(string str)
        {
            frm.Invoke(new System.Windows.Forms.MethodInvoker(delegate () {
                frm.StatusLabel.Text = str;
            }));
        }

        public static async void trySend(int value)
        {
            Random rnd = new Random();
            string cmd = "http://createweb.com.au/test/camera_cmd.php?id=" + rnd.NextDouble().ToString() + "&action=" + value;
            var responseString = await client.GetStringAsync(cmd);
            
        }
        public static async Task<string> trySendFile(string path)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://createweb.com.au/test");
            MultipartFormDataContent form = new MultipartFormDataContent();
            HttpContent content = new StringContent("fileToUpload");
            form.Add(content, "fileToUpload");
            var stream = File.OpenRead(path);
            content = new StreamContent(stream);
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = "fileToUpload",
                FileName = path
            };
            form.Add(content);
            var response = await client.PostAsync("http://createweb.com.au/test/upload_file.php", form);
            return response.Content.ReadAsStringAsync().Result;
        }
        public static void runMonitor()
        {
            scan_timer = new System.Threading.Timer(async delegate
            { 
                Random rnd = new Random();
                string cmd = "http://createweb.com.au/test/camera_cmd.php?id=" + rnd.NextDouble().ToString();
                var responseString = await client.GetStringAsync(cmd);
                
                int responseInt = Convert.ToInt16(responseString);
                switch (responseInt)
                {
                    case 0:
                        updateStatusBar("server response: 0");
                        break;
                    case 1:
                        updateStatusBar("server response: 1");
                        SystemManager.PortController.SendOrder(1);
                        break;
                    case 2:
                        updateStatusBar("server response: 2");
                        SystemManager.PortController.SendOrder(2);
                        break;
                    case 3:
                        updateStatusBar("server response: 3");
                        SystemManager.PortController.SendOrder(3);
                        break;
                    case 4:
                        updateStatusBar("server response: 4");
                        SystemManager.PortController.SendOrder(4);
                        break;
                    case 5:
                        updateStatusBar("server response: 5");
                        if (SystemManager.cam1.CamImageBox.Image != null)
                        {
                            SystemManager.cam1.saveImage();
                            string screenshot_dir = Application.StartupPath + "\\screenshot\\image.jpeg";
                            string response = await ServerManager.trySendFile(screenshot_dir);

                        }
                        break;
                    default:
                        updateStatusBar( "server response: unknown");
                        break;
                }

            }, null, 1000, 1000);
        }

        public static void stopMonitor()
        {
            scan_timer.Change(Timeout.Infinite, Timeout.Infinite);
        }
    }
}
