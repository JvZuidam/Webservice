using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WinFormClient
{
    public partial class addLog : Form
    {
        public addLog()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string postData = "ver=1&cmd=abf";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            string author = TxtBoxAth.Text;
            string log = TxtBoxLog.Text;


            Uri target = new Uri("http://192.168.56.101:8080/Create.php");
            WebRequest request = WebRequest.Create(target);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            using (var dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                Console.WriteLine("Succes");
            }
        }
    }
}
