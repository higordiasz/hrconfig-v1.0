using HRConfig.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRConfig.Forms
{
    public partial class Alterar_Senha : Form
    {
        public Alterar_Senha()
        {
            InitializeComponent();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

            var filter = Builders<Account>.Filter.Where(s => s.Email == Program.Email);
            if (tx_atual.Text.Length <= 0 || tx_confirmar.Text.Length <= 0 || tx_nova.Text.Length <= 0)
            {
                string message = "Os campos não podem ser nulos!";
                string caption = "Erro ao tentar alterar a senha.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
            } else
            {
                if (tx_nova.Text == tx_confirmar.Text)
                {
                    if (Program.Collection.Find(filter).FirstOrDefault() != null)
                    {
                        Account account = Program.Collection.Find(filter).FirstOrDefault();
                        if (account.Senha == tx_atual.Text)
                        {
                            var update = Builders<Account>.Update.Set("Senha", tx_nova.Text);
                            Program.Collection.UpdateOne(filter, update);
                            MessageBox.Show("Senha alterada com sucesso!", "Senha Alterada", MessageBoxButtons.OK);
                            this.Close();
                        } else
                        {
                            string message = "A senha atual está errada!";
                            string caption = "Erro ao tentar alterar a senha.";
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                        }
                    } else
                    {
                        string message = "Erro interno ocorreu, contate um administrador.";
                        string caption = "Erro ao tentar alterar a senha.";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                    }
                } else
                {
                    string message = "Os campos 'Nova Senha' e 'Repetir Senha' deve ser iguais!";
                    string caption = "Erro ao tentar alterar a senha.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
