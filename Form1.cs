using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            // Verificar tamanho do campo de email e senha:
            if (txtEmail.Text.Length <= 3 && txtSenha.Text.Length <= 3)
            {
                MessageBox.Show("Verifique as informações digitadas.");
            }
            else
            {
                var u = new LibPadarosa.Usuario();
                u.Email = txtEmail.Text;
                u.Senha = txtSenha.Text;
                var resultado = Banco.UsuarioDAO.Logar(u);
                // Verificar se o banco retornou algum dado:
                if(resultado.Rows.Count == 0)
                {
                    MessageBox.Show("Usuário e/ou senha incorreto.");
                }
                else
                {
                    // Continuar programa:

                    // Guardar as informações vindas do BD:
                    u.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    u.Id = int.Parse(resultado.Rows[0]["Id"].ToString());
                    // Abrir a janela:
                    var menuPrincipal = new Formularios.MenuPrincipal(u);
                    // Esconder a primeira janela:
                    Hide();
                    // Mostrar a nova:
                    menuPrincipal.ShowDialog();
                    // Ao sair da anterior, mostrar novamente:
                    Show();
                    // Limpar os pontos de e-mail e senha:
                    txtEmail.Clear();
                    txtSenha.Clear();
                }
            }
        }
    }
}
