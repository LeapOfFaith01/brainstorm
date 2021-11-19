using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Forms.Frente
{
    public partial class QuantidadeForm : Form
    {
        public int quantidade { get; set; }
        public QuantidadeForm(String formTitle, String label, String buttonLabel, bool warn)
        {
            InitializeComponent();
            this.Text = formTitle;
            lbTitle.Text = label;
            this.btAction.Text = buttonLabel;
            this.warn.Visible = warn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != String.Empty && Convert.ToInt32(textBox1.Text) > 0)
            {
                quantidade = Convert.ToInt32(textBox1.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Quantidade Inválida", "Quantidade inválida",MessageBoxButtons.OK);
            }
        }

        private void QuantidadeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text != String.Empty && Convert.ToInt32(textBox1.Text) == 0)
                {
                    quantidade = Convert.ToInt32(textBox1.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (textBox1.Text != String.Empty && Convert.ToInt32(textBox1.Text) > 0)
                {
                    quantidade = Convert.ToInt32(textBox1.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Quantidade Inválida", "Quantidade inválida", MessageBoxButtons.OK);
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text != String.Empty && Convert.ToInt32(textBox1.Text) == 0)
                {
                    quantidade = Convert.ToInt32(textBox1.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else if (textBox1.Text != String.Empty && Convert.ToInt32(textBox1.Text) > 0)
                {
                    quantidade = Convert.ToInt32(textBox1.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Quantidade Inválida", "Quantidade inválida", MessageBoxButtons.OK);
                }
            }
        }
    }
}
