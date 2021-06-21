using HRConfig.Model;
using MongoDB.Driver;
using System;
using System.Windows.Forms;

namespace HRConfig
{
    static class Program
    {
        private static string _email = "";
        private static readonly string _mongoconfig = "";
        private static readonly MongoClient _dbclient = new MongoClient(_mongoconfig);
        private static readonly IMongoDatabase _database = _dbclient.GetDatabase("");
        private static readonly IMongoCollection<Account> _collection = _database.GetCollection<Account>("");
        private static readonly IMongoCollection<Instagram> _collection_insta = _database.GetCollection<Instagram>("");
        private static readonly IMongoCollection<Criador> _collection_criador = _database.GetCollection<Criador>("");
        private static readonly IMongoCollection<Versao> _versao = _database.GetCollection<Versao>("");
        public static string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public static IMongoCollection<Account> Collection
        {
            get { return _collection; }
        }

        public static IMongoCollection<Versao> Versao
        {
            get { return _versao; }
        }

        public static IMongoCollection<Instagram> Collection_Insta
        {
            get { return _collection_insta; }
        }

        public static IMongoCollection<Criador> Collection_Criador
        {
            get { return _collection_criador; }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login lg = new Login();
            if (lg.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new HrConfig());
            }
        }
    }
}
