using ControleFinanceiro.Model;
using Microsoft.Win32;
using System;
using System.Windows.Forms;

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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void VerificarCaixasPreenchidas()
        {
            if (txtNome.Text != "" && txtCPF.Text != "")
                btnInserir.Enabled = true;
            else
                btnInserir.Enabled = false;
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            VerificarCaixasPreenchidas();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = txtNome.Text;
            cliente.CPF = txtCPF.Text;
            lstClientes.Items.Add(cliente.ToString());
            LimparCaixas();
        }

        private void LimparCaixas()
        {
            txtCPF.Clear();
            txtNome.Clear();
        }
        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstClientes.SelectedIndex != -1)
                btnExcluir.Enabled = true;
            else btnExcluir.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstClientes.SelectedIndex;
            if (selectedIndex != -1)
            {
              lstClientes.Items.RemoveAt(selectedIndex);
            }
        }
    }
}