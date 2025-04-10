
namespace cadastroClientes
{
    partial class frmCadastroCliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbCons = new System.Windows.Forms.TabControl();
            this.tbDadosCliente = new System.Windows.Forms.TabPage();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.tcConsulta = new System.Windows.Forms.TabPage();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lstCliente = new System.Windows.Forms.ListView();
            this.pnlTop.SuspendLayout();
            this.tbCons.SuspendLayout();
            this.tbDadosCliente.SuspendLayout();
            this.tcConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(51, 34);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de clientes";
            // 
            // tbCons
            // 
            this.tbCons.Controls.Add(this.tbDadosCliente);
            this.tbCons.Controls.Add(this.tcConsulta);
            this.tbCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCons.Location = new System.Drawing.Point(30, 119);
            this.tbCons.Name = "tbCons";
            this.tbCons.SelectedIndex = 0;
            this.tbCons.Size = new System.Drawing.Size(738, 273);
            this.tbCons.TabIndex = 1;
            // 
            // tbDadosCliente
            // 
            this.tbDadosCliente.Controls.Add(this.txtCpf);
            this.tbDadosCliente.Controls.Add(this.lblCpf);
            this.tbDadosCliente.Controls.Add(this.txtEmail);
            this.tbDadosCliente.Controls.Add(this.lblEmail);
            this.tbDadosCliente.Controls.Add(this.txtNomeSocial);
            this.tbDadosCliente.Controls.Add(this.txtNomeCompleto);
            this.tbDadosCliente.Controls.Add(this.lblNomeSocial);
            this.tbDadosCliente.Controls.Add(this.lblNomeCompleto);
            this.tbDadosCliente.Location = new System.Drawing.Point(4, 29);
            this.tbDadosCliente.Name = "tbDadosCliente";
            this.tbDadosCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbDadosCliente.Size = new System.Drawing.Size(730, 240);
            this.tbDadosCliente.TabIndex = 0;
            this.tbDadosCliente.Text = "Dados de clientes";
            this.tbDadosCliente.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(81, 157);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(128, 26);
            this.txtCpf.TabIndex = 7;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCpf.Location = new System.Drawing.Point(18, 160);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(40, 20);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEmail.Location = new System.Drawing.Point(18, 114);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(122, 70);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(216, 26);
            this.txtNomeSocial.TabIndex = 3;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(147, 27);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(216, 26);
            this.txtNomeCompleto.TabIndex = 2;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNomeSocial.Location = new System.Drawing.Point(18, 73);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(98, 20);
            this.lblNomeSocial.TabIndex = 1;
            this.lblNomeSocial.Text = "Nome Social";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNomeCompleto.Location = new System.Drawing.Point(18, 30);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(123, 20);
            this.lblNomeCompleto.TabIndex = 0;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // tcConsulta
            // 
            this.tcConsulta.Controls.Add(this.lstCliente);
            this.tcConsulta.Controls.Add(this.btnPesquisar);
            this.tcConsulta.Controls.Add(this.txtBuscar);
            this.tcConsulta.Location = new System.Drawing.Point(4, 29);
            this.tcConsulta.Name = "tcConsulta";
            this.tcConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tcConsulta.Size = new System.Drawing.Size(730, 240);
            this.tcConsulta.TabIndex = 1;
            this.tcConsulta.Text = "Consulta";
            this.tcConsulta.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(22, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(224, 26);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(34, 398);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 30);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(284, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 26);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lstCliente
            // 
            this.lstCliente.HideSelection = false;
            this.lstCliente.Location = new System.Drawing.Point(22, 78);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(684, 145);
            this.lstCliente.TabIndex = 2;
            this.lstCliente.UseCompatibleStateImageBehavior = false;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbCons);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmCadastroCliente";
            this.Text = "Cadastro Cliente";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tbCons.ResumeLayout(false);
            this.tbDadosCliente.ResumeLayout(false);
            this.tbDadosCliente.PerformLayout();
            this.tcConsulta.ResumeLayout(false);
            this.tcConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tbCons;
        private System.Windows.Forms.TabPage tbDadosCliente;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TabPage tcConsulta;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ListView lstCliente;
    }
}

