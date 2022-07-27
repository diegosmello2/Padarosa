using LibPadarosa;
using MySqlConnector;
using Padarosa.Banco;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa.Formularios
{
    public partial class GerenciadorProdutos : Form
    {
        // Objetos globais:        
        private Usuario _u;
        
        private int _idSelecionado;

        public GerenciadorProdutos(Usuario u)
        {
            InitializeComponent();
            _u = u;          

            // Salvar o resultado da listagem de categorias em um objeto:
            var r = Banco.CategoriaDAO.ListarTudo();
            ArrayList rows = new ArrayList();
            // Converter este objeto para o array:
            foreach (DataRow dataRow in r.Rows)
            {
                rows.Add(string.Join(" - ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            // Atribuir os valores nos cmbs:
            cmbCategoriaCad.DataSource = rows;
            cmbCategoriaEdi.DataSource = rows.Clone();

            // Carregar dados para o data dgv:
            AtualizarDgv();
        }
        // Função para extrair o número do combobox selecionado:
        private int obterIDdaString(string texto)
        {
            return int.Parse(texto.Split(' ')[0]);
        }            
        
        private void AtualizarDgv()
        {
            dgvProdutos.DataSource = Banco.ProdutoDAO.ListarProdutos();
        }

        private void GerenciadorProdutos_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var p = new Produto();
            var valida = txtProdutoCad.Text.Length > 5 &&
                txtPrecoCad.Text.Length >= 1;
                

            if (valida)
            {
                p.Nome = txtProdutoCad.Text;
                p.Preco = double.Parse(txtPrecoCad.Text);
                p.IdCategoria = obterIDdaString(cmbCategoriaCad.Text);
                p.IdRespCadastro = _u.Id;

                // Chamar o cadastrar:
                if (Banco.ProdutoDAO.Cadastrar(p) == true)
                {
                    MessageBox.Show("Produto cadastrado!");
                    // Limpar os campos:
                    txtProdutoCad.Clear();
                    txtPrecoCad.Clear();
                    // cmbCategoriaCad.Clear();

                    // Atualizar:
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Houve um erro no cadastro. " +
                    "Verifique as informações digitadas.");
                }
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }           
        }
        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Outro modo para: Mostrar o GroupBox(grbEditar.Visible = true;)

            // Ativar o groupBox de Editar:
            grbEditar.Enabled = true;

            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvProdutos.CurrentCell.RowIndex;

            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvProdutos.Rows[numeroLinha];

            // Atribuir os valores das células aos txt do Editar:
            txtProdutoEdi.Text = linha.Cells[1].Value.ToString();
            txtPrecoEdi.Text = linha.Cells[2].Value.ToString();           
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void cmbCategoriaEdi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Instanciando:
            var p = new Produto();
            p.Nome = txtProdutoEdi.Text;
            p.Preco = double.Parse(txtPrecoEdi.Text);
            p.IdCategoria = obterIDdaString(cmbCategoriaEdi.Text);
            p.Id = _idSelecionado;

            // Chamar a Alterar:
            if (Banco.ProdutoDAO.Alterar(p))
            {
                MessageBox.Show("Produto alterado com sucesso.");
                // Limpar os campos:
                txtProdutoEdi.Clear();
                txtPrecoEdi.Clear();
                // Atualizar o dgv:
                AtualizarDgv();
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
        }

        private void grbEditar_Enter(object sender, EventArgs e)
        {
            
        }
    }             
}
    

