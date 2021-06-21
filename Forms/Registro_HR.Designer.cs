namespace HRConfig.Forms
{
    partial class Registro_HR
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
            this.tx_cemail = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.tx_csenha = new System.Windows.Forms.TextBox();
            this.bt_registrar = new System.Windows.Forms.PictureBox();
            this.lb_cancelar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bt_registrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.tx_email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.ForeColor = System.Drawing.Color.White;
            this.tx_email.Location = new System.Drawing.Point(26, 252);
            this.tx_email.Margin = new System.Windows.Forms.Padding(4);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(366, 35);
            this.tx_email.TabIndex = 0;
            // 
            // tx_cemail
            // 
            this.tx_cemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.tx_cemail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cemail.ForeColor = System.Drawing.Color.White;
            this.tx_cemail.Location = new System.Drawing.Point(26, 323);
            this.tx_cemail.Margin = new System.Windows.Forms.Padding(4);
            this.tx_cemail.Name = "tx_cemail";
            this.tx_cemail.Size = new System.Drawing.Size(366, 35);
            this.tx_cemail.TabIndex = 1;
            this.tx_cemail.TextChanged += new System.EventHandler(this.tx_cemail_TextChanged);
            // 
            // tx_senha
            // 
            this.tx_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.tx_senha.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_senha.ForeColor = System.Drawing.Color.White;
            this.tx_senha.Location = new System.Drawing.Point(26, 392);
            this.tx_senha.Margin = new System.Windows.Forms.Padding(4);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.Size = new System.Drawing.Size(366, 35);
            this.tx_senha.TabIndex = 2;
            // 
            // tx_csenha
            // 
            this.tx_csenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.tx_csenha.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_csenha.ForeColor = System.Drawing.Color.White;
            this.tx_csenha.Location = new System.Drawing.Point(26, 462);
            this.tx_csenha.Name = "tx_csenha";
            this.tx_csenha.PasswordChar = '*';
            this.tx_csenha.Size = new System.Drawing.Size(366, 35);
            this.tx_csenha.TabIndex = 7;
            // 
            // bt_registrar
            // 
            this.bt_registrar.BackColor = System.Drawing.Color.Transparent;
            this.bt_registrar.BackgroundImage = global::HRConfig.Properties.Resources.Registro_normal;
            this.bt_registrar.Location = new System.Drawing.Point(44, 523);
            this.bt_registrar.Name = "bt_registrar";
            this.bt_registrar.Size = new System.Drawing.Size(330, 50);
            this.bt_registrar.TabIndex = 11;
            this.bt_registrar.TabStop = false;
            this.bt_registrar.Click += new System.EventHandler(this.bt_registrar_Click);
            this.bt_registrar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registro_HR_MouseDown);
            this.bt_registrar.MouseLeave += new System.EventHandler(this.Registro_HR_MouseLeave);
            this.bt_registrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_registrar_MouseMove);
            // 
            // lb_cancelar
            // 
            this.lb_cancelar.AutoSize = true;
            this.lb_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.lb_cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cancelar.ForeColor = System.Drawing.Color.White;
            this.lb_cancelar.Location = new System.Drawing.Point(19, 616);
            this.lb_cancelar.Name = "lb_cancelar";
            this.lb_cancelar.Size = new System.Drawing.Size(77, 19);
            this.lb_cancelar.TabIndex = 12;
            this.lb_cancelar.Text = "Cancelar";
            this.lb_cancelar.Click += new System.EventHandler(this.lb_cancelar_Click);
            // 
            // Registro_HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.BackgroundImage = global::HRConfig.Properties.Resources.Registro2;
            this.ClientSize = new System.Drawing.Size(416, 648);
            this.Controls.Add(this.lb_cancelar);
            this.Controls.Add(this.bt_registrar);
            this.Controls.Add(this.tx_csenha);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_cemail);
            this.Controls.Add(this.tx_email);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registro_HR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.Load += new System.EventHandler(this.Registro_HR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bt_registrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_cemail;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.TextBox tx_csenha;
        private System.Windows.Forms.PictureBox bt_registrar;
        private System.Windows.Forms.Label lb_cancelar;
    }
}