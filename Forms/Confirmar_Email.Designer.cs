namespace HRConfig.Forms
{
    partial class Confirmar_Email
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
            this.tx_codigo = new System.Windows.Forms.TextBox();
            this.bt_confirmar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bt_confirmar)).BeginInit();
            this.SuspendLayout();
            // 
            // tx_codigo
            // 
            this.tx_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.tx_codigo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_codigo.ForeColor = System.Drawing.Color.White;
            this.tx_codigo.Location = new System.Drawing.Point(32, 110);
            this.tx_codigo.Name = "tx_codigo";
            this.tx_codigo.Size = new System.Drawing.Size(357, 35);
            this.tx_codigo.TabIndex = 1;
            // 
            // bt_confirmar
            // 
            this.bt_confirmar.BackColor = System.Drawing.Color.Transparent;
            this.bt_confirmar.BackgroundImage = global::HRConfig.Properties.Resources.Confirmar_normal;
            this.bt_confirmar.Location = new System.Drawing.Point(122, 173);
            this.bt_confirmar.Name = "bt_confirmar";
            this.bt_confirmar.Size = new System.Drawing.Size(168, 26);
            this.bt_confirmar.TabIndex = 3;
            this.bt_confirmar.TabStop = false;
            this.bt_confirmar.Click += new System.EventHandler(this.bt_confirmar_Click);
            this.bt_confirmar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_confirmar_MouseDown);
            this.bt_confirmar.MouseLeave += new System.EventHandler(this.bt_confirmar_MouseLeave);
            this.bt_confirmar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bt_confirmar_MouseMove);
            // 
            // Confirmar_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.BackgroundImage = global::HRConfig.Properties.Resources.Confirme_codigo;
            this.ClientSize = new System.Drawing.Size(418, 223);
            this.Controls.Add(this.bt_confirmar);
            this.Controls.Add(this.tx_codigo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Confirmar_Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmar Email";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.Load += new System.EventHandler(this.Confirmar_Email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bt_confirmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx_codigo;
        private System.Windows.Forms.PictureBox bt_confirmar;
    }
}