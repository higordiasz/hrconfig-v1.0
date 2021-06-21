using HRConfig.Forms;
using System;
using System.Windows.Forms;

namespace HRConfig
{
    public partial class HrConfig : Form
    {
        public HrConfig()
        {
            InitializeComponent();
        }

        private void HrConfig_Load(object sender, EventArgs e)
        {

        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_Instagram ca = new Cadastrar_Instagram
            {
                TopLevel = false,
                Visible = true
            };
            panel.Controls.Add(ca);
        }

        private void DeletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deletar_Instagram de = new Deletar_Instagram
            {
                TopLevel = false,
                Visible = true
            };
            panel.Controls.Add(de);
        }

        private void AlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar_Instagram at = new Alterar_Instagram
            {
                TopLevel = false,
                Visible = true
            };
            panel.Controls.Add(at);
        }

        private void ListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Instagram li = new Lista_Instagram
            {
                TopLevel = false,
                Visible = true
            };
            panel.Controls.Add(li);
        }

        private void DelayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delay_Configurar dc = new Delay_Configurar
            {
                TopLevel = false,
                Visible = true
            };
            panel.Controls.Add(dc);
        }

        private void SenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar_Senha ase = new Alterar_Senha
            {
                TopLevel = false,
                Visible = true
            };
            panel.Controls.Add(ase);
        }

        private void CriarGmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Criar_Gmail cg = new Criar_Gmail
            {
                TopLevel = false,
                Visible = true
            };
            panel.Controls.Add(cg);
        }

        private void criarGmailnatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gmailnator gn = new Gmailnator();
            gn.TopLevel = false;
            gn.Visible = true;
            panel.Controls.Add(gn);
        }

        private void criarInstagramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void challengeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Challenge ch = new Challenge();
            ch.TopLevel = false;
            ch.Visible = true;
            panel.Controls.Add(ch);
        }
    }
}
