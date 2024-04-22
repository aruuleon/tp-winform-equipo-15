namespace CatalogoWinForm {
    partial class MarcaAjustes {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnListaMarcas = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.lblTituloInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListaMarcas
            // 
            this.btnListaMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListaMarcas.Location = new System.Drawing.Point(302, 303);
            this.btnListaMarcas.Name = "btnListaMarcas";
            this.btnListaMarcas.Size = new System.Drawing.Size(197, 49);
            this.btnListaMarcas.TabIndex = 27;
            this.btnListaMarcas.Text = "LISTA MARCAS";
            this.btnListaMarcas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarMarca.Location = new System.Drawing.Point(302, 228);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(197, 49);
            this.btnAgregarMarca.TabIndex = 26;
            this.btnAgregarMarca.Text = "AGREGAR MARCA";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // lblTituloInicio
            // 
            this.lblTituloInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloInicio.AutoSize = true;
            this.lblTituloInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInicio.Location = new System.Drawing.Point(355, 99);
            this.lblTituloInicio.Name = "lblTituloInicio";
            this.lblTituloInicio.Size = new System.Drawing.Size(102, 25);
            this.lblTituloInicio.TabIndex = 25;
            this.lblTituloInicio.Text = "MARCAS";
            // 
            // MarcaAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListaMarcas);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblTituloInicio);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MarcaAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarcaAjustes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaMarcas;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Label lblTituloInicio;
    }
}