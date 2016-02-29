using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAddLg_Click(object sender, EventArgs e)
        {
            var showForm = new addLog();
            showForm.ShowDialog();
        }

        private void BtnVwLg_Click(object sender, EventArgs e)
        {
            var showForm = new viewLog();
            showForm.ShowDialog();
        }

        private void BtnEdtLg_Click(object sender, EventArgs e)
        {
            var showForm = new editLog();
            showForm.ShowDialog();
        }

        private void BtnDelLg_Click(object sender, EventArgs e)
        {
            var showForm = new deleteLog();
            showForm.ShowDialog();
        }
    }
}
