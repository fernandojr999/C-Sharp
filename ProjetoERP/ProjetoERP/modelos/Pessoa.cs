using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoERP.modelos
{
    internal class Pessoa
    {
        private int id;
        private string nome;
        private string cnpjcpf;
        private string numeroDocumento;

        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Cnpjcpf { get { return cnpjcpf; } set { cnpjcpf = value; } }
        public string NumeroDocumento { get { return numeroDocumento; } set { numeroDocumento = value; } }  

    }
}
