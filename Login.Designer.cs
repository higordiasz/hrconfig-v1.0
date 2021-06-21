namespace HRConfig
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tx_email = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.lb_sair = new System.Windows.Forms.Label();
            this.lb_versao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_email
            // 
            this.tx_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tx_email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_email.ForeColor = System.Drawing.Color.White;
            this.tx_email.Location = new System.Drawing.Point(27, 254);
            this.tx_email.Margin = new System.Windows.Forms.Padding(4);
            this.tx_email.Name = "tx_email";
            this.tx_email.Size = new System.Drawing.Size(361, 35);
            this.tx_email.TabIndex = 0;
            // 
            // tx_senha
            // 
            this.tx_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tx_senha.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_senha.ForeColor = System.Drawing.Color.White;
            this.tx_senha.Location = new System.Drawing.Point(27, 325);
            this.tx_senha.Margin = new System.Windows.Forms.Padding(4);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.PasswordChar = '*';
            this.tx_senha.Size = new System.Drawing.Size(361, 35);
            this.tx_senha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Registrar-se";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 535);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Esqueci minha senha";
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.Color.Transparent;
            this.pb_login.Image = global::HRConfig.Properties.Resources.Login_normal;
            this.pb_login.Location = new System.Drawing.Point(42, 427);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(330, 53);
            this.pb_login.TabIndex = 8;
            this.pb_login.TabStop = false;
            this.pb_login.Click += new System.EventHandler(this.bt_login_Click);
            this.pb_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_login_MouseDown);
            this.pb_login.MouseLeave += new System.EventHandler(this.pb_login_MouseLeave);
            this.pb_login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_login_MouseMove);
            // 
            // lb_sair
            // 
            this.lb_sair.AutoSize = true;
            this.lb_sair.BackColor = System.Drawing.Color.Transparent;
            this.lb_sair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sair.ForeColor = System.Drawing.Color.White;
            this.lb_sair.Location = new System.Drawing.Point(12, 591);
            this.lb_sair.Name = "lb_sair";
            this.lb_sair.Size = new System.Drawing.Size(39, 19);
            this.lb_sair.TabIndex = 9;
            this.lb_sair.Text = "Sair";
            this.lb_sair.Click += new System.EventHandler(this.lb_sair_Click);
            // 
            // lb_versao
            // 
            this.lb_versao.AutoSize = true;
            this.lb_versao.BackColor = System.Drawing.Color.Transparent;
            this.lb_versao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_versao.ForeColor = System.Drawing.Color.White;
            this.lb_versao.Location = new System.Drawing.Point(360, 597);
            this.lb_versao.Name = "lb_versao";
            this.lb_versao.Size = new System.Drawing.Size(44, 16);
            this.lb_versao.TabIndex = 10;
            this.lb_versao.Text = "v1.0.0";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImage = global::HRConfig.Properties.Resources.login2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(416, 622);
            this.Controls.Add(this.lb_versao);
            this.Controls.Add(this.lb_sair);
            this.Controls.Add(this.pb_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.tx_email);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login HRMoney";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_email;
        private System.Windows.Forms.TextBox tx_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.Label lb_sair;
        private System.Windows.Forms.Label lb_versao;
    }
}

