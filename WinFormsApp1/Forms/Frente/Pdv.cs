using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Forms.Login;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms.Frente
{
    public partial class Pdv : Form
    {
        private List<Items> cart;
        private IProductService _products;
        private ICartService cartService;
        private List<ProductResponse> response;
        private float cartTotal;
        private float discount;
        private float cartvalue;
        public Pdv()
        {
            InitializeComponent();
            cart = new List<Items>();
            response = new List<ProductResponse>();
            _products = RestService.For<IProductService>("http://localhost:3000");
            cartService = RestService.For<ICartService>("http://localhost:3000");
            InitializeDataSource();
            Task.Run(() => LoadProductsAsync()).Wait();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{DateTime.Now.ToLongDateString()}  {DateTime.Now.ToShortTimeString()}";
        }

        private void Pdv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                    if (MessageBox.Show("Você está fechando o programa...", "Tem certeza que deseja sair?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Close();
                    }
                

            }
            else if (e.KeyCode == Keys.F7)
            {

                MessageBox.Show("Abrir produtos");

            }
            else if(e.KeyCode == Keys.F5)
            {


                    MessageBox.Show("Atualizar lista de produtos"); 
                
            }else if(e.KeyCode == Keys.Enter)
            {

                    AddToCart();
                
            }else if(e.KeyCode == Keys.F12)
            {
                CheckOut();
            }else if(e.KeyCode == Keys.Delete)
            {
                RemoveFromCart();
            }
        }
        async Task CheckOut()
        {
            try
            {
                if (discount > cartTotal)
                {
                    MessageBox.Show("Não é possivel finalizar essa venda");
                }
                else {
                    var method = new FecharVenda();
                    if (method.ShowDialog() == DialogResult.OK)
                    {
                        var result = method.method;

                        method.Dispose();
                        var compose = new CompositeResponse();
                        compose.items = cart;
                        compose.user = LoginForm.usuario;
                        //Passa o desconto para a API
                        compose.discount = discount;
                        await cartService.Checkout(compose, result);

                        cart = new List<Items>();

                        InitializeDataSource();
                        discount = 0;
                        ApplyDiscount();

                        MessageBox.Show("Venda finalizada com sucesso!");
                    }
                }
                
                ;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void InitializeDataSource() {
            DataTable table = new DataTable();
            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Quantidade", typeof(int));
            table.Columns.Add("Valor", typeof(string));
            table.Columns.Add("Total", typeof(string));

            grid.DataSource = table;

            grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            busca.Focus();
            busca.Select();

            total.Text = "Total: R$ 00.00";
        }

        private void AddToCart() {
            if(busca.Text != String.Empty)
            {
                var index = response.FindIndex(x => x.id == Convert.ToInt32(busca.Text));

                if(index != -1)
                {
                    var item = new Items();

                    item.product = response[index];

                    

                    item.valor = response[index].valor;

                    

                    busca.Text = "";
                    var form = new QuantidadeForm("Quantidade","Quantidade: ","Adicionar",false);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        item.quantidade = form.quantidade;
                        cart.Add(item);
                        form.Dispose();
                        RefreshTable();
                        ApplyDiscount();
                        
                    }   
                }
            }
            else
            {
                var form = new ProductSearch(response);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var item = new Items();
                    item.product = form.product;
                    item.valor = form.product.valor;

                    form.Dispose();
                    var qtForm = new QuantidadeForm("Quantidade","Quantidade:","Adicionar",false);
                    if (qtForm.ShowDialog() == DialogResult.OK)
                    {
                        item.quantidade = qtForm.quantidade;
                        cart.Add(item);
                        qtForm.Dispose();
                        RefreshTable();
                        ApplyDiscount();
                    }
                }
            }
        }

        private void RemoveFromCart() {
            if(cart.Count > 0)
            {
                var qtForm = new QuantidadeForm("Remover", "Indice", "Remover",true);
                if(qtForm.ShowDialog() == DialogResult.OK)
                {
                    var index = qtForm.quantidade;
                    if(index == 0)
                    {
                        cart.Clear();
                    }
                    else
                    {
                        cart.RemoveAt(index - 1);
                    }
                    

                    qtForm.Dispose();
                    RefreshTable();
                    ApplyDiscount();
                }
            }
            
        }

        async Task LoadProductsAsync()
        {
            try
            {
                var data = await _products.GetProducts();

                if (response.Count > 0)
                {
                    response.Clear();
                    response.AddRange(data);
                }
                else
                {
                    response.AddRange(data);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Falha ao carregar os produtos");
                Close();
            }
        }
        void RefreshTable() {
            DataTable table = new DataTable();
            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Nome", typeof(string));
            table.Columns.Add("Quantidade", typeof(int));
            table.Columns.Add("Valor", typeof(string));
            table.Columns.Add("Total", typeof(string));

            grid.DataSource = table;

            grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            float valor = 0.00f;
            for (int i = 0; i < cart.Count; i++) {
                valor += (cart[i].quantidade * cart[i].valor);
                table.Rows.Add(i+1, cart[i].product.nome, cart[i].quantidade, cart[i].valor.ToString("c2"),(cart[i].quantidade * cart[i].valor).ToString("c2"));
            }
            total.Text = $"Total: {valor.ToString("c2")}";
            cartTotal = valor;
            
        }

        private void recebido_TextChanged(object sender, EventArgs e)
        {
            if(recebido.Text != String.Empty)
            {
                ApplyDiscount();
                //if (float.Parse(recebido.Text) > cartTotal) {
                //    //troco.Text = "Troco: " +(float.Parse(recebido.Text) - cartTotal).ToString("c2");
                //    ApplyDiscount();
                //}
                //else
                //{
                //    troco.Text = "";
                //}
            }
            else
            {
                troco.Text = "R$: 00,00";
            }
        }

        private void recebido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void busca_TextChanged(object sender, EventArgs e)
        {
            if(busca.Text != String.Empty)
            {
                var index = response.FindIndex(x => x.id == Convert.ToInt32(busca.Text));
                if(index != -1)
                {
                    nomeproduto.Text = response[index].nome;
                }
            }
            else
            {
                nomeproduto.Text = "NOME DO PRODUTO";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != String.Empty)
            {
                RefreshTable();
                ApplyDiscount();
            }
            else
            {
                RefreshTable();
                ApplyDiscount();
            }
        }

        private void ApplyDiscount() {
            float valor= 0;
            if(textBox1.Text == String.Empty)
            {
                valor = 0;
            }
            else{
                valor = float.Parse(textBox1.Text);
            }
            //DESCONTO
            discount = valor;
            //VALOR DO CARRINHO
            cartvalue = cartTotal - discount;
            if(recebido.Text != string.Empty)
            {
                //VALOR RECEBIDO - (VALOR TOTAL - DISCONTO)
                //Subtrai o valor total do carrinho pelo valor do desconto
                //Subtrai do valor recebido para dar o valor do troco
                var tem = float.Parse(recebido.Text);
                troco.Text = $"Troco: {(tem - cartvalue).ToString("c2")}";
            }
            total.Text = $"Total: {cartvalue.ToString("c2")}";
        }
    }
}
