namespace POOFOA242
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            MessageBox.Show($"Seja bem vindo(a) {nome}!");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
                btnClick.Enabled = false;
            else
                btnClick.Enabled = true;    
        }
    }
}