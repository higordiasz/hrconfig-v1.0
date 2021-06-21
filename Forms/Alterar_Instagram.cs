using HRConfig.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRConfig.Forms
{
    public partial class Alterar_Instagram : Form
    {
        public Alterar_Instagram()
        {
            InitializeComponent();
        }

        private void Alterar_Instagram_LoadAsync(object sender, EventArgs e)
        {
            var filter = Builders<Instagram>.Filter.Where(s => s.Email == Program.Email);
            List<Instagram> list = Program.Collection_Insta.Find(filter).ToList();
            list.ForEach(s => {
                cb_contas.Items.Add(s.Conta);
            });
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (cb_contas.SelectedItem.ToString() == "Selecione a conta" || cb_contas.SelectedItem.ToString() == null)
            {
                string message = "Selecione a conta que deseja alterar!";
                string caption = "Erro ao tentar alterar a conta.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
            }
            else
            {
                if (tx_conta.Text.Length <= 0 || tx_senha.Text.Length <= 0)
                {
                    string message = "Os campos 'Novo Usuario' e 'Nova Senha' não podem ser nulos!!";
                    string caption = "Erro ao tentar alterar a conta.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
                }
                else
                {
                    string conta = cb_contas.SelectedItem.ToString();
                    var filter = Builders<Instagram>.Filter.Where(s => s.Email == Program.Email && s.Conta == conta);
                    if (Program.Collection_Insta.Find(filter).FirstOrDefault() != null)
                    {
                        var update = Builders<Instagram>.Update.Set("Conta", tx_conta.Text).Set("Senha", tx_senha.Text);
                        Program.Collection_Insta.UpdateOne(filter, update);
                        string message = "Deseja alterar outra conta ?";
                        string caption = "Conta alterada com sucesso.";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                        if (result == DialogResult.Yes)
                        {
                            tx_conta.Clear();
                            tx_senha.Clear();
                            cb_contas.Focus();
                        }
                        else
                        {
                            this.Close();
                        }
                    } else
                    {
                        string message = "Não foi possivel alterar a conta!!";
                        string caption = "Erro ao tentar alterar a conta.";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
