namespace Projeto_SuperHeroi_Vilao
{
    public partial class Pessoa : Form
    {
        public Pessoa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pessoa_Load(object sender, EventArgs e)
        {

        }
        private void btnProx1_Click(object sender, EventArgs e)
        {
            SuperHeroi superHeroi = new SuperHeroi();
            superHeroi.ShowDialog();
            this.Hide();
        }
        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            txtEmail.Text = " ";
        }
    }
}