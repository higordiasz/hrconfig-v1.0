using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConfig.Model
{
    public class GmailModel
    {
        public int Status { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Response { get; set; }
    }

    public class GmailNator
    {
        public int Status { get; set; }
        public string Email { get; set; }
        public string Codigo { get; set; }
        public string Response { get; set; }
    }
}
