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
    public partial class editar2 : Form
    {
        public int ID;
        public editar2(int code)
        {
            InitializeComponent();
            ID = Convert.ToInt32(code);

            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=loja_roupas; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand Consulta = new MySqlCommand();

            Consulta.Connection = conectar;

            Consulta.CommandText = "SELECT * FROM cadastros WHERE id = " + ID;


            MySqlDataReader Resultado = Consulta.ExecuteReader();

            if (Resultado.Read())
            {
                textBox1.Text = Convert.ToString(Resultado["nome"]);
                textBox2.Text = Convert.ToString(Resultado["produto"]);
                textBox3.Text = Convert.ToString(Resultado["valor"]);
                textBox4.Text = Convert.ToString(Resultado["tamanho"]);
                textBox5.Text = Convert.ToString(Resultado["descricao"]);

            }
            else
            {
                MessageBox.Show("Nenhum Registro Foi encontrado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = Convert.ToString(textBox1.Text);
            string produto = Convert.ToString(textBox2.Text);
            string valor = Convert.ToString(textBox3.Text);
            string tamanho = Convert.ToString(textBox4.Text);
            string descricao = Convert.ToString(textBox5.Text);
            string codigo = Convert.ToString(textBox6.Text);

            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=loja_roupas; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand alterar = new MySqlCommand();

            alterar.Connection = conectar;

            string inserir = "UPDATE `cadastros` SET `nome`= '" + nome + "',`produto`= '" + produto + "',`valor`= '" + valor + "',`tamanho`= '" + tamanho + "',`descricao`= '" + descricao + "' WHERE id = '" + ID + "'";

            MySqlCommand comandos = new MySqlCommand(inserir, conectar);
            comandos.ExecuteNonQuery();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

            MessageBox.Show("Dados Alterados com Sucesso!!!");
            conectar.Close();
        }
    }
}
