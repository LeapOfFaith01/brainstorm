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
using WinFormsApp1.Forms.Product;
using WinFormsApp1.Interfaces;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            Task.Run(() => LoadRepositoryAsync()).Wait();
        }
        //Load data from API async
        async Task LoadRepositoryAsync()
        {
            try
            {
                var rest = RestService.For<IProductService>("http://localhost:3000");

                var products = await rest.GetProducts();

                grid.DataSource = toDataTable<ProductResponse>(products);

                //DataGridStylizing

                grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                //grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                for (int i = 1; i < grid.Columns.Count; i++)
                {
                    grid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel carregar as informações. \nContate o admnistrador do sistema ou tente novamente mais tarde.");
                this.Close();
            }
        }
        //Convert List<T> to DataTable
        DataTable toDataTable<T>(IList<T> data)
        {
            DataTable table = new DataTable();
            using (var reader = ObjectReader.Create(data, "id", "nome", "custo", "lucro", "valor", "active", "qnt"))
            {
                table.Load(reader);
            }
            return table;
        }
        //Handle the data extraction of the selected row to open a edition form
        private void openEditor()
        {
            //TODO - Implement Form
            if (grid.SelectedRows.Count > 0)
            {
                var row = grid.Rows[grid.SelectedCells[0].RowIndex];

                openAddOrEditFormAsync(Convert.ToInt32(row.Cells["id"].Value));

            }
            else
            {
                MessageBox.Show("Você precisa selecionar uma linha.");
            }
        }
        //Button Create Click Action
        private void button1_Click(object sender, EventArgs e)
        {
            openAddOrEditFormAsync(null);
        }
        //AddOrEdit Click Handler
        async Task openAddOrEditFormAsync(int? id)
        {
            var form = new AddOrEditProductForm(id);

            if (form.ShowDialog() == DialogResult.OK)
            {
                await LoadRepositoryAsync();
            }

        }
        //Button Edit Click Action
        private void button2_Click(object sender, EventArgs e)
        {
            openEditor();
        }
    }
}
