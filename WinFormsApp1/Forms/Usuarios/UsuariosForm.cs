using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;
using Type = WinFormsApp1.Models.Type;

namespace WinFormsApp1.Forms.Usuarios
{
    public partial class UsuariosForm : Form
    {
        private IUserService service;
        private User selectedRow;
        private List<User> users;
        public UsuariosForm()
        {
            InitializeComponent();
            service = RestService.For<IUserService>("http://localhost:3000");
            Task.Run(() => LoadUserFromAPI()).Wait();
        }

        private async Task LoadUserFromAPI()
        {
            try
            {
                var data = await service.GetUsers();
                users = data;

                RefreshTable(users);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado ao carregar as informações");
                Close();
            }
        }

        void RefreshTable(List<User> data)
        {
            DataTable table = new DataTable();

            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Login", typeof(string));
            table.Columns.Add("Tipo", typeof(Type));

            foreach (var x in data)
            {
                table.Rows.Add(x.id, x.username, x.type);
            }

            grid.DataSource = table;

            grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            for (int i = 1; i < grid.Columns.Count; i++)
            {
                grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                var row = grid.Rows[grid.SelectedCells[0].RowIndex];

                var index = Convert.ToInt32(row.Cells["#"].Value);

                selectedRow = users.Find(x => x.id == index);
                txuser.Text = selectedRow.username;
                txpassword.Text = selectedRow.password;
                txactive.Checked = selectedRow.active;
                if (selectedRow.type == Type.ADMIN)
                {
                    checktype.SelectedIndex = 0;
                }
                else
                {
                    checktype.SelectedIndex = 1;
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma linha.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                
                selectedRow.username = txuser.Text;
                selectedRow.password = txpassword.Text;
                selectedRow.active = txactive.Checked;
                if (checktype.SelectedIndex == 0)
                {
                    selectedRow.type = Type.ADMIN;
                }
                else
                {
                    selectedRow.type = Type.EMPLOYEE;
                }
                save(selectedRow, 2);
            }
            else
            {
                var user = new User();
                user.username = txuser.Text;
                user.password = txpassword.Text;
                if (checktype.SelectedIndex == 0)
                {
                    user.type = Type.ADMIN;
                }
                else
                {
                    user.type = Type.EMPLOYEE;
                }
                save(user, 1);

            }

        }
        void ClearData()
        {
            selectedRow = null;
            txuser.Text = "";
            txpassword.Text = "";
            checktype.Text = "";
        }
        bool CheckFields()
        {
            if (txuser.Text.Trim() != String.Empty && txuser.Text.Length > 3 &&
                txpassword.Text.Trim() != String.Empty && txpassword.Text.Length > 3 &&
                checktype.Text.Trim() != String.Empty && checktype.SelectedIndex > -1 && checktype.SelectedIndex < 2
                ) {
                return true;
            }
            else
            {
                return false;
            }
        }
        async Task save(User user, int operation)
        {
            if(operation == 1)
            {
                try
                {
                    if (CheckFields())
                    {
                        await service.create(user);

                        LoadUserFromAPI();
                        ClearData();
                        MessageBox.Show("Criado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    if (CheckFields())
                    {
                        await service.update(user);

                        LoadUserFromAPI();
                        ClearData();
                        MessageBox.Show("Atualizado com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
