namespace HRConfig.Forms
{
    partial class Cadastrar_Instagram
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
            this.tx_conta = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_conta
            // 
            this.tx_conta.Location = new System.Drawing.Point(65, 26);
            this.tx_conta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tx_conta.Name = "tx_conta";
            this.tx_conta.Size = new System.Drawing.Size(141, 22);
            this.tx_conta.TabIndex = 0;
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(65, 58);
            this.tx_senha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.Size = new System.Drawing.Size(141, 22);
            this.tx_senha.TabIndex = 1;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(10, 90);
            this.bt_salvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(87, 28);
            this.bt_salvar.TabIndex = 2;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(119, 90);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(87, 28);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Conta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // Cadastrar_Instagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 137);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_conta);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cadastrar_Instagram";
            this.Text = "Cadastrar Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_conta;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}