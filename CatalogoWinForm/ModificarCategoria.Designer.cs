namespace CatalogoWinForm
{
    partial class ModificarCategoria
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
            this.tbModificarCategoria = new System.Windows.Forms.TextBox();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.lblTituloModificarCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbModificarCategoria
            // 
            this.tbModificarCategoria.Location = new System.Drawing.Point(179, 125);
            this.tbModificarCategoria.Name = "tbModificarCategoria";
            this.tbModificarCategoria.Size = new System.Drawing.Size(320, 20);
            this.tbModificarCategoria.TabIndex = 15;
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(516, 119);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(160, 31);
            this.btnModificarCategoria.TabIndex = 14;
            this.btnModificarCategoria.Text = "MODIFICAR";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblTituloModificarCategoria
            // 
            this.lblTituloModificarCategoria.AutoSize = true;
            this.lblTituloModificarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModificarCategoria.Location = new System.Drawing.Point(287, 18);
            this.lblTituloModificarCategoria.Name = "lblTituloModificarCategoria";
            this.lblTituloModificarCategoria.Size = new System.Drawing.Size(256, 25);
            this.lblTituloModificarCategoria.TabIndex = 13;
            this.lblTituloModificarCategoria.Text = "MODIFICAR CATEGORIA";
            this.lblTituloModificarCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.tbModificarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.lblTituloModificarCategoria);
            this.MaximumSize = new System.Drawing.Size(816, 255);
            this.MinimumSize = new System.Drawing.Size(816, 255);
            this.Name = "ModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbModificarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Label lblTituloModificarCategoria;
    }
}