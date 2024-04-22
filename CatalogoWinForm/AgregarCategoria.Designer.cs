namespace CatalogoWinForm
{
    partial class AgregarCategoria
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
            this.tbAgregarCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.lblTituloAgregarCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAgregarCategoria
            // 
            this.tbAgregarCategoria.Location = new System.Drawing.Point(180, 123);
            this.tbAgregarCategoria.Name = "tbAgregarCategoria";
            this.tbAgregarCategoria.Size = new System.Drawing.Size(320, 20);
            this.tbAgregarCategoria.TabIndex = 9;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(517, 117);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(160, 31);
            this.btnAgregarCategoria.TabIndex = 8;
            this.btnAgregarCategoria.Text = "AGREGAR";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
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
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.tbAgregarCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.lblTituloAgregarCategoria);
            this.MaximumSize = new System.Drawing.Size(816, 255);
            this.MinimumSize = new System.Drawing.Size(816, 255);
            this.Name = "AgregarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label lblTituloAgregarCategoria;
    }
}