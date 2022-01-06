using ProjetoERP.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjetoERP.controles
{
    internal class Ctrl_Cliente
    {
        public void Salvar(Cliente cliente)
        {
            if (!File.Exists("Tabelas/PESSOA.table"))
            {
                File.Create("Tabelas/PESSOA.table");
            }

            cliente.Id = newID();
            List<string> vs = new List<string>();
            vs.Add("" + cliente.Id + "|" + cliente.Nome + "|" + cliente.Cnpjcpf + "");
            
            File.AppendAllLines("Tabelas/PESSOA.table", vs);
        }

        public int newID()
        {
            string[] array = File.ReadAllLines("Tabelas/PESSOA.table");
            return array.Length + 1;
        }

        public string[] dados()
        {
            return File.ReadAllLines("Tabelas/PESSOA.table");
        }
    }
}
