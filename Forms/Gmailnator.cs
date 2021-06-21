using System;
using System.Windows.Forms;
using HRConfig.Clases;
using HRConfig.Model;

namespace HRConfig.Forms
{
    public partial class Gmailnator : Form
    {
        public Gmailnator()
        {
            InitializeComponent();
        }

        private async void Bt_create_Click(object sender, EventArgs e)
        {
            if (tx_nome.Text.Length <= 0 || tx_senha.Text.Length <= 0 || tx_usuario.Text.Length <= 0)
            {
                MessageBox.Show("Não pode deixar os campos ocultos!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Class_Gmailnator criar = new Class_Gmailnator();
                GmailNator response = await criar.CriarGmailnator(tx_usuario.Text, tx_senha.Text, tx_nome.Text);
                if (response.Status == 1)
                {
                    MessageBox.Show("Sucesso ao criar a conta!!", "Conta criada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Erro com a seguinte mensagem: " + response.Response, "Erro ao criar a conta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
