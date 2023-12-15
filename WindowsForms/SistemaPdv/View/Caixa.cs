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
    public partial class Caixa : Form
    {
        DataTable ProdutosSelecionadosDt = new DataTable();//DataTable para salvar produtos selecionados

        public Caixa(string nomeCliente,string endereco, string contato)//PARAMETROS --> Puxar dados de outro form
        {
            InitializeComponent();
            TxtEndereco.Text = endereco;//Posicionar dados de outro form
            TxtContato.Text = contato;
            TxtNomeCliente.Text = nomeCliente;
        }

        public void Caixa_Load(object sender, EventArgs e)
        {
            CaixaDAO dao = new CaixaDAO();

            #region DataTable dos produtos selecionados --> serão salvos apos a finalização da compra
            ProdutosSelecionadosDt.Columns.Add("Nome Produto");
            ProdutosSelecionadosDt.Columns.Add("Quantidade");
            ProdutosSelecionadosDt.Columns.Add("SubTotal");
            ProdutosSelecionadosDt.Columns.Add("ID");
            #endregion

            TxtIdPedido.Text = dao.UltimoIdPedido().ToString();

            DgvEscolhaProdutos.DataSource = dao.ListarProduto();

        }  

        #region ADIÇÃO DE PRODUTOS
        private void TxtPesquisaProduto_TextChanged(object sender, EventArgs e)
        {
            CaixaDAO dao = new CaixaDAO();//instanciando

            string nome = TxtPesquisaProduto.Text;
            //Passar resultado de pesquisa para dgv
            DgvEscolhaProdutos.DataSource = dao.PesquisaProduto(nome);
        }

        private void DgvEscolhaProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Pegar dados selecionados
                TxtNomeProduto.Text = DgvEscolhaProdutos.CurrentRow.Cells[0].Value.ToString();
                TxtValorProduto.Text = DgvEscolhaProdutos.CurrentRow.Cells[1].Value.ToString();
                TxtIdProduto.Text = DgvEscolhaProdutos.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                throw; //Não ha necessidade de um retorno ao usuario
            }
            
        }

        private void BtnAdicionarProduto_Click(object sender, EventArgs e)
        {
            ItemPedidoModel obj = new ItemPedidoModel();//instanciando
            CaixaDAO dao = new CaixaDAO();//instanciando

            try
            {
                decimal quantidade = decimal.Parse(TxtQuantidadeProduto.Text);

                if (quantidade > 0)
                {
                    obj.IdPedido = int.Parse(TxtIdPedido.Text);

                    int idProduto = int.Parse(TxtIdProduto.Text);
                    obj.IdProduto = idProduto;

                    string nomeProduto = TxtNomeProduto.Text;
                    obj.Quantidade = quantidade;
                    decimal valor = decimal.Parse(TxtValorProduto.Text);

                    decimal subTotal = decimal.Parse((quantidade * valor).ToString("F"));
                    obj.SubTotal = subTotal;

                    //Add ao DataTable
                    ProdutosSelecionadosDt.Rows.Add(nomeProduto, quantidade, subTotal, idProduto);

                    DgvProdutosSelecionados.DataSource = ProdutosSelecionadosDt;

                    dao.AdicionarProduto(obj);

                    TxtIdProduto.Text = "";
                    TxtNomeProduto.Text = "";
                    TxtQuantidadeProduto.Text = "";
                    TxtValorProduto.Text = "";
                }
                else
                {
                    MessageBox.Show("Não é possivel adicionar 0 produtos");
                }
                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            ValorTotalCompra();
        }

        private void DgvProdutosSelecionados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //chamando função
            ItemPedidoModel obj = new ItemPedidoModel();
            CaixaDAO dao = new CaixaDAO();

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM APAGAR O ITEM?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    //pasando obj
                    obj.IdPedido = int.Parse(TxtIdPedido.Text);
                    obj.IdProduto = int.Parse(DgvProdutosSelecionados.CurrentRow.Cells[3].Value.ToString());

                    //removendo do dgvw
                    int index = e.RowIndex;
                    DgvProdutosSelecionados.Rows.RemoveAt(index);

                    //usando função
                    dao.RemoverProduto(obj);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao tentar eliminar o produto.");
                }
            }
            ValorTotalCompra();
        }
        #endregion

        #region PARTE DE PAGAMENTO E FINALIZAÇÃO
        private void BtnFinalizarVenda_Click(object sender, EventArgs e)
        {
            //instanciando
            CaixaDAO daoCaixa = new CaixaDAO();
            PedidoModel objPedido = new PedidoModel();    
            
            FormaPagamentoDAO daoPagamento= new FormaPagamentoDAO();
            FormaPagamentoModel objPagamento = new FormaPagamentoModel();

            try
            {
                if(DgvProdutosSelecionados.RowCount > 0)
                {
                    objPagamento.IdPedido = int.Parse(TxtIdPedido.Text);
                    objPagamento.Pix = decimal.Parse(TxtPix.Text);
                    objPagamento.Dinheiro = decimal.Parse(TxtDinheiro.Text);
                    objPagamento.Debito = decimal.Parse(TxtDebito.Text);
                    objPagamento.Credito = decimal.Parse(TxtCredito.Text);

                    decimal Pix = decimal.Parse(TxtPix.Text);
                    decimal Dinheiro = decimal.Parse(TxtDinheiro.Text);
                    decimal Debito = decimal.Parse(TxtDebito.Text);
                    decimal Credito = decimal.Parse(TxtCredito.Text);

                    decimal total = Pix + Dinheiro + Debito + Credito;

                    objPedido.NomeCliente = TxtNomeCliente.Text;

                    if (RbtnRetirada.Checked)
                    {
                        objPedido.EntregaRetirada = "RETIRADA";
                        objPedido.Endereco = "";
                    }
                    else
                    {
                        objPedido.EntregaRetirada= "ENTREGA";
                        objPedido.Endereco = $"{TxtEndereco.Text} N°:{TxtNumResidencia.Text}";
                    }   
                    
                    objPedido.Contato = TxtContato.Text;
                    objPedido.TotalVenda = decimal.Parse(TxtValorTotal.Text);
                    objPedido.DataVenda = DateTime.Now.ToString("yyyy-MM-dd");

                    if (total == decimal.Parse(TxtValorTotal.Text)) 
                    {
                        daoPagamento.FormaPagamento(objPagamento);
                        daoCaixa.FinalizarVenda(objPedido);

                        MessageBox.Show("Venda Finalizada com sucesso!");

                        //Limpar toda a pagina
                        Clear.ClearControl(this);

                        //Limpar o Dt
                        ProdutosSelecionadosDt.Clear();

                        AddNum();


                        CaixaDAO dao = new CaixaDAO();
                        TxtIdPedido.Text = dao.UltimoIdPedido().ToString();
                    }
                    else
                    {
                        MessageBox.Show("O valor total não bate com o valor de pagamento.");
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Adicione produtos para finalizar o pedido");
                }                
            }
            catch (Exception)
            {
                Erro customErro = new Erro("Todas as caixas devem ser preenchidas.");
                customErro.ShowDialog();
            }
            DgvEscolhaProdutos.DataSource = daoCaixa.ListarProduto();
        }


        private void BtnValorTotal_Click(object sender, EventArgs e)
        {
            ValorTotalCompra();
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //chamando função
            ItemPedidoModel obj = new ItemPedidoModel();
            CaixaDAO dao = new CaixaDAO();

            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM CANCELAR O PEDIDO?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                try
                {
                    //pasando obj
                    obj.IdPedido = int.Parse(TxtIdPedido.Text);

                    //usando função
                    dao.RemoverTodosProdutos(obj);


                    //Limpar toda a pagina
                    Clear.ClearControl(this);

                    AddNum();
                    TxtIdPedido.Text = dao.UltimoIdPedido().ToString();

                    //Limpar o Dt
                    ProdutosSelecionadosDt.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("SEM ID");


                }
                DgvEscolhaProdutos.DataSource = dao.ListarProduto();
            }

            

        }
        #endregion

        #region CONSULTA DE CLIENTES 
        private void TxtNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            // ESTANCIAR PAGINA DE CONSULTA
            ConsultaCliente cc = new ConsultaCliente();           

            if (e.KeyCode == Keys.F2)
            {
                // Exibe o formulário ConsultaCliente de forma modal e obtém o resultado.
                DialogResult result = cc.ShowDialog();

                // Verifica se o resultado do formulário ConsultaCliente é OK.
                if (result == DialogResult.OK)
                {
                    TxtNomeCliente.Text = cc.nomeCliente.ToString();
                    TxtEndereco.Text = cc.endereco.ToString();
                    TxtContato.Text = cc.contato.ToString();
                    TxtNumResidencia.Text = cc.numero.ToString();
                }
            }
        }
        #endregion

        #region CHECKBOX
        private void CkbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbDinheiro.Checked)
            {
                TxtDinheiro.Enabled = true;
            }
            else
            {
                TxtDinheiro.Enabled = false;
                TxtDinheiro.Text = "0";
            }
        }

        private void CkbPix_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbPix.Checked)
            {
                TxtPix.Enabled = true;
            }
            else
            {
                TxtPix.Enabled = false;
                TxtPix.Text = "0";
            }
        }

        private void CkbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbCredito.Checked)
            {
                TxtCredito.Enabled = true;
            }
            else
            {
                TxtCredito.Enabled = false;
                TxtCredito.Text = "0";
            }
        }

        private void CkbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (CkbDebito.Checked)
            {
                TxtDebito.Enabled = true;
            }
            else
            {
                TxtDebito.Enabled = false;
                TxtDebito.Text = "0";
            }
        }
        #endregion

        #region FUNÇÕES
        public void ValorTotalCompra()
        {
            decimal total = 0;
            int rows = int.Parse(DgvProdutosSelecionados.RowCount.ToString());

            for (int i = 0; i < rows; i++)
            {
                total += decimal.Parse(DgvProdutosSelecionados.Rows[i].Cells[2].Value.ToString());
            }

            TxtValorTotal.Text = total.ToString();
        }

        public void AddNum()
        {
            TxtPix.Text = "0";
            TxtDinheiro.Text = "0";
            TxtDebito.Text = "0";
            TxtCredito.Text = "0";
        }
        #endregion

        #region CONFIGURAÇÃO DE CARACTERES
        private void TxtQuantidadeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
        private void TxtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
        private void TxtPix_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
        private void TxtDinheiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
        private void TxtDebito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
        private void TxtCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
        private void TxtNumResidencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }
        #endregion

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //Principal principal = new Principal();

            if(0 == int.Parse(DgvProdutosSelecionados.RowCount.ToString()))
            {                
                //principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("COM ITENS NA TABELA DE PEDIDO NÃO PODE SAIR. CANCELE O PEDIDO PARA PODER SAIR");
            }
        }

        private void TxtContato_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtContato_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RbtnRetirada_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnRetirada.Checked)
            {
                //TxtEndereco.Text = string.Empty;
                //TxtEndereco.Enabled = false;

                //TxtNumResidencia.Enabled = false; 
                //TxtNumResidencia.Text = string.Empty;
            }
        }

        private void RbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (RbtnEntrega.Checked)
            {
                //TxtEndereco.Enabled = true;

                //TxtNumResidencia.Enabled = true;
            }
        }

        private void LblProdutosSelecionados_Click(object sender, EventArgs e)
        {

        }

        private void LblQuantidadeProduto_Click(object sender, EventArgs e)
        {

        }

        private void TxtQuantidadeProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblFormaPagamento_Click(object sender, EventArgs e)
        {

        }
    }
}
