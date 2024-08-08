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
        Timer scanTimer;
        Bitmap currentFrame;
        string lastResult;
        bool isProcessing;
        public event Action<string> OnQRCodeScanned;
        public FormCamera()
        {
            InitializeComponent();
            // Initialize the timer
            scanTimer = new Timer();
            scanTimer.Interval = 100; // Scan every 100ms
            scanTimer.Tick += ScanTimer_Tick; ;
        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (currentFrame != null && !isProcessing)
            {
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(currentFrame);
                if (result != null)
                {
                    if (result.Text != lastResult)
                    {
                        isProcessing = true;
                        // Trigger the event for a new QR code
                        OnQRCodeScanned?.Invoke(result.Text);
                        lastResult = result.Text;
                    }
                }
                else
                {
                    lastResult = null;
                }
            }
        }

        private void Camera_Load(object sender, EventArgs e)
        {
        
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            currentFrame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = currentFrame;
        }

        private void Camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the capture device and timer when closing the form
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
            }

            if (scanTimer != null)
            {
                scanTimer.Stop();
                scanTimer.Dispose();
            }
        }

        public void ResetProcessing()
        {
            isProcessing = false;
        }

        private void btn_Tat_Click(object sender, EventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
                scanTimer.Stop();

            }
        }

        private void btn_Bat_Click(object sender, EventArgs e)
        {
            if (captureDevice == null)
            {
                // Initialize the capture device if it's not initialized
                infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (infoCollection.Count > 0)
                {
                    captureDevice = new VideoCaptureDevice(infoCollection[0].MonikerString);
                    captureDevice.NewFrame += CaptureDevice_NewFrame;
                }
                else
                {
                    MessageBox.Show("No camera devices found.");
                    return;
                }
            }

            if (captureDevice != null && !captureDevice.IsRunning)
            {
                captureDevice.Start();
                scanTimer.Start();

            }
        }
    }
}
