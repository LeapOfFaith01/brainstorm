using Refit;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms.Login
{
    public partial class LoginForm : Form
    {
        public static User usuario;
        private IUserService service;
        public LoginForm()
        {
            InitializeComponent();
            service = RestService.For<IUserService>("http://localhost:3000");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                await signInAsync();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private async Task signInAsync() {
            var user = new User();
            user.username = textBox1.Text;
            user.password = textBox2.Text;

            var data = await service.SignIn(user);

            if(data != null )
            {
                if (data.active)
                {
                    usuario = data;

                    var form = new HomeForm();

                    form.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuário inátivo! \nContate o Administrador do sistema");
                }
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreto!");
            }
        }


        private async Task WriteUserJsonAsync(User user) {
            using FileStream createStream = File.Create("../user.json");
            try
            {
                await JsonSerializer.SerializeAsync(createStream, user);
            }
            catch(NotSupportedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
