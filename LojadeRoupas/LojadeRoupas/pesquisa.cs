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
    public partial class pesquisa : Form
    {
        public pesquisa()
        {
            InitializeComponent();
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

        private void pesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}
