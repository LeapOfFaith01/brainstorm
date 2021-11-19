using FastMember;
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

namespace WinFormsApp1.Forms.Sells
{
    public partial class SellForm : Form
    {
        private ICartService repo;
        private List<Vendas> localData;
        public SellForm()
        {
            InitializeComponent();
            repo = RestService.For<ICartService>("http://localhost:3000");
            Task.Run(() => LoadFromApiAsync()).Wait();
        }

        async Task LoadFromApiAsync() {
            try {
                var data = await repo.GetAllFinishedSells();

                localData = data;
                //grid.DataSource = toDataTable<Vendas>(localData);

                DataTable dt = new DataTable();
                dt.Columns.Add("#", typeof(int));
                dt.Columns.Add("Método", typeof(Method));
                dt.Columns.Add("Vendido por", typeof(string));
                dt.Columns.Add("Desconto", typeof(string));
                dt.Columns.Add("Total", typeof(string));
                dt.Columns.Add("Vendido em", typeof(DateTime));
                //DataGridStylizing

                foreach (var x in localData) {
                    if (x.user != null)
                    {
                        dt.Rows.Add(x.id, x.method, x.user.username,x.discount.ToString("c2"), x.total.ToString("c2"), x.createdAt.ToLocalTime());
                    }
                    else {
                        dt.Rows.Add(x.id, x.method,"Sem usuario", x.discount.ToString("c2"), x.total.ToString("c2"), x.createdAt);
                    }
                }
                grid.DataSource = dt;
                grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                for (int i = 1; i < grid.Columns.Count; i++)
                {
                    grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        void BuildProductTable(Vendas data)
        {
            var table = new DataTable();
            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Produto", typeof(string));
            table.Columns.Add("Quantidade", typeof(int));
            table.Columns.Add("Valor", typeof(string));
            table.Columns.Add("Total", typeof(string));

            foreach(var x in data.cart.items)
            {
                table.Rows.Add(x.product.id, x.product.nome, x.quantidade, x.valor.ToString("c2"), (x.quantidade * x.valor).ToString("c2"));
            }

            productlist.DataSource = table;

            //DataGridStylizing

            productlist.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productlist.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            //grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            for (int i = 1; i < grid.Columns.Count -1; i++)
            {
                productlist.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


        }

        DataTable toDataTable<T>(IList<T> data)
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(data, "id", "method", "total", "createdAt"))
            {
                table.Load(reader);
            }
            return table;
        }

        private void grid_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            // For any other operation except, StateChanged, do nothing
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            if(grid.SelectedRows.Count > 0)
            {
                var row = grid.Rows[grid.SelectedCells[0].RowIndex];
                var index = Convert.ToInt32(row.Cells["#"].Value);

                var data = localData.Find(x => x.id == index);
				BuildProductTable(data);
			}
        }

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
