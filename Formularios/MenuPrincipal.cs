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
    public partial class MenuPrincipal : Form
    {
        // Objetos globais:
        private Usuario _u;
        //private Produto _p;

        public MenuPrincipal(Usuario u)
        {
            InitializeComponent();
            _u = u;
            lblRecepcao.Text = "Olá " + u.NomeCompleto + "! Escolha uma opção abaixo:";
            // Ocultar o botão de usuários de todos, exceto o Admin:
            if(u.Id != 1)
            {
                btnUsuarios.Visible = false;
            }
        }
        private void btnComandas_Click(object sender, EventArgs e)
        {

        }

        private void lblRecepcao_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var menuusuarios = new GerenciadorUsuarios(_u);
            menuusuarios.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            var menuprodutos = new GerenciadorProdutos(_u);
            menuprodutos.ShowDialog();
        }
    }
}
