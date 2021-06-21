namespace HRConfig.Forms
{
    partial class Challenge
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_opcao = new System.Windows.Forms.ComboBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caso opite por selecionar True, Durante a execução";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sera pedido para informar o código do Challenge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione uma Opção:";
            // 
            // cb_opcao
            // 
            this.cb_opcao.FormattingEnabled = true;
            this.cb_opcao.Location = new System.Drawing.Point(185, 68);
            this.cb_opcao.Name = "cb_opcao";
            this.cb_opcao.Size = new System.Drawing.Size(184, 26);
            this.cb_opcao.TabIndex = 4;
            this.cb_opcao.Text = "Selecione uma opção";
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(137, 112);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(88, 25);
            this.bt_salvar.TabIndex = 5;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // Challenge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 149);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.cb_opcao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Challenge";
            this.Text = "Challenge";
            this.Load += new System.EventHandler(this.Challenge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_opcao;
        private System.Windows.Forms.Button bt_salvar;
    }
}