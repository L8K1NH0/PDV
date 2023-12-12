using SistemaPdv.DAO;
using SistemaPdv.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPdv
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            PrincipalDAO dao = new PrincipalDAO();

            DgvPedidosRealizados.DataSource = dao.ListarPedidos();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Fornecedor crud_For = new CRUD_Fornecedor();
            crud_For.ShowDialog();
            //this.Hide();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Produto crud_Produto = new CRUD_Produto();
            crud_Produto.ShowDialog();
            //this.Hide();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRUD_Cliente crud_Cli = new CRUD_Cliente();
            crud_Cli.ShowDialog(); 
            //this.Hide();
        }

        private void cAIXAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caixa caixa = new Caixa(null,null,null);
            caixa.ShowDialog();   
            //this.Hide();  
        }

        private void pDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();

            relatorio.ShowDialog();
            //this.Hide();
        }

        private void fLUXOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fluxo fluxo = new Fluxo();

            fluxo.ShowDialog();
            //this.Hide();
        }

        private void DgvPedidosRealizados_DoubleClick(object sender, EventArgs e)
        {
            PrincipalDAO dao = new PrincipalDAO();

            TxtNomeCli.Text = DgvPedidosRealizados.CurrentRow.Cells[1].Value.ToString();
            TxtValorCompra.Text = DgvPedidosRealizados.CurrentRow.Cells[2].Value.ToString();
            TxtContato.Text = DgvPedidosRealizados.CurrentRow.Cells[3].Value.ToString();
            TxtEndereco.Text = DgvPedidosRealizados.CurrentRow.Cells[4].Value.ToString();

            int Id = int.Parse(TxtIdPedido.Text = DgvPedidosRealizados.CurrentRow.Cells[0].Value.ToString());

            DgvPedidoEspecifico.DataSource = dao.PedidoEspecifico(Id);
            DgvFormaPagamento.DataSource = dao.PedidoPagamento(Id);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);

            PrincipalDAO dao = new PrincipalDAO();
            DgvPedidosRealizados.DataSource = dao.ListarPedidos();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PrincipalDAO dao = new PrincipalDAO();

            if(TxtIdPedido.Text != "")
            {
                if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM APAGAR O PEDIDO?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    int Id = int.Parse(TxtIdPedido.Text);

                    dao.ExcluirCliente(Id);

                    Clear.ClearControl(this);
                    DgvPedidosRealizados.DataSource = dao.ListarPedidos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Pedido.");
            }

            
        }
    }
}
