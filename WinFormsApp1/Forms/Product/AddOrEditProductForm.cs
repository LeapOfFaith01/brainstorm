using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms.Product
{
    public partial class AddOrEditProductForm : Form
    {
        private ProductResponse product;
        private IProductService rest;
        public AddOrEditProductForm(int? id)
        {
            InitializeComponent();
            rest = RestService.For<IProductService>("http://localhost:3000");

            if (id != null) {
                //TrySearchOnDatabase
                product = new ProductResponse();
                product.id = (int)id;
                Task.Run(() => LoadFromAPI()).Wait();
            }
            else
            {
                //Create a new instance
                product = new ProductResponse();
                product.createdAt = DateTime.Now;
                product.updatedAt = DateTime.Now;
            }
        }

        public AddOrEditProductForm()
        {
            InitializeComponent();
        }

        private void SaveOrUpdate() {
            product.id = int.Parse(txCod.Text);
            product.nome = txNome.Text;
            product.custo = float.Parse(txCusto.Text);
            product.lucro = float.Parse(txLucro.Text);
            product.valor = float.Parse(txVenda.Text);
            product.active = checkActive.Checked;
            product.qnt = int.Parse(txQt.Text);
        }

        async private Task LoadFromAPI() {
            try {
                var data = await rest.GetProduct(product.id);

                product = data;

                LoadFromModel();


            } catch (Exception ex) { }
        }

        void LoadFromModel() {
            txCod.Text = product.id.ToString()??"";
            txNome.Text = product.nome??"";
            txCusto.Text = product.custo.ToString()??"";
            txLucro.Text = product.lucro.ToString()??"";
            txVenda.Text = product.valor.ToString()??"";
            checkActive.Checked = product.active;
            txQt.Text = product.qnt.ToString()??"";
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if(Login.LoginForm.usuario.type == Models.Type.EMPLOYEE)
            {
                if(int.Parse(txQt.Text) != product.qnt)
                {
                    if (product.userUpdate != null)
                    {
                        if (product.updatedAt != null && product.updatedAt.ToShortDateString() == DateTime.UtcNow.ToShortDateString() && product.userUpdate.id == Login.LoginForm.usuario.id)
                        {
                            MessageBox.Show("Você não pode mais alterar a quantidade hoje");
                        }
                        else
                        {
                            Save();
                        }
                    }
                    else { Save(); }
                }
                else
                {
                    Save();
                }
            }
            else
            {
                Save();
            }
            
        }

        async private Task Save() {
            try {

                SaveOrUpdate();
                product.updatedAt = DateTime.Now;
                product.userUpdate = Login.LoginForm.usuario;
                var data = await rest.SaveOrUpdate(product.id, product);

                DialogResult = DialogResult.OK;
            } catch (Exception ex) {
                MessageBox.Show("Falha ao salvar alterações");
                DialogResult = DialogResult.Abort;
            }
        }

        private void OnlyDecimalNumberFilter(object sender, KeyPressEventArgs e)
        {
            // allows 0-9, backspace, and decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 44))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 44)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
    }
}
