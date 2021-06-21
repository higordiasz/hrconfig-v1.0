using HRConfig.Model;
using HRConfig.Properties;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HRConfig.Forms
{
    public partial class Registro_HR : Form
    {
        public Registro_HR()
        {
            InitializeComponent();
        }

        public string GerarCodigo()
        {
            int Tamanho = 8;
            string senha = string.Empty;
            for (int i = 0; i < Tamanho; i++)
            {
                Random random = new Random();
                int codigo = Convert.ToInt32(random.Next(48, 122).ToString());

                if ((codigo >= 48 && codigo <= 57) || (codigo >= 97 && codigo <= 122))
                {
                    string _char = ((char)codigo).ToString();
                    if (!senha.Contains(_char))
                    {
                        senha += _char;
                    }
                    else
                    {
                        i--;
                    }
                }
                else
                {
                    i--;
                }
            }
            return senha;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            if (tx_cemail.Text.Length <= 0 || tx_csenha.Text.Length <= 0 || tx_email.Text.Length <= 0 || tx_senha.Text.Length <= 0)
            {
                string message = "Preencha todos os campos!!";
                string caption = "Erro ao tentar cadastrar conta.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
            } else
            {
                var filter = Builders<Account>.Filter.Eq("Email", tx_email.Text);
                if (Program.Collection.Find(filter).FirstOrDefault() != null)
                {
                    string message = "Esse email ja está cadastrado!!";
                    string caption = "Erro ao tentar cadastrar conta.";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                } else
                {
                    if ((tx_email.Text == tx_cemail.Text) && (tx_senha.Text == tx_csenha.Text))
                    {
                        Config.Email = tx_email.Text;
                        Config.Senha = tx_senha.Text;
                        Config.Codigo = GerarCodigo();
                        Confirmar_Email ce = new Confirmar_Email();
                        ce.Show();
                        this.Close();
                    } else
                    {
                        string message = "Os campos de confirmação deve ser igual ao anterior!!";
                        string caption = "Erro ao tentar cadastrar a conta.";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void tx_cemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_HR_Load(object sender, EventArgs e)
        {
            tx_cemail.BorderStyle = BorderStyle.None;
            tx_csenha.BorderStyle = BorderStyle.None;
            tx_email.BorderStyle = BorderStyle.None;
            tx_senha.BorderStyle = BorderStyle.None;
        }

        private void Registro_HR_MouseLeave(object sender, EventArgs e)
        {
            bt_registrar.Image = Resources.Registro_normal;
        }

        private void Registro_HR_MouseDown(object sender, MouseEventArgs e)
        {
            bt_registrar.Image = Resources.Registro_click;
        }

        private void bt_registrar_MouseMove(object sender, MouseEventArgs e)
        {
            bt_registrar.Image = Resources.Registro_sobrepor;
        }

        private void lb_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
