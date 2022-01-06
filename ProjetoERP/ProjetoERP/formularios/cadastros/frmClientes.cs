using ProjetoERP.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProjetoERP.controles;

namespace ProjetoERP.formularios.cadastros
{
    public partial class frmClientes : Form
    {
        private Cliente cliente;

        public frmClientes()
        {
            InitializeComponent();

            carregarListView();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cliente = new Cliente();
            cliente.Id = 0;

            edtCodigo.Text = "0000";
            edtCNPJCPF.Text = "";
            edtNome.Text = "";

            edtNome.Focus();
        }
        private void carregarListView()
        {
            lbDados.Items.Clear();
            Ctrl_Cliente con = new Ctrl_Cliente();

            string[] array = con.dados();
            for (int i = 0; i < array.Length; i++)
            {
                lbDados.Items.Add(array[i]);
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Ctrl_Cliente con = new Ctrl_Cliente();
            cliente.Cnpjcpf = edtCNPJCPF.Text;
            cliente.Nome = edtNome.Text;
            con.Salvar(cliente);
            edtCodigo.Text = ""+cliente.Id;

            carregarListView();
        }

        
    }
}
