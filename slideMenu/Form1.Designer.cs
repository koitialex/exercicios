
namespace slideMenu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlSlideColor = new System.Windows.Forms.Panel();
            this.btnHomee = new System.Windows.Forms.Button();
            this.btnConficuracao = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.pnlSlideBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.slideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Label();
            this.pnlSlideColor.SuspendLayout();
            this.pnlSlideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSlideColor
            // 
            this.pnlSlideColor.BackColor = System.Drawing.Color.DimGray;
            this.pnlSlideColor.Controls.Add(this.btnHomee);
            this.pnlSlideColor.Controls.Add(this.btnConficuracao);
            this.pnlSlideColor.Controls.Add(this.btnSobre);
            this.pnlSlideColor.Controls.Add(this.btnAjuda);
            this.pnlSlideColor.Controls.Add(this.pnlSlideBar);
            this.pnlSlideColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlideColor.Location = new System.Drawing.Point(0, 0);
            this.pnlSlideColor.MaximumSize = new System.Drawing.Size(200, 0);
            this.pnlSlideColor.MinimumSize = new System.Drawing.Size(75, 0);
            this.pnlSlideColor.Name = "pnlSlideColor";
            this.pnlSlideColor.Size = new System.Drawing.Size(200, 494);
            this.pnlSlideColor.TabIndex = 0;
            // 
            // btnHomee
            // 
            this.btnHomee.BackColor = System.Drawing.Color.Transparent;
            this.btnHomee.FlatAppearance.BorderSize = 0;
            this.btnHomee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomee.ForeColor = System.Drawing.Color.White;
            this.btnHomee.Image = ((System.Drawing.Image)(resources.GetObject("btnHomee.Image")));
            this.btnHomee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomee.Location = new System.Drawing.Point(0, 76);
            this.btnHomee.Name = "btnHomee";
            this.btnHomee.Padding = new System.Windows.Forms.Padding(1);
            this.btnHomee.Size = new System.Drawing.Size(200, 45);
            this.btnHomee.TabIndex = 3;
            this.btnHomee.Text = "                Home";
            this.btnHomee.UseVisualStyleBackColor = false;
            this.btnHomee.Click += new System.EventHandler(this.btnHomee_Click_1);
            // 
            // btnConficuracao
            // 
            this.btnConficuracao.BackColor = System.Drawing.Color.Transparent;
            this.btnConficuracao.FlatAppearance.BorderSize = 0;
            this.btnConficuracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConficuracao.ForeColor = System.Drawing.Color.White;
            this.btnConficuracao.Image = ((System.Drawing.Image)(resources.GetObject("btnConficuracao.Image")));
            this.btnConficuracao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConficuracao.Location = new System.Drawing.Point(0, 127);
            this.btnConficuracao.Name = "btnConficuracao";
            this.btnConficuracao.Padding = new System.Windows.Forms.Padding(1);
            this.btnConficuracao.Size = new System.Drawing.Size(200, 45);
            this.btnConficuracao.TabIndex = 3;
            this.btnConficuracao.Text = "                Configuração";
            this.btnConficuracao.UseVisualStyleBackColor = false;
            this.btnConficuracao.Click += new System.EventHandler(this.btnConficuracao_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.Transparent;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Image = ((System.Drawing.Image)(resources.GetObject("btnSobre.Image")));
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(0, 229);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Padding = new System.Windows.Forms.Padding(1);
            this.btnSobre.Size = new System.Drawing.Size(200, 45);
            this.btnSobre.TabIndex = 3;
            this.btnSobre.Text = "                Sobre nós";
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.ForeColor = System.Drawing.Color.White;
            this.btnAjuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAjuda.Image")));
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.Location = new System.Drawing.Point(0, 178);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(1);
            this.btnAjuda.Size = new System.Drawing.Size(200, 45);
            this.btnAjuda.TabIndex = 3;
            this.btnAjuda.Text = "                Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // pnlSlideBar
            // 
            this.pnlSlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSlideBar.Controls.Add(this.panelLogo);
            this.pnlSlideBar.Controls.Add(this.panel1);
            this.pnlSlideBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlSlideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSlideBar.Name = "pnlSlideBar";
            this.pnlSlideBar.Size = new System.Drawing.Size(207, 60);
            this.pnlSlideBar.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(17, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(1);
            this.btnHome.Size = new System.Drawing.Size(156, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "                Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // slideBarTimer
            // 
            this.slideBarTimer.Interval = 10;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.lblTitulo);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(600, 60);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(223, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(95, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HOME";
            // 
            // panelLogo
            // 
            this.panelLogo.AutoSize = true;
            this.panelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.ForeColor = System.Drawing.Color.White;
            this.panelLogo.Location = new System.Drawing.Point(50, 19);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(97, 25);
            this.panelLogo.TabIndex = 2;
            this.panelLogo.Text = "Empresa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.pnlSlideColor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlSlideColor.ResumeLayout(false);
            this.pnlSlideBar.ResumeLayout(false);
            this.pnlSlideBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSlideColor;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlSlideBar;
        private System.Windows.Forms.Timer slideBarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHomee;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnConficuracao;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitulo;
    }
}

