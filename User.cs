using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Smart_Auto
{
    class User
    {
        public string nome { get; set; }
        public int tlm { get; set; }
        public User(string  nome, int tlm)
        {
            this.nome = nome;
        }
    }
}