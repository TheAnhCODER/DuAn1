using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;

namespace GUI
{
    public partial class FormBank : Form
    {
        public FormBank()
        {
            InitializeComponent();
        }

        private void FormBank_Load(object sender, EventArgs e)
        {
            var apiRequest = new ApiRequest
            {
                acqId = 970422, // MBBank's acqId (you need to replace with actual ID)
                accountNo = "0946826098",
                accountName = "DINH THE ANH",
                amount = BanHangControl.tienQR, // You can set this to any amount if needed
                format = "text",
                template = "compact2"
            };

            var jsonRequest = JsonConvert.SerializeObject(apiRequest);

            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest
            {
                Method = Method.Post
            };
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = response.Content;
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);

                var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                pictureBox1.Image = image;
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi tạo mã QR.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
    public class ApiRequest
    {
        public string accountNo { get; set; }
        public string accountName { get; set; }
        public int acqId { get; set; }
        public int amount { get; set; }
        public string addInfo { get; set; }
        public string format { get; set; }
        public string template { get; set; }
    }

    public class Data
    {
        public int acqId { get; set; }
        public string accountName { get; set; }
        public string qrCode { get; set; }
        public string qrDataURL { get; set; }
    }

    public class ApiResponse
    {
        public string code { get; set; }
        public string desc { get; set; }
        public Data data { get; set; }
    }
}
