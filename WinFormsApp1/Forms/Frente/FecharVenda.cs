using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Forms.Frente
{
    public partial class FecharVenda : Form
    {
        public Models.Method method { get; set; }
        public FecharVenda()
        {
            InitializeComponent();
        }

        private void FecharVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                method = Models.Method.DEBITO;
                Ok();
            }
            else if(e.KeyCode == Keys.C)
            {
                method = Models.Method.CREDITO;
                Ok();
            }
            else if(e.KeyCode == Keys.M)
            {
                method = Models.Method.DINHEIRO;
                Ok();
            }
            else if(e.KeyCode == Keys.P)
            {
                method = Models.Method.PIX;
                Ok();
            }else if(e.KeyCode == Keys.Escape)
            {
                Cancel();
            }

        }
        void Cancel()
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        void Ok() {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            method = Models.Method.DINHEIRO;
            Ok();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            method = Models.Method.PIX;
            Ok();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            method = Models.Method.DEBITO;
            Ok();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            method = Models.Method.CREDITO;
            Ok();
        }
    }
}
