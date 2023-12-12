using SistemaPdv.DAO;
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
    public partial class ConsultaCategoria : Form
    {
        public ConsultaCategoria()
        {
            InitializeComponent();

            ProdutoDAO dao = new ProdutoDAO();

            DgvCategoria.DataSource = dao.ListarCategoria();
        }

        public string nomeCategoria { get; set; }
        public string Id { get; set; }

        private void DgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Pegar dados selecionados
                nomeCategoria = DgvCategoria.CurrentRow.Cells[1].Value.ToString();
                Id = DgvCategoria.CurrentRow.Cells[0].Value.ToString();

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
            CaixaDAO dao = new CaixaDAO();
            
            DgvCategoria.DataSource = dao.ListarCategoriaoNome(TxtPesquisa.Text);

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
