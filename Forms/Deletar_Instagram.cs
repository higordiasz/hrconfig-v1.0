using HRConfig.Model;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace HRConfig.Forms
{
    public partial class Deletar_Instagram : Form
    {
        public Deletar_Instagram()
        {
            InitializeComponent();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_deletar_Click(object sender, EventArgs e)
        {
            if (tx_conta.Text.Length <= 0 )
            {
                string message = "O campo 'Conta' não pode ser nulo!!";
                string caption = "Erro ao tentar deletar a conta.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
            } else
            {
                var deletefilter = Builders<Instagram>.Filter.Where(s => s.Conta == tx_conta.Text && s.Email == Program.Email);

                if (Program.Collection_Insta.Find(deletefilter).FirstOrDefault() != null)
                {

                    Program.Collection_Insta.DeleteOne(deletefilter);


                    string message = "Deseja deletar outra conta ?";
                    string caption = "Conta deletada com sucesso.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        tx_conta.Clear();
                        tx_conta.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                } else
                {
                    string message = "Não foi possivel localizar essa conta no banco de dados!! \n Deseja tentar novamente?";
                    string caption = "Conta não encontrada.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        tx_conta.Clear();
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
