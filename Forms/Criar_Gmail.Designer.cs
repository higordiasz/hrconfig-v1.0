namespace HRConfig.Forms
{
    partial class Criar_Gmail
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
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_criar = new System.Windows.Forms.TextBox();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_qtd = new System.Windows.Forms.NumericUpDown();
            this.bt_criar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tx_qtd)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_email
            // 
            this.tx_email.Location = new System.Drawing.Point(138, 43);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(222, 26);
            this.tx_email.TabIndex = 0;
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(138, 75);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.Size = new System.Drawing.Size(222, 26);
            this.tx_senha.TabIndex = 1;
            // 
            // tx_criar
            // 
            this.tx_criar.Location = new System.Drawing.Point(138, 107);
            this.tx_criar.Name = "tx_criar";
            this.tx_criar.Size = new System.Drawing.Size(222, 26);
            this.tx_criar.TabIndex = 2;
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(138, 139);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(222, 26);
            this.tx_nome.TabIndex = 3;
            // 
            // tx_qtd
            // 
            this.tx_qtd.Location = new System.Drawing.Point(138, 171);
            this.tx_qtd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tx_qtd.Name = "tx_qtd";
            this.tx_qtd.Size = new System.Drawing.Size(109, 26);
            this.tx_qtd.TabIndex = 4;
            // 
            // bt_criar
            // 
            this.bt_criar.Location = new System.Drawing.Point(161, 225);
            this.bt_criar.Name = "bt_criar";
            this.bt_criar.Size = new System.Drawing.Size(86, 32);
            this.bt_criar.TabIndex = 5;
            this.bt_criar.Text = "Criar";
            this.bt_criar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seu Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sua Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email para Criar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Criador de Gmail HRMoney";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Maximo 10";
            // 
            // Criar_Gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 286);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_criar);
            this.Controls.Add(this.tx_qtd);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.tx_criar);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_email);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Criar_Gmail";
            this.Text = "Criar_Gmail";
            this.Load += new System.EventHandler(this.Criar_Gmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tx_qtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.TextBox tx_criar;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.NumericUpDown tx_qtd;
        private System.Windows.Forms.Button bt_criar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}