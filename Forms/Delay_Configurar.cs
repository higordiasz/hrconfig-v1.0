using HRConfig.Model;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HRConfig.Forms
{
    public partial class Delay_Configurar : Form
    {
        public Delay_Configurar()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delay_Configurar_Load(object sender, EventArgs e)
        {
            var filter = Builders<Account>.Filter.Eq("Email", Program.Email);
            Account conta = Program.Collection.Find(filter).FirstOrDefault();
            if (conta != null)
            {
                if (conta.Delay_a != 0)
                {
                    nud_da.Value = conta.Delay_a / 1000;
                } else
                {
                    nud_da.Value = 0;
                }
                if (conta.Delay_b != 0)
                {
                    nud_delayb.Value = conta.Delay_b / 1000;
                }
                else
                {
                    nud_delayb.Value = 0;
                }
                if (conta.Delay_c != 0)
                {
                    nud_dc.Value = conta.Delay_c / 1000;
                } else
                {
                    nud_dc.Value = 0;
                }
                if (conta.Delay_block != 0)
                {
                  if ((conta.Delay_block / 3600000) > 24)
                    {
                        nud_block.Value = 24;
                    } else
                    {
                        nud_block.Value = conta.Delay_block / 3600000;
                    }
                }
                else
                {
                    nud_block.Value = 1;
                }
                if (conta.Qtd != 0 )
                {
                    nud_qtd.Value = conta.Qtd;
                } else
                {
                    nud_qtd.Value = 0;
                }
            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (nud_da.Value <= 0 || nud_dc.Value <= 0 || nud_qtd.Value <= 0 )
            {
                string message = "Os campos não podem possuir valor menor que 1!";
                string caption = "Erro ao tentar alterar a configuração.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
            } else
            {
                var filter = Builders<Account>.Filter.Where(s => s.Email == Program.Email);
                if (Program.Collection.Find(filter).FirstOrDefault() != null)
                {
                    var update = Builders<Account>.Update.Set("Delay_a", nud_da.Value * 1000).Set("Delay_b", nud_delayb.Value * 1000).Set("Delay_c", nud_dc.Value * 1000).Set("Delay_block", nud_block.Value * 3600000).Set("Qtd", nud_qtd.Value);
                    Program.Collection.UpdateOne(filter, update);
                    string message = "Deseja alterar novamente ?";
                    string caption = "Configuração alterada com sucesso.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        nud_da.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    string message = "Não foi possivel alterar a configuração!!";
                    string caption = "Erro.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                }
            }
        }
    }
}
