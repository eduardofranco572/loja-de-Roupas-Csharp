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
    public partial class excluir2 : Form
    {
        public int ID;
        public excluir2(int code)
        {
            InitializeComponent();
            ID = Convert.ToInt32(code);
            MySqlConnection conectar = new MySqlConnection("SERVER = localhost; DATABASE=loja_roupas; UID=root; PASSWORD=");
            conectar.Open();

            MySqlCommand Consulta = new MySqlCommand();

            Consulta.Connection = conectar;

            Consulta.CommandText = "SELECT * FROM cadastros";

            dataGridView1.Rows.Clear();

            MySqlDataReader Resultado = Consulta.ExecuteReader();

            if (Resultado.HasRows)
            {
                while (Resultado.Read())
                {
                    dataGridView1.Rows.Add(
                    Resultado["id"].ToString(),
                    Resultado["nome"].ToString(),
                    Resultado["produto"].ToString(),
                    Resultado["valor"].ToString(),
                    Resultado["tamanho"].ToString(),
                    Resultado["descricao"].ToString()
                    );
                }
            }
            else
            {
                MessageBox.Show("Nenhum Registro Foi encontrado");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar2 = new MySqlConnection("SERVER = localhost; DATABASE=loja_roupas; UID=root; PASSWORD=");
            conectar2.Open();

            MySqlCommand deletar = new MySqlCommand();

            deletar.Connection = conectar2;

            deletar.CommandText = "DELETE FROM `cadastros` WHERE id =  " + ID;

            dataGridView1.Rows.Clear();

            MySqlDataReader Resultado = deletar.ExecuteReader();

            MessageBox.Show("Dados Excluidos com Sucesso!!!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            excluir1 excluir = new excluir1();
            excluir.Show();
        }
    }
}
