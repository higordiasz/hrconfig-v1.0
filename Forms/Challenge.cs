using HRConfig.Model;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HRConfig.Forms
{
    public partial class Challenge : Form
    {
        public Challenge()
        {
            InitializeComponent();
        }

        private void Challenge_Load(object sender, EventArgs e)
        {
            cb_opcao.Items.Add("True");
            cb_opcao.Items.Add("False");
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            if (cb_opcao.SelectedItem.ToString() == "Selecione uma opção" || cb_opcao.SelectedItem.ToString() == null)
            {
                string message = "Selecione a opção que deseja!";
                string caption = "Erro ao tentar alterar a configurção.";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning);
            } else
            {
                var filter = Builders<Account>.Filter.Eq("Email", Program.Email);
                if (Program.Collection.Find(filter).FirstOrDefault() != null)
                {
                    Boolean select;
                    if (cb_opcao.SelectedItem.ToString() == "True")
                    {
                        select = true;
                    } else
                    {
                        select = false;
                    }
                    var update = Builders<Account>.Update.Set("Challenge", select);
                    Program.Collection.UpdateOne(filter, update);
                    this.Close();
                } else
                {
                    MessageBox.Show("Um erro inesperado aconteceu, contacte um administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
