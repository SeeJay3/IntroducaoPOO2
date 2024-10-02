namespace ControleFinanceiro
{
    partial class frmCliente
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblCPF = new Label();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            btnInserir = new Button();
            btnExcluir = new Button();
            lstClientes = new ListBox();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(64, 48);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(64, 85);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "CPF:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(122, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(122, 82);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(100, 23);
            txtCPF.TabIndex = 3;
            // 
            // btnInserir
            // 
            btnInserir.Enabled = false;
            btnInserir.Location = new Point(64, 133);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 4;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Enabled = false;
            btnExcluir.Location = new Point(147, 133);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(64, 184);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(158, 109);
            lstClientes.TabIndex = 6;
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 450);
            Controls.Add(lstClientes);
            Controls.Add(btnExcluir);
            Controls.Add(btnInserir);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(lblNome);
            Name = "frmCliente";
            Text = "Controle de Clientes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblCPF;
        private TextBox txtNome;
        private TextBox txtCPF;
        private Button btnInserir;
        private Button btnExcluir;
        private ListBox lstClientes;
    }
}
