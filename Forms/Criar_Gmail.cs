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
    public partial class Criar_Gmail : Form
    {
        public Criar_Gmail()
        {
            InitializeComponent();
        }

        private void Criar_Gmail_Load(object sender, EventArgs e)
        {
            var filter = Builders<Criador>.Filter.Eq("Email", Program.Email);
            Criador conta = Program.Collection_Criador.Find(filter).FirstOrDefault();
            if (conta == null)
            {
                MessageBox.Show("Você não tem permissão para acessar essa função!!", "Sem permissão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            } else
            {
                if (conta.Gmail == true)
                {
                    MessageBox.Show("Bem-Vindo a o sistema de criação de Gmail.", "Criar Gmail", MessageBoxButtons.OK);
                } else
                {
                    MessageBox.Show("Você não tem permissão para acessar essa função!!", "Sem permissão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
    }
}
