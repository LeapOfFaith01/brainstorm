
namespace WinFormsApp1.Forms
{
    partial class HomeForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.accesslabel = new System.Windows.Forms.Label();
			this.pdv = new System.Windows.Forms.Button();
			this.btUsuarios = new System.Windows.Forms.Button();
			this.btVendas = new System.Windows.Forms.Button();
			this.btEstoque = new System.Windows.Forms.Button();
			this.btClientes = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.exitApp = new System.Windows.Forms.Button();
			this.dateTimeLabel = new System.Windows.Forms.Label();
			this.dateTicker = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.accesslabel);
			this.panel1.Controls.Add(this.pdv);
			this.panel1.Controls.Add(this.btUsuarios);
			this.panel1.Controls.Add(this.btVendas);
			this.panel1.Controls.Add(this.btEstoque);
			this.panel1.Controls.Add(this.btClientes);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1264, 64);
			this.panel1.TabIndex = 0;
			// 
			// accesslabel
			// 
			this.accesslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.accesslabel.AutoSize = true;
			this.accesslabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.accesslabel.Location = new System.Drawing.Point(1077, 12);
			this.accesslabel.Name = "accesslabel";
			this.accesslabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.accesslabel.Size = new System.Drawing.Size(175, 38);
			this.accesslabel.TabIndex = 2;
			this.accesslabel.Text = "Entrou como: Luis Eduardo\r\nNivel de acesso: ADMIN";
			this.accesslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pdv
			// 
			this.pdv.Location = new System.Drawing.Point(426, 21);
			this.pdv.Name = "pdv";
			this.pdv.Size = new System.Drawing.Size(88, 23);
			this.pdv.TabIndex = 4;
			this.pdv.Text = "Vender (F12)";
			this.pdv.UseVisualStyleBackColor = true;
			this.pdv.Click += new System.EventHandler(this.pdv_Click);
			// 
			// btUsuarios
			// 
			this.btUsuarios.Location = new System.Drawing.Point(324, 21);
			this.btUsuarios.Name = "btUsuarios";
			this.btUsuarios.Size = new System.Drawing.Size(96, 23);
			this.btUsuarios.TabIndex = 3;
			this.btUsuarios.Text = "Usuarios";
			this.btUsuarios.UseVisualStyleBackColor = true;
			this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
			// 
			// btVendas
			// 
			this.btVendas.Location = new System.Drawing.Point(222, 21);
			this.btVendas.Name = "btVendas";
			this.btVendas.Size = new System.Drawing.Size(96, 23);
			this.btVendas.TabIndex = 2;
			this.btVendas.Text = "Vendas (F7)";
			this.btVendas.UseVisualStyleBackColor = true;
			this.btVendas.Click += new System.EventHandler(this.btVendas_Click);
			// 
			// btEstoque
			// 
			this.btEstoque.Location = new System.Drawing.Point(120, 21);
			this.btEstoque.Name = "btEstoque";
			this.btEstoque.Size = new System.Drawing.Size(96, 23);
			this.btEstoque.TabIndex = 1;
			this.btEstoque.Text = "Estoque (F2)";
			this.btEstoque.UseVisualStyleBackColor = true;
			this.btEstoque.Click += new System.EventHandler(this.btEstoque_Click);
			// 
			// btClientes
			// 
			this.btClientes.Enabled = false;
			this.btClientes.Location = new System.Drawing.Point(18, 21);
			this.btClientes.Name = "btClientes";
			this.btClientes.Size = new System.Drawing.Size(96, 23);
			this.btClientes.TabIndex = 0;
			this.btClientes.Text = "Clientes";
			this.btClientes.UseVisualStyleBackColor = true;
			this.btClientes.Click += new System.EventHandler(this.btClientes_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.exitApp);
			this.panel2.Controls.Add(this.dateTimeLabel);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 643);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1264, 38);
			this.panel2.TabIndex = 1;
			// 
			// exitApp
			// 
			this.exitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.exitApp.Location = new System.Drawing.Point(18, 7);
			this.exitApp.Name = "exitApp";
			this.exitApp.Size = new System.Drawing.Size(75, 23);
			this.exitApp.TabIndex = 1;
			this.exitApp.Text = "Sair";
			this.exitApp.UseVisualStyleBackColor = true;
			this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
			// 
			// dateTimeLabel
			// 
			this.dateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.dateTimeLabel.AutoSize = true;
			this.dateTimeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.dateTimeLabel.Location = new System.Drawing.Point(964, 10);
			this.dateTimeLabel.Name = "dateTimeLabel";
			this.dateTimeLabel.Size = new System.Drawing.Size(297, 19);
			this.dateTimeLabel.TabIndex = 0;
			this.dateTimeLabel.Text = "Segunda-Feira, 04 de outubro de 2021 06:10";
			// 
			// dateTicker
			// 
			this.dateTicker.Enabled = true;
			this.dateTicker.Interval = 500;
			this.dateTicker.Tick += new System.EventHandler(this.dateTicker_Tick);
			// 
			// HomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.KeyPreview = true;
			this.Name = "HomeForm";
			this.Text = "BrainStorm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeForm_FormClosed);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HomeForm_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer dateTicker;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Label dateTimeLabel;
        private System.Windows.Forms.Button pdv;
        private System.Windows.Forms.Button btUsuarios;
        private System.Windows.Forms.Button btVendas;
        private System.Windows.Forms.Button btEstoque;
        private System.Windows.Forms.Button btClientes;
        private System.Windows.Forms.Label accesslabel;
	}
}