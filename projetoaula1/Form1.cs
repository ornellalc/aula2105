namespace projetoaula1
{
    public partial class Frmprincipal : Form
    {
        public Frmprincipal()
        {
            InitializeComponent();
        }

        private void aruivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usu�rioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmusuario usuario = new frmusuario();
            usuario.ShowDialog();
        }
    }
}
