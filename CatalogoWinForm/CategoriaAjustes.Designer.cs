namespace CatalogoWinForm {
    partial class CategoriaAjustes {
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
            this.btnListaCategorias = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.lblTituloInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListaCategorias
            // 
            this.btnListaCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListaCategorias.Location = new System.Drawing.Point(302, 303);
            this.btnListaCategorias.Name = "btnListaCategorias";
            this.btnListaCategorias.Size = new System.Drawing.Size(197, 49);
            this.btnListaCategorias.TabIndex = 24;
            this.btnListaCategorias.Text = "LISTA CATEGORIAS";
            this.btnListaCategorias.UseVisualStyleBackColor = true;
            this.btnListaCategorias.Click += new System.EventHandler(this.btnListaCategorias_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(302, 228);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(197, 49);
            this.btnAgregarCategoria.TabIndex = 23;
            this.btnAgregarCategoria.Text = "AGREGAR CATEGORIA";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblTituloInicio
            // 
            this.lblTituloInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloInicio.AutoSize = true;
            this.lblTituloInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInicio.Location = new System.Drawing.Point(331, 99);
            this.lblTituloInicio.Name = "lblTituloInicio";
            this.lblTituloInicio.Size = new System.Drawing.Size(148, 25);
            this.lblTituloInicio.TabIndex = 22;
            this.lblTituloInicio.Text = "CATEGORIAS";
            // 
            // CategoriaAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListaCategorias);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblTituloInicio);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "CategoriaAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriaAjustes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaCategorias;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label lblTituloInicio;
    }
}