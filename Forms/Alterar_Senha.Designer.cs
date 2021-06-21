namespace HRConfig.Forms
{
    partial class Alterar_Senha
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
            this.tx_atual = new System.Windows.Forms.TextBox();
            this.tx_nova = new System.Windows.Forms.TextBox();
            this.tx_confirmar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_atual
            // 
            this.tx_atual.Location = new System.Drawing.Point(114, 18);
            this.tx_atual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_atual.Name = "tx_atual";
            this.tx_atual.PasswordChar = '*';
            this.tx_atual.Size = new System.Drawing.Size(148, 26);
            this.tx_atual.TabIndex = 0;
            // 
            // tx_nova
            // 
            this.tx_nova.Location = new System.Drawing.Point(114, 52);
            this.tx_nova.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_nova.Name = "tx_nova";
            this.tx_nova.PasswordChar = '*';
            this.tx_nova.Size = new System.Drawing.Size(148, 26);
            this.tx_nova.TabIndex = 1;
            // 
            // tx_confirmar
            // 
            this.tx_confirmar.Location = new System.Drawing.Point(114, 86);
            this.tx_confirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_confirmar.Name = "tx_confirmar";
            this.tx_confirmar.PasswordChar = '*';
            this.tx_confirmar.Size = new System.Drawing.Size(148, 26);
            this.tx_confirmar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Senha Atual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nova Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Repitir Senha:";
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(88, 131);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(81, 33);
            this.bt_salvar.TabIndex = 6;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // Alterar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 176);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_confirmar);
            this.Controls.Add(this.tx_nova);
            this.Controls.Add(this.tx_atual);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alterar_Senha";
            this.Text = "Alterar_Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_atual;
        private System.Windows.Forms.TextBox tx_nova;
        private System.Windows.Forms.TextBox tx_confirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_salvar;
    }
}