namespace HRConfig.Forms
{
    partial class Delay_Configurar
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
            this.nud_da = new System.Windows.Forms.NumericUpDown();
            this.nud_dc = new System.Windows.Forms.NumericUpDown();
            this.nud_qtd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.nud_delayb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_block = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_da)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delayb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_block)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_da
            // 
            this.nud_da.Location = new System.Drawing.Point(173, 6);
            this.nud_da.Margin = new System.Windows.Forms.Padding(4);
            this.nud_da.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_da.Name = "nud_da";
            this.nud_da.Size = new System.Drawing.Size(75, 26);
            this.nud_da.TabIndex = 0;
            // 
            // nud_dc
            // 
            this.nud_dc.Location = new System.Drawing.Point(173, 42);
            this.nud_dc.Margin = new System.Windows.Forms.Padding(4);
            this.nud_dc.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_dc.Name = "nud_dc";
            this.nud_dc.Size = new System.Drawing.Size(163, 26);
            this.nud_dc.TabIndex = 1;
            // 
            // nud_qtd
            // 
            this.nud_qtd.Location = new System.Drawing.Point(173, 75);
            this.nud_qtd.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_qtd.Name = "nud_qtd";
            this.nud_qtd.Size = new System.Drawing.Size(163, 26);
            this.nud_qtd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delay entre ações:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Delay entre contas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade de ações:";
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(74, 147);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(92, 28);
            this.bt_salvar.TabIndex = 6;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(173, 147);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(92, 28);
            this.bt_cancelar.TabIndex = 7;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // nud_delayb
            // 
            this.nud_delayb.Location = new System.Drawing.Point(255, 6);
            this.nud_delayb.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_delayb.Name = "nud_delayb";
            this.nud_delayb.Size = new System.Drawing.Size(81, 26);
            this.nud_delayb.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "S";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "S";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Block Action:";
            // 
            // nud_block
            // 
            this.nud_block.Location = new System.Drawing.Point(173, 107);
            this.nud_block.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nud_block.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_block.Name = "nud_block";
            this.nud_block.Size = new System.Drawing.Size(163, 26);
            this.nud_block.TabIndex = 13;
            this.nud_block.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(342, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "H";
            // 
            // Delay_Configurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 187);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nud_block);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_delayb);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_qtd);
            this.Controls.Add(this.nud_dc);
            this.Controls.Add(this.nud_da);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Delay_Configurar";
            this.Text = "Configuração de Delay";
            this.Load += new System.EventHandler(this.Delay_Configurar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_da)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_dc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_qtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_delayb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_block)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_da;
        private System.Windows.Forms.NumericUpDown nud_dc;
        private System.Windows.Forms.NumericUpDown nud_qtd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.NumericUpDown nud_delayb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_block;
        private System.Windows.Forms.Label label8;
    }
}