namespace CatalogoWinForm
{
    partial class frmAgregarMarca
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
            this.lblTituloAgregarMarca = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.tbAgregarMarca = new System.Windows.Forms.TextBox();
            this.btnCancelarAlta = new System.Windows.Forms.Button();
            this.lblDescripcionAltaMarc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloAgregarMarca
            // 
            this.lblTituloAgregarMarca.AutoSize = true;
            this.lblTituloAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgregarMarca.Location = new System.Drawing.Point(287, 11);
            this.lblTituloAgregarMarca.Name = "lblTituloAgregarMarca";
            this.lblTituloAgregarMarca.Size = new System.Drawing.Size(198, 25);
            this.lblTituloAgregarMarca.TabIndex = 4;
            this.lblTituloAgregarMarca.Text = "AGREGAR MARCA";
            this.lblTituloAgregarMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(537, 102);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(160, 31);
            this.btnAgregarMarca.TabIndex = 5;
            this.btnAgregarMarca.Text = "AGREGAR";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // tbAgregarMarca
            // 
            this.tbAgregarMarca.Location = new System.Drawing.Point(283, 108);
            this.tbAgregarMarca.Name = "tbAgregarMarca";
            this.tbAgregarMarca.Size = new System.Drawing.Size(237, 20);
            this.tbAgregarMarca.TabIndex = 6;
            // 
            // btnCancelarAlta
            // 
            this.btnCancelarAlta.Location = new System.Drawing.Point(693, 182);
            this.btnCancelarAlta.Name = "btnCancelarAlta";
            this.btnCancelarAlta.Size = new System.Drawing.Size(95, 22);
            this.btnCancelarAlta.TabIndex = 13;
            this.btnCancelarAlta.Text = "Cancelar";
            this.btnCancelarAlta.UseVisualStyleBackColor = true;
            this.btnCancelarAlta.Click += new System.EventHandler(this.btnCancelarAlta_Click);
            // 
            // lblDescripcionAltaMarc
            // 
            this.lblDescripcionAltaMarc.AutoSize = true;
            this.lblDescripcionAltaMarc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionAltaMarc.Location = new System.Drawing.Point(183, 109);
            this.lblDescripcionAltaMarc.Name = "lblDescripcionAltaMarc";
            this.lblDescripcionAltaMarc.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcionAltaMarc.TabIndex = 12;
            this.lblDescripcionAltaMarc.Text = "Descripcion:";
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.btnCancelarAlta);
            this.Controls.Add(this.lblDescripcionAltaMarc);
            this.Controls.Add(this.tbAgregarMarca);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblTituloAgregarMarca);
            this.MaximumSize = new System.Drawing.Size(816, 255);
            this.MinimumSize = new System.Drawing.Size(816, 255);
            this.Name = "frmAgregarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Marca";
            this.Load += new System.EventHandler(this.frmAgregarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgregarMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.TextBox tbAgregarMarca;
        private System.Windows.Forms.Button btnCancelarAlta;
        private System.Windows.Forms.Label lblDescripcionAltaMarc;
    }
}