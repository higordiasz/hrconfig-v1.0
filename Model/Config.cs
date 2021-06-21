using System;

namespace HRConfig.Model
{
    public static class Config
    {
        private static string _email = "";
        private static string _senha = "";
        private static string _codigo = "";
        private static bool _enviado = false;

        public static string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public static string Senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        public static string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public static bool Enviado
        {
            get { return _enviado; }
            set { _enviado = value; }
        }
    }
}
