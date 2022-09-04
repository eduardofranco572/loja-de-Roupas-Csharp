using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeRoupas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDosLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastrar = new Cadastro();
            cadastrar.Show();
        }

        private void pesquisarUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pesquisa pesquisar = new pesquisa();
            pesquisar.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editar1 alterar = new editar1();
            alterar.Show();
        }

        private void excluirUmLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluir1 deletar = new excluir1();
            deletar.Show();
        }
    }
}
