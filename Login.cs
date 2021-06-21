using System;
using System.Windows.Forms;
using MongoDB.Driver;
using HRConfig.Model;
using HRConfig.Forms;
using HRConfig.Properties;

namespace HRConfig
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            var versaof = Builders<Versao>.Filter.Empty;
            if (lb_versao.Text == Program.Versao.Find(versaof).FirstOrDefault().HRConfig)
            {


                if (tx_email.Text.Length <= 0 || tx_senha.Text.Length <= 0)
                {
                    string message = "Voçê deve preencher os campos 'Email' e 'Senha' !! \nDeseja fechar o sistema ?";
                    string caption = "Erro ao tentar logar.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    var filter = Builders<Account>.Filter.Eq("Email", tx_email.Text);
                    Account conta = Program.Collection.Find(filter).FirstOrDefault();
                    if (conta != null)
                    {
                        if (tx_senha.Text != conta.Senha)
                        {
                            string message = "Email ou Senha Incorreto !! \nDeseja fechar o sistema ?";
                            string caption = "Erro ao tentar logar.";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            Program.Email = tx_email.Text;
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        string message = "Email ou Senha Incorreto !! \nDeseja fechar o sistema ?";
                        string caption = "Erro ao tentar logar.";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Error);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                    }
                }
            } else
            {
                MessageBox.Show("Existe uma nova atualização disponivel. Entre em nosso servidor do discord ou no Youtube para atualizar o sistema. \n Discord: https://discord.gg/sYeya7g \nYoutube: https://www.youtube.com/higordiasz", "Atualização disponivel.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registro_HR rg = new Registro_HR();
            rg.Show();
        }

        private void pb_login_MouseMove(object sender, MouseEventArgs e)
        {
            pb_login.Image = Resources.Login_sobrepor;
        }

        private void pb_login_MouseLeave(object sender, EventArgs e)
        {
            pb_login.Image = Resources.Login_normal;
        }

        private void pb_login_MouseDown(object sender, MouseEventArgs e)
        {
            pb_login.Image = Resources.Login_click;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tx_email.BorderStyle = BorderStyle.None;
            tx_senha.BorderStyle = BorderStyle.None;
        }

        private void lb_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
