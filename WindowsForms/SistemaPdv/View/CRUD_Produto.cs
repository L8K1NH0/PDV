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
    public partial class CRUD_Produto : Form
    {
        CategoriaDAO daoCat = new CategoriaDAO();
        ProdutoDAO daoProd = new ProdutoDAO();

        public CRUD_Produto()
        {
            InitializeComponent();

        }

        public void LoadDgv()
        {
            DgvProduto.DataSource = daoProd.ListarProduto();
            DgvCategoria.DataSource = daoCat.ListarCategoria();
        }

        private void CRUD_Produto_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }

        public string VerificarTab()
        {
            //Verificar Tab aberta
            TabPage tabSelecionada = TabProduto.SelectedTab;
            string nomeTabSelecionada = tabSelecionada.Name;

            return nomeTabSelecionada;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
            LoadDgv();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {           

            if (VerificarTab() == "TabDadoProduto")
            {
                //Estanciar objetos do Produto
                ProdutoModel obj = new ProdutoModel();

                try
                {
                    if (TxtNomeProduto.Text.Length > 0 && TxtValorUnitarioProduto.Text.Length > 0 && TxtCategoriaSelecionada.Text.Length > 0)
                    {
                        //if (decimal.Parse(TxtValorUnitarioProduto.Text.ToString()) <= 0)
                        //{
                        //    throw new Exception("Valor invalido");
                        //}

                        obj.Nome = TxtNomeProduto.Text;
                        obj.ValorUnitario = decimal.Parse(TxtValorUnitarioProduto.Text);
                        obj.IdCategoria = int.Parse(TxtCategoriaProduto.Text);

                        daoProd.CadastrarProduto(obj);
                    }
                    else
                    {
                        Erro customErro = new Erro("Todas as caixas devem ser preenchidas.");
                        customErro.ShowDialog();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show($"Erro: {erro.Message}");
                    throw;
                }

                
            }
            else if(VerificarTab() == "TabDadoCategoria")
            {
                //Estanciar objetos do Categoria
                CategoriaModel obj = new CategoriaModel();

                if (TxtNomeCategoria.Text.Length > 0)
                {
                    obj.Nome = TxtNomeCategoria.Text;
                    obj.Descricao = TxtDescricaoCategoria.Text;

                    daoCat.CadastrarCategoria(obj);
                }
                else
                {
                    Erro customErro = new Erro("A caixa nome deve ser preenchidas.");
                    customErro.ShowDialog();
                }                
            }
            else
            {
                MessageBox.Show("Ñ");
            }

            Clear.ClearControl(this);
            LoadDgv();

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM ALTERAR O ITEM?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (VerificarTab() == "TabDadoProduto")
                {
                    //Estanciar objetos do Produto
                    ProdutoModel obj = new ProdutoModel();

                    try
                    {
                        //if(TxtValorUnitarioProduto.Text == "")
                        //{
                        //    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                        //}

                        obj.Id = int.Parse(TxtIdProduto.Text);
                        obj.Nome = TxtNomeProduto.Text;
                        obj.ValorUnitario = decimal.Parse(TxtValorUnitarioProduto.Text);
                        obj.IdCategoria = int.Parse(TxtCategoriaProduto.Text);

                        daoProd.AlterarProduto(obj);

                    }
                    catch (Exception)
                    {
                        Erro customErro = new Erro("Verifique os campos obrigatorios.");
                        customErro.ShowDialog();
                    }



                }
                else if (VerificarTab() == "TabDadoCategoria")
                {
                    //Estanciar objetos do Categoria
                    CategoriaModel obj = new CategoriaModel();

                    try
                    {
                        obj.Id = int.Parse(TxtIdCategoria.Text);
                        obj.Nome = TxtNomeCategoria.Text;
                        obj.Descricao = TxtDescricaoCategoria.Text;

                        daoCat.AlterarCategoria(obj);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Verifique os campos OBRIGATÓRIOS.");
                    }


                }
                else
                {
                    MessageBox.Show("Ñ");
                }

                Clear.ClearControl(this);
                LoadDgv();
            }

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (VerificarTab() == "TabDadoProduto")
            {
                //Estanciar objetos do Produto
                ProdutoModel obj = new ProdutoModel();

                if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM APAGAR O ITEM?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    try
                    {
                        obj.Id = int.Parse(TxtIdProduto.Text);

                        daoProd.ExcluirProduto(obj);
                    }
                    catch (Exception)
                    {
                        Erro customErro = new Erro("Verifique os campos obrigatorios.");
                        customErro.ShowDialog();
                    }
                }               
                
            }
            else if (VerificarTab() == "TabDadoCategoria")
            {
                //Estanciar objetos do Categoria
                CategoriaModel obj = new CategoriaModel();
                if (DialogResult.Yes == MessageBox.Show("TEM CERTEZA EM APAGAR A CATEGORIA?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    try
                    {
                        obj.Id = int.Parse(TxtIdCategoria.Text);

                        daoCat.ExcluirCategoria(obj);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Verifique os campos OBRIGATÓRIOS.");
                    }
                }      
            }
            else
            {
                MessageBox.Show("Ñ");
            }

            Clear.ClearControl(this);
            LoadDgv();

        }

        private void DgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar dados selecionados
            TxtIdCategoria.Text = DgvCategoria.CurrentRow.Cells[0].Value.ToString();
            TxtNomeCategoria.Text = DgvCategoria.CurrentRow.Cells[1].Value.ToString();
        }

        private void DgvCategoriaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar dados selecionados
            TxtCategoriaSelecionada.Text = DgvProduto.CurrentRow.Cells[0].Value.ToString();

        }

        private void DgvConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar dados selecionados
            TxtIdProduto.Text = DgvProduto.CurrentRow.Cells[0].Value.ToString();
            TxtNomeProduto.Text = DgvProduto.CurrentRow.Cells[1].Value.ToString();
            TxtValorUnitarioProduto.Text = DgvProduto.CurrentRow.Cells[2].Value.ToString();
            TxtCategoriaSelecionada.Text = DgvProduto.CurrentRow.Cells[3].Value.ToString();


            //Alterar a guia 
            TabProduto.SelectedTab = TabDadoProduto;
        }

        private void TxtNome_Consulta_TextChanged(object sender, EventArgs e)
        {
            string nome = TxtNome_Consulta.Text;
            DgvProduto.DataSource = daoProd.ListarProdutoNome(nome);
        }

        private void DgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriaDAO dao = new CategoriaDAO();

            try
            {
                string idCategoria = DgvProduto.CurrentRow.Cells[1].Value.ToString();

                TxtIdProduto.Text = DgvProduto.CurrentRow.Cells[0].Value.ToString();
                TxtCategoriaProduto.Text = idCategoria;
                TxtNomeProduto.Text = DgvProduto.CurrentRow.Cells[2].Value.ToString();
                TxtValorUnitarioProduto.Text = DgvProduto.CurrentRow.Cells[3].Value.ToString();
                TxtCategoriaSelecionada.Text = dao.ListarCategoriaID(idCategoria);
            }
            catch (Exception)
            {
                throw;  //Não ha necessidade de um retorno ao usuario
            }
            
        }

        private void DgvCategoria_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtIdCategoria.Text = DgvCategoria.CurrentRow.Cells[0].Value.ToString();
                TxtNomeCategoria.Text = DgvCategoria.CurrentRow.Cells[1].Value.ToString();
                TxtDescricaoCategoria.Text = DgvCategoria.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                throw;  //Não ha necessidade de um retorno ao usuario
            }
            
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //Principal principal = new Principal();
            //principal.Show();
            this.Hide();
        }

        private void TxtCategoriaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            // ESTANCIAR PAGINA DE CONSULTA
            ConsultaCategoria cc = new ConsultaCategoria();

            if (e.KeyCode == Keys.F2)
            {
                // Exibe o formulário ConsultaCategoria de forma modal e obtém o resultado.
                DialogResult result = cc.ShowDialog();

                // Verifica se o resultado do formulário ConsultaCategoria é OK.
                if (result == DialogResult.OK)
                {
                    TxtCategoriaSelecionada.Text = cc.nomeCategoria.ToString();
                    TxtCategoriaProduto.Text = cc.Id;
                }
            }
        }
        private void TxtValorUnitarioProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.IntNumber(e);
        }

        private void TxtValorUnitarioProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNome_Consulta_TextChanged_1(object sender, EventArgs e)
        {
            ProdutoDAO dao = new ProdutoDAO();

            DgvProduto.DataSource = dao.ListarProdutoNome(TxtNome_Consulta.Text);
        }

        private void TxtConsultaCategoria_TextChanged(object sender, EventArgs e)
        {
            CategoriaDAO dao = new CategoriaDAO();

            DgvCategoria.DataSource = dao.ListarCategoriaNome(TxtConsultaCategoria.Text);
        }
    }
}
