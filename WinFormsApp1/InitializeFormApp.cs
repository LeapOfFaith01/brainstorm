using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class InitializeFormApp : Form
    {
        public InitializeFormApp()
        {
            InitializeComponent();
        }

        private void InitializeFormApp_Shown(object sender, EventArgs e)
        {
            InitializeMigration();
        }

        private void InitializeMigration() {
            var process = new Process();

            process.StartInfo.FileName = "wt";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.Arguments = "cd C:/Servidor";
            process.Start();

        }
    }
}
