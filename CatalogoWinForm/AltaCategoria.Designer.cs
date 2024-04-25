namespace CatalogoWinForm
{
    partial class AltaCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbAltaCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.lblTituloAgregarCategoria = new System.Windows.Forms.Label();
            this.lblDescripcionAltaCat = new System.Windows.Forms.Label();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAltaCategoria
            // 
            this.tbAltaCategoria.Location = new System.Drawing.Point(283, 108);
            this.tbAltaCategoria.Name = "tbAltaCategoria";
            this.tbAltaCategoria.Size = new System.Drawing.Size(250, 20);
            this.tbAltaCategoria.TabIndex = 9;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(550, 102);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(160, 31);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // lblTituloAgregarCategoria
            // 
            this.lblTituloAgregarCategoria.AutoSize = true;
            this.lblTituloAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregarCategoria.Location = new System.Drawing.Point(288, 16);
            this.lblTituloAgregarCategoria.Name = "lblTituloAgregarCategoria";
            this.lblTituloAgregarCategoria.Size = new System.Drawing.Size(244, 25);
            this.lblTituloAgregarCategoria.TabIndex = 7;
            this.lblTituloAgregarCategoria.Text = "AGREGAR CATEGORIA";
            this.lblTituloAgregarCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescripcionAltaCat
            // 
            this.lblDescripcionAltaCat.AutoSize = true;
            this.lblDescripcionAltaCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionAltaCat.Location = new System.Drawing.Point(183, 109);
            this.lblDescripcionAltaCat.Name = "lblDescripcionAltaCat";
            this.lblDescripcionAltaCat.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcionAltaCat.TabIndex = 10;
            this.lblDescripcionAltaCat.Text = "Descripcion:";
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(693, 182);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(95, 22);
            this.btnCancelarAlta.TabIndex = 11;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // AltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.lblDescripcionAltaCat);
            this.Controls.Add(this.tbAltaCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblTituloAgregarCategoria);
            this.MaximumSize = new System.Drawing.Size(816, 255);
            this.MinimumSize = new System.Drawing.Size(816, 255);
            this.Name = "AltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Categoria";
            this.Load += new System.EventHandler(this.AltaCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAltaCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label lblTituloAgregarCategoria;
        private System.Windows.Forms.Label lblDescripcionAltaCat;
        private System.Windows.Forms.Button btnCancelarAlta;
    }
}