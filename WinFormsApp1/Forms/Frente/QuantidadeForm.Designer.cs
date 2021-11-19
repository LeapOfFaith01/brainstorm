
namespace WinFormsApp1.Forms.Frente
{
    partial class QuantidadeForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btAction = new System.Windows.Forms.Button();
            this.warn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(12, 46);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(75, 17);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Quantidade";
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(85, 99);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(86, 26);
            this.btAction.TabIndex = 2;
            this.btAction.Text = "Adicionar";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // warn
            // 
            this.warn.AutoSize = true;
            this.warn.Location = new System.Drawing.Point(24, 9);
            this.warn.Name = "warn";
            this.warn.Size = new System.Drawing.Size(133, 17);
            this.warn.TabIndex = 3;
            this.warn.Text = "0 para remover todos";
            this.warn.Visible = false;
            // 
            // QuantidadeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 132);
            this.Controls.Add(this.warn);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuantidadeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantidade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QuantidadeForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.Label warn;
    }
}