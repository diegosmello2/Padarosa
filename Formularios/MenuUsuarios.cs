using LibPadarosa;
using System;
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
    public partial class GerenciadorUsuarios : Form
    {
        // Objetos globais:
        private Usuario _u;
        private int _idSelecionado;

        public GerenciadorUsuarios(Usuario u)
        {
            InitializeComponent();
            _u = u;
            // Carregar dados para o data dgv:
            AtualizarDgv();
        }
        private void AtualizarDgv()
        {
            dgvUsuarios.DataSource = Banco.UsuarioDAO.ListarTudo();
        }

        private void MenuUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var u = new Usuario();
            var valida = txtNomeCad.Text.Length > 5 &&
                txtSenhaCad.Text.Length  >= 6 &&
                txtEmailCad.Text.Length  >= 6;
            if (valida)
            {
                u.NomeCompleto = txtNomeCad.Text;
                u.Email = txtEmailCad.Text;
                u.Senha = txtSenhaCad.Text;
                // Chamar o cadastrar:
                if (Banco.UsuarioDAO.Cadastrar(u) == true)
                {
                    MessageBox.Show("Usuário cadastrado!");
                    // Limpar os campos:
                    txtNomeCad.Clear();
                    txtSenhaCad.Clear();
                    txtEmailCad.Clear();
                    // Atualizar o dgv:
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

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Outro modo para: Mostrar o GroupBox(grbEditar.Visible = true;)

            // Ativar o groupBox de Editar:
            grbEditar.Enabled = true;

            // Descobrir o número da linha da célula clicada:
            int numeroLinha = dgvUsuarios.CurrentCell.RowIndex;

            // Guardar toda a linha em um objeto DataRow:
            var linha = dgvUsuarios.Rows[numeroLinha];

            // Atribuir os valores das células aos txt do Editar:
            txtNomeEdi.Text = linha.Cells[1].Value.ToString();
            txtEmailEdi.Text = linha.Cells[2].Value.ToString();
            _idSelecionado = int.Parse(linha.Cells[0].Value.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Instanciando:
            var u = new Usuario();
            u.NomeCompleto = txtNomeEdi.Text;
            u.Email = txtEmailEdi.Text;
            u.Senha = txtSenhaEdi.Text;
            u.Id = _idSelecionado;

            // Chamar a Alterar:
            if(Banco.UsuarioDAO.Alterar(u))
            {
                MessageBox.Show("Usuário alterado com sucesso.");
                // Limpar os campos:
                txtNomeEdi.Clear();
                txtSenhaEdi.Clear();
                txtEmailEdi.Clear();
                // Atualizar o dgv:
                AtualizarDgv();
                grbEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
