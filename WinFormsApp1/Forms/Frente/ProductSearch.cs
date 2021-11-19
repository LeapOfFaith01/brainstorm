using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms.Frente
{
    public partial class ProductSearch : Form
    {
        public ProductResponse product;
        private List<ProductResponse> formData;
        public ProductSearch(List<ProductResponse> data)
        {
            InitializeComponent();
            formData = data;
            BuildDataTable(formData);
        }

        void BuildDataTable(List<ProductResponse> items) {
            var table = new DataTable();
            using (var reader = ObjectReader.Create(items, "id", "nome", "valor")) {
                table.Load(reader);
            }
            grid.DataSource = table;

            grid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //for(int i =0; i < items.Count; i++)
            //{
            //    grid.Rows.Add(items[i].id, items[i].nome, items[i].valor);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != String.Empty)
            {
                var filter = formData.Where(x => x.nome.ToLower().Contains(textBox1.Text.ToLower())).ToList();
                BuildDataTable(filter);
            }
            else
            {
                BuildDataTable(formData);
            }
        }

        private void ProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                //TODO - Implement Form
                if (grid.SelectedRows.Count > 0)
                {
                    var row = grid.Rows[grid.SelectedCells[0].RowIndex];

                    product = formData.Find(x => x.id == Convert.ToInt32(row.Cells["id"].Value));
                    DialogResult = DialogResult.OK;
                    Close();

                }
                else
                {
                    MessageBox.Show("Você precisa selecionar uma linha.");
                }
            }
        }
    }
}
