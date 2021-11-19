using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Forms.Frente;
using WinFormsApp1.Forms.Sells;

namespace WinFormsApp1.Forms
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            accesslabel.Text = $"Entrou como: {Login.LoginForm.usuario.username} \n Nivel de acesso: {Login.LoginForm.usuario.type}";
        }

        private void dateTicker_Tick(object sender, EventArgs e)
        {
            dateTimeLabel.Text = $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToShortTimeString()}";
        }

        private void btEstoque_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            form.ShowDialog();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btVendas_Click(object sender, EventArgs e)
        {
            var form = new SellForm();
            form.ShowDialog();
        }

        private void pdv_Click(object sender, EventArgs e)
        {
            var form = new Pdv();
            form.ShowDialog();
        }

        private void HomeForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                var form = new Pdv();
                form.ShowDialog();
            }
            else if (e.KeyCode == Keys.F7) {
                var form = new SellForm();
                form.ShowDialog();
            } else if (e.KeyCode == Keys.F2) {
                var form = new ProductForm();
                form.ShowDialog();
            }
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            if(Login.LoginForm.usuario.type != Models.Type.ADMIN)
            {
                MessageBox.Show("Você não tem autorização para vizualizar esse recurso!");
            }
            else
            {
                var form = new Usuarios.UsuariosForm();
                form.ShowDialog();
            }
        }
    }
}
