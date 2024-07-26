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
using ZXing;


namespace Camera
{
    public partial class FormCamera : Form
    {
        FilterInfoCollection infoCollection;
        VideoCaptureDevice captureDevice;
        public event Action<string> OnQRCodeScanned;
        public FormCamera()
        {
            InitializeComponent();
        }

        private void Camera_Load(object sender, EventArgs e)
        {
            infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (infoCollection.Count > 0)
            {
                // Start the first available camera
                captureDevice = new VideoCaptureDevice(infoCollection[0].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame; ;
                captureDevice.Start();
            }
            else
            {
                MessageBox.Show("Không tìm thấy máy ảnh nào.");
            }
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                // Trigger the event
                OnQRCodeScanned?.Invoke(result.Text);
            }
            pictureBox1.Image = bitmap;
        }

        private void Camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the capture device when closing the form
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
            }
        }
    }
}
