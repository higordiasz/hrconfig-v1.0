namespace HRConfig.Forms
{
    partial class Gmailnator
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
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.tx_usuario = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(85, 13);
            this.tx_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(217, 26);
            this.tx_nome.TabIndex = 0;
            // 
            // tx_usuario
            // 
            this.tx_usuario.Location = new System.Drawing.Point(85, 46);
            this.tx_usuario.Name = "tx_usuario";
            this.tx_usuario.Size = new System.Drawing.Size(217, 26);
            this.tx_usuario.TabIndex = 1;
            // 
            // tx_senha
            // 
            this.tx_senha.Location = new System.Drawing.Point(85, 78);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.Size = new System.Drawing.Size(217, 26);
            this.tx_senha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // bt_create
            // 
            this.bt_create.Location = new System.Drawing.Point(108, 128);
            this.bt_create.Name = "bt_create";
            this.bt_create.Size = new System.Drawing.Size(86, 37);
            this.bt_create.TabIndex = 6;
            this.bt_create.Text = "Criar";
            this.bt_create.UseVisualStyleBackColor = true;
            this.bt_create.Click += new System.EventHandler(this.Bt_create_Click);
            // 
            // Gmailnator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 177);
            this.Controls.Add(this.bt_create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_usuario);
            this.Controls.Add(this.tx_nome);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gmailnator";
            this.Text = "Gmailnator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox tx_usuario;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_create;
    }
}