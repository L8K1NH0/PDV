using SistemaPdv.DAO;
using SistemaPdv.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPdv.View
{
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();

            ClienteDAO dao = new ClienteDAO();

            DgvCliente.DataSource = dao.ListarCliente();
        }

        ClienteDAO dao = new ClienteDAO();

        public string nomeCliente { get; set; }
        public string endereco { get; set; }
        public string contato { get; set; }
        public string numero { get; set; }


        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Pegar dados selecionados
                nomeCliente = DgvCliente.CurrentRow.Cells[1].Value.ToString();
                endereco = DgvCliente.CurrentRow.Cells[2].Value.ToString();
                contato = DgvCliente.CurrentRow.Cells[7].Value.ToString();
                numero = DgvCliente.CurrentRow.Cells[5].Value.ToString();

                //Alterar pagina
                // Define o resultado do formulário ConsultaCliente como OK.
                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception)
            {
                throw; //Não ha necessidade de um retorno ao usuario
            }
            
        }

        private void TxtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nome = TxtPesquisa.Text;

            DgvCliente.DataSource = dao.ListarClienteNome(nome);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
