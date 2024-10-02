namespace ControleFinanceiro
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" | txtCPF == "")
                btnInserir.Enabled = false;
            else
                btnInserir.Enabled = true;
        }
    }
}
