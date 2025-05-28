using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace projetoaula1
{
    public partial class frmusuario : Form
    {
        MySqlConnection conexao;
        public frmusuario()
        {
            InitializeComponent();
        }

        private void frmusuario_Load(object sender, EventArgs e)
        {
            Dados_usuario.DataSource = obterdados();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password='',database=sistema";
            //abrindo a conexão
            conexao = new MySqlConnection(data_source);
            //criando o script sql para inserir as informações
            string sql = "insert into usuario(nome,email,senha) values('" + Nome.Text + "','" + email.Text + "','" + senha.Text + "')";
            //montar o script sql para executar
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            //abrir o banco de dados
            conexao.Open();

            //se estiver vazio
            if (Nome.Text == "")
            {
                //Alerta para o usuário mensagem verdadeira
                MessageBox.Show("Nome está vazio!");
            }
            else
            {
                // alerta para o usuário preenchido
                MessageBox.Show("campo preenchido!");

                if (email.Text == "")
                    MessageBox.Show("email está vazio!");

                if (senha.Text == "")
                    MessageBox.Show("senha está vazia!");

                if (senha.Text != "" && email.Text != "" && Nome.Text != "")
                {
                    //executar a consulta no banco de dados
                    comando.ExecuteNonQuery();
                }
            }
        }

        public DataTable obterdados()
        {

            DataTable dt = new DataTable();
            //caminho de configuração do servidor
            string data_source = "datasource=localhost;username=root;password='';database=sistema";
            //abrindo a conexao
            conexao = new MySqlConnection(data_source);
            //criando o script sql para consultar as informções 
            string sql = "SELECT * from usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            //abrir banco de dados
            conexao.Open();
            //montar a consulta com as informações
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            //montando a tabela
            adapter.Fill(dt);
            //fecho a conexao
            conexao.Close();
            return dt;
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
