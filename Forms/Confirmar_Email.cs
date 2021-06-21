using HRConfig.Model;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Resources;
using HRConfig.Properties;

namespace HRConfig.Forms
{
    public partial class Confirmar_Email : Form
    {
        public Confirmar_Email()
        {
            InitializeComponent();
        }

        private void Confirmar_Email_Load(object sender, EventArgs e)
        {
            string fromaddr = "suportehrmoney@gmail.com";
            string toaddr = Config.Email;
            string password = "03081996hdz";

            MailMessage msg = new MailMessage();
            msg.Subject = "Código de verificação";
            msg.From = new MailAddress(fromaddr);
            msg.Body = "O seu código de verificação é: " + Config.Codigo;
            msg.To.Add(new MailAddress(Config.Email));
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            NetworkCredential nc = new NetworkCredential(fromaddr, password);
            smtp.Credentials = nc;
            try
            {
                smtp.Send(msg);
                Config.Enviado = true;
                tx_codigo.BorderStyle = BorderStyle.None;
            } catch (Exception err)
            {
                Config.Enviado = false;
                MessageBox.Show(err.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            if (tx_codigo.Text.Length <= 0 || Config.Enviado == false)
            {

            } else
            {
                if (tx_codigo.Text == Config.Codigo)
                {
                    Account account = new Account();
                    account.Email = Config.Email;
                    account.Senha = Config.Senha;
                    account.Delay_a = 30000;
                    account.Delay_b = 45000;
                    account.Delay_c = 300000;
                    account.Delay_block = 3600000;
                    account.Qtd = 5;
                    account.Ganhar = true;
                    account.Siga = true;
                    Program.Collection.InsertOne(account);
                    string message = "Conta cadastrada em nosso sistema!!";
                    string caption = "Conta Cadastrada";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void bt_confirmar_MouseMove(object sender, MouseEventArgs e)
        {
            bt_confirmar.Image = Resources.Confirmar_move;
        }

        private void bt_confirmar_MouseLeave(object sender, EventArgs e)
        {
            bt_confirmar.Image = Resources.Confirmar_normal;
        }

        private void bt_confirmar_MouseDown(object sender, MouseEventArgs e)
        {
            bt_confirmar.Image = Resources.Confirmar_click;
        }
    }
}
