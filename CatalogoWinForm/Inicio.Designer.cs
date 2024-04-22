namespace CatalogoWinForm {
    partial class Inicio {
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
            this.btnIncioArticulos = new System.Windows.Forms.Button();
            this.btnIncioMarcas = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.lblTituloInicio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIncioArticulos
            // 
            this.btnIncioArticulos.Location = new System.Drawing.Point(281, 242);
            this.btnIncioArticulos.Name = "btnIncioArticulos";
            this.btnIncioArticulos.Size = new System.Drawing.Size(245, 103);
            this.btnIncioArticulos.TabIndex = 15;
            this.btnIncioArticulos.Text = "ARTICULOS";
            this.btnIncioArticulos.UseVisualStyleBackColor = true;
            // 
            // btnIncioMarcas
            // 
            this.btnIncioMarcas.Location = new System.Drawing.Point(26, 242);
            this.btnIncioMarcas.Name = "btnIncioMarcas";
            this.btnIncioMarcas.Size = new System.Drawing.Size(197, 103);
            this.btnIncioMarcas.TabIndex = 16;
            this.btnIncioMarcas.Text = "MARCAS";
            this.btnIncioMarcas.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(587, 242);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(201, 103);
            this.btnCategorias.TabIndex = 17;
            this.btnCategorias.Text = "CATEGORIAS";
            this.btnCategorias.UseVisualStyleBackColor = true;
            // 
            // lblTituloInicio
            // 
            this.lblTituloInicio.AutoSize = true;
            this.lblTituloInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInicio.Location = new System.Drawing.Point(290, 73);
            this.lblTituloInicio.Name = "lblTituloInicio";
            this.lblTituloInicio.Size = new System.Drawing.Size(236, 25);
            this.lblTituloInicio.TabIndex = 18;
            this.lblTituloInicio.Text = "CATALOGO WINFORM";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTituloInicio);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnIncioMarcas);
            this.Controls.Add(this.btnIncioArticulos);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIncioArticulos;
        private System.Windows.Forms.Button btnIncioMarcas;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Label lblTituloInicio;
    }
}

