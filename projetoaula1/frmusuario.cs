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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            string data_source = "datasource=localhost;username=root;password='',database=sistema";




        }
    }
}
