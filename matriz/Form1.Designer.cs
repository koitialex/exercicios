
namespace ArraysBidimensional
{
    partial class frmBidimensional
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(338, 108);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(71, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Matriz 3 por 3";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(302, 299);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(156, 49);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar o maior número";
            this.btnMostrar.UseVisualStyleBackColor = true;

            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(328, 139);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(100, 95);
            this.txtDisplay.TabIndex = 3;
            // 
            // frmBidimensional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmBidimensional";
            this.Text = "array bidimencional";

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.TextBox txtDisplay;
    }
}

