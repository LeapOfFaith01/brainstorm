
namespace WinFormsApp1.Forms.Product
{
    partial class AddOrEditProductForm
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
            this.txCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txCusto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txLucro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txQt = new System.Windows.Forms.TextBox();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txCod
            // 
            this.txCod.Location = new System.Drawing.Point(70, 6);
            this.txCod.Name = "txCod";
            this.txCod.Size = new System.Drawing.Size(168, 25);
            this.txCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(70, 55);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(441, 25);
            this.txNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Custo:";
            // 
            // txCusto
            // 
            this.txCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCusto.Location = new System.Drawing.Point(70, 104);
            this.txCusto.Name = "txCusto";
            this.txCusto.Size = new System.Drawing.Size(102, 25);
            this.txCusto.TabIndex = 4;
            this.txCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDecimalNumberFilter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lucro: %";
            // 
            // txLucro
            // 
            this.txLucro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txLucro.Location = new System.Drawing.Point(247, 104);
            this.txLucro.Name = "txLucro";
            this.txLucro.Size = new System.Drawing.Size(68, 25);
            this.txLucro.TabIndex = 6;
            this.txLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDecimalNumberFilter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor de Venda:";
            // 
            // txVenda
            // 
            this.txVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txVenda.Location = new System.Drawing.Point(425, 104);
            this.txVenda.Name = "txVenda";
            this.txVenda.Size = new System.Drawing.Size(86, 25);
            this.txVenda.TabIndex = 8;
            this.txVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyDecimalNumberFilter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantidade:";
            // 
            // txQt
            // 
            this.txQt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txQt.Location = new System.Drawing.Point(331, 6);
            this.txQt.Name = "txQt";
            this.txQt.Size = new System.Drawing.Size(70, 25);
            this.txQt.TabIndex = 10;
            // 
            // checkActive
            // 
            this.checkActive.AutoSize = true;
            this.checkActive.Location = new System.Drawing.Point(441, 9);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(70, 21);
            this.checkActive.TabIndex = 14;
            this.checkActive.Text = "Ativo ?";
            this.checkActive.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(436, 166);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 15;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // AddOrEditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 210);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.checkActive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txQt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txLucro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txCusto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCod);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "AddOrEditProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar ou Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCusto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txLucro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txQt;
        private System.Windows.Forms.CheckBox checkActive;
        private System.Windows.Forms.Button btSave;
    }
}