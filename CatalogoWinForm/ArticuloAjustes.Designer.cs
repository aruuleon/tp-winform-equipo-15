namespace CatalogoWinForm {
    partial class ArticuloAjustes {
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
            this.btnListaArticulos = new System.Windows.Forms.Button();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.lblTituloInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnListaArticulos
            // 
            this.btnListaArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnListaArticulos.Location = new System.Drawing.Point(302, 303);
            this.btnListaArticulos.Name = "btnListaArticulos";
            this.btnListaArticulos.Size = new System.Drawing.Size(197, 49);
            this.btnListaArticulos.TabIndex = 24;
            this.btnListaArticulos.Text = "LISTA ARTICULOS";
            this.btnListaArticulos.UseVisualStyleBackColor = true;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(302, 228);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(197, 49);
            this.btnAgregarArticulo.TabIndex = 23;
            this.btnAgregarArticulo.Text = "AGREGAR ARTICULO";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            // 
            // lblTituloInicio
            // 
            this.lblTituloInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloInicio.AutoSize = true;
            this.lblTituloInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInicio.Location = new System.Drawing.Point(331, 99);
            this.lblTituloInicio.Name = "lblTituloInicio";
            this.lblTituloInicio.Size = new System.Drawing.Size(131, 25);
            this.lblTituloInicio.TabIndex = 22;
            this.lblTituloInicio.Text = "ARTICULOS";
            // 
            // ArticuloAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListaArticulos);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.lblTituloInicio);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ArticuloAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticuloAjustes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListaArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Label lblTituloInicio;
    }
}