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
using System.IO;
using Newtonsoft.Json.Linq;

namespace WinFormClient
{
    public partial class viewLog : Form
    {
        public viewLog()
        {
            InitializeComponent();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://192.168.56.101:8080/View.php");
            StreamReader reader = new StreamReader(stream);
            var jeMoeder = reader.ReadLine();
            Newtonsoft.Json.Linq.JArray jObject = Newtonsoft.Json.Linq.JArray.Parse(jeMoeder);

            foreach (var item in jObject)
            {
                LstBxView.Items.Add(item["Log_author"]);
                LstBxView.Items.Add(item["Log_story"]);
            }

            stream.Close();
        }
    }
}
