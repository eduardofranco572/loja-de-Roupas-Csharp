using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace LojadeRoupas
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string produto = textBox2.Text;
            string valor = textBox3.Text;
            string tamanho = textBox4.Text;
            string descricao = textBox5.Text;


            MySqlConnection conexao = new MySqlConnection();

            conexao.ConnectionString = ("SERVER=127.0.0.1; DATABASE=loja_roupas; UID=root; PASSWORD=;");
            conexao.Open();

            string inserir = "INSERT INTO cadastros (nome, produto, valor, tamanho, descricao ) VALUES ('" + nome + "', '" + produto + "', '" + valor + "', '" + tamanho + "', '" + descricao + "')";

            MySqlCommand comandos = new MySqlCommand(inserir, conexao);

            comandos.ExecuteNonQuery();

            conexao.Close();

            MessageBox.Show("Dados cadastrados com sucesso!!!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            conexao.Close();
        }
    }
}
