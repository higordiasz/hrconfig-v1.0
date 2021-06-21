using HRConfig.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRConfig.Forms
{
    public partial class Lista_Instagram : Form
    {
        public Lista_Instagram()
        {
            InitializeComponent();
        }

        private void Lista_Instagram_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Conta", 100);
            listView1.Columns.Add("Senha", 100);
            ListViewItem itm;
            string[] arr = new string[2];
            var filter = Builders<Instagram>.Filter.Where(s => s.Email == Program.Email);
            List<Instagram> list = Program.Collection_Insta.Find(filter).ToList();
            list.ForEach(s => {
                arr[0] = s.Conta;
                arr[1] = s.Senha;
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            });
        }
    }
}
