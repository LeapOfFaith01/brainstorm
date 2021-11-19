
namespace WinFormsApp1.Forms.Frente
{
    partial class Pdv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nomeproduto = new System.Windows.Forms.Label();
			this.busca = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.troco = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.total = new System.Windows.Forms.Label();
			this.recebido = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.grid = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.nomeproduto);
			this.panel1.Controls.Add(this.busca);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1029, 57);
			this.panel1.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(706, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 19);
			this.label8.TabIndex = 7;
			this.label8.Text = "Remover Item - DELETE";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(624, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 19);
			this.label6.TabIndex = 6;
			this.label6.Text = "Sair - ESC";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(567, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(450, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Para buscar um produto aperte ENTER com o campo código em branco";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(877, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 19);
			this.label2.TabIndex = 4;
			this.label2.Text = "Finalizar Venda - F12";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(31, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "Código:";
			// 
			// nomeproduto
			// 
			this.nomeproduto.AutoSize = true;
			this.nomeproduto.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.nomeproduto.Location = new System.Drawing.Point(326, 13);
			this.nomeproduto.Name = "nomeproduto";
			this.nomeproduto.Size = new System.Drawing.Size(181, 27);
			this.nomeproduto.TabIndex = 2;
			this.nomeproduto.Text = "Nome do produto";
			// 
			// busca
			// 
			this.busca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.busca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.busca.Location = new System.Drawing.Point(124, 14);
			this.busca.Name = "busca";
			this.busca.PlaceholderText = "Código do produto";
			this.busca.Size = new System.Drawing.Size(194, 26);
			this.busca.TabIndex = 1;
			this.busca.TextChanged += new System.EventHandler(this.busca_TextChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.troco);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.total);
			this.panel2.Controls.Add(this.recebido);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 480);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1029, 90);
			this.panel2.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 19);
			this.label7.TabIndex = 8;
			this.label7.Text = "Desconto:";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textBox1.Location = new System.Drawing.Point(88, 11);
			this.textBox1.Name = "textBox1";
			this.textBox1.PlaceholderText = "Desconto";
			this.textBox1.Size = new System.Drawing.Size(146, 26);
			this.textBox1.TabIndex = 7;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recebido_KeyPress);
			// 
			// troco
			// 
			this.troco.AutoSize = true;
			this.troco.Location = new System.Drawing.Point(275, 59);
			this.troco.Name = "troco";
			this.troco.Size = new System.Drawing.Size(113, 19);
			this.troco.TabIndex = 6;
			this.troco.Text = "Troco: R$: 00.00";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 19);
			this.label5.TabIndex = 5;
			this.label5.Text = "Valor Recebido:";
			// 
			// total
			// 
			this.total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.total.AutoSize = true;
			this.total.Location = new System.Drawing.Point(412, 59);
			this.total.Name = "total";
			this.total.Size = new System.Drawing.Size(104, 19);
			this.total.TabIndex = 4;
			this.total.Text = "Total: R$ 00.00";
			// 
			// recebido
			// 
			this.recebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.recebido.Location = new System.Drawing.Point(124, 56);
			this.recebido.Name = "recebido";
			this.recebido.PlaceholderText = "Valor recebido";
			this.recebido.Size = new System.Drawing.Size(134, 26);
			this.recebido.TabIndex = 1;
			this.recebido.TextChanged += new System.EventHandler(this.recebido_TextChanged);
			this.recebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.recebido_KeyPress);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(717, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(309, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Segunda-Feira, 15 de Outubro de 2021 16:44:55";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.grid);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 57);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1029, 423);
			this.panel3.TabIndex = 5;
			// 
			// grid
			// 
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(7);
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.EnableHeadersVisualStyles = false;
			this.grid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.grid.RowHeadersVisible = false;
			this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.MenuText;
			this.grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.grid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
			this.grid.RowTemplate.Height = 35;
			this.grid.RowTemplate.ReadOnly = true;
			this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid.ShowCellErrors = false;
			this.grid.ShowCellToolTips = false;
			this.grid.ShowEditingIcon = false;
			this.grid.ShowRowErrors = false;
			this.grid.Size = new System.Drawing.Size(1029, 423);
			this.grid.StandardTab = true;
			this.grid.TabIndex = 3;
			// 
			// Pdv
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1029, 570);
			this.ControlBox = false;
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Pdv";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pdv";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pdv_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox recebido;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label nomeproduto;
        private System.Windows.Forms.TextBox busca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label troco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}