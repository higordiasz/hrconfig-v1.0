namespace HRConfig.Forms
{
    partial class Deletar_Instagram
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
            this.tx_conta = new System.Windows.Forms.TextBox();
            this.bt_deletar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conta:";
            // 
            // tx_conta
            // 
            this.tx_conta.Location = new System.Drawing.Point(75, 30);
            this.tx_conta.Margin = new System.Windows.Forms.Padding(4);
            this.tx_conta.Name = "tx_conta";
            this.tx_conta.Size = new System.Drawing.Size(173, 26);
            this.tx_conta.TabIndex = 1;
            // 
            // bt_deletar
            // 
            this.bt_deletar.Location = new System.Drawing.Point(16, 91);
            this.bt_deletar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_deletar.Name = "bt_deletar";
            this.bt_deletar.Size = new System.Drawing.Size(112, 32);
            this.bt_deletar.TabIndex = 2;
            this.bt_deletar.Text = "Deletar";
            this.bt_deletar.UseVisualStyleBackColor = true;
            this.bt_deletar.Click += new System.EventHandler(this.bt_deletar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(136, 91);
            this.bt_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(112, 32);
            this.bt_cancelar.TabIndex = 3;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // Deletar_Instagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 145);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_deletar);
            this.Controls.Add(this.tx_conta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Deletar_Instagram";
            this.Text = "Deletar Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_conta;
        private System.Windows.Forms.Button bt_deletar;
        private System.Windows.Forms.Button bt_cancelar;
    }
}