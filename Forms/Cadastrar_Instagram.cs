using HRConfig.Model;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace HRConfig.Forms
{
    public partial class Cadastrar_Instagram : Form
    {
        public Cadastrar_Instagram()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (tx_conta.Text.Length <= 0 || tx_senha.Text.Length <= 0)
            {
                string message = "Os campos 'Conta' e 'Senha' não podem ser nulos!!";
                string caption = "Erro ao tentar cadastrar a conta.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
            } else
            {
                var filterconta = Builders<Instagram>.Filter.Where(s => s.Email == Program.Email && s.Conta == tx_conta.Text);
                if (Program.Collection_Insta.Find(filterconta).FirstOrDefault() == null)
                {
                    Instagram document = new Instagram();
                    document.Email = Program.Email;
                    document.Conta = tx_conta.Text;
                    document.Senha = tx_senha.Text;
                    Program.Collection_Insta.InsertOne(document);
                    string message = "Deseja cadastrar uma nova conta ?";
                    string caption = "Cadastrado com sucesso.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        tx_conta.Clear();
                        tx_senha.Clear();
                        tx_conta.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                } else
                {
                    string message = "Essa conta ja existe em nosso banco de dados!! \n Deseja tentar cadastrar outra conta ?";
                    string caption = "Conta ja cadastrada.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        tx_conta.Clear();
                        tx_senha.Clear();
                        tx_conta.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
    }
}
