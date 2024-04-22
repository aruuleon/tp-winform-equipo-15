namespace CatalogoWinForm
{
    partial class ModificarMarca
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
            this.tbModificarMarca = new System.Windows.Forms.TextBox();
            this.btnModificarMarca = new System.Windows.Forms.Button();
            this.lblTituloModificarMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbModificarMarca
            // 
            this.tbModificarMarca.Location = new System.Drawing.Point(172, 129);
            this.tbModificarMarca.Name = "tbModificarMarca";
            this.tbModificarMarca.Size = new System.Drawing.Size(320, 20);
            this.tbModificarMarca.TabIndex = 12;
            // 
            // btnModificarMarca
            // 
            this.btnModificarMarca.Location = new System.Drawing.Point(509, 123);
            this.btnModificarMarca.Name = "btnModificarMarca";
            this.btnModificarMarca.Size = new System.Drawing.Size(160, 31);
            this.btnModificarMarca.TabIndex = 11;
            this.btnModificarMarca.Text = "MODIFICAR";
            this.btnModificarMarca.UseVisualStyleBackColor = true;
            // 
            // lblTituloModificarMarca
            // 
            this.lblTituloModificarMarca.AutoSize = true;
            this.lblTituloModificarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloModificarMarca.Location = new System.Drawing.Point(280, 22);
            this.lblTituloModificarMarca.Name = "lblTituloModificarMarca";
            this.lblTituloModificarMarca.Size = new System.Drawing.Size(210, 25);
            this.lblTituloModificarMarca.TabIndex = 10;
            this.lblTituloModificarMarca.Text = "MODIFICAR MARCA";
            this.lblTituloModificarMarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 216);
            this.Controls.Add(this.tbModificarMarca);
            this.Controls.Add(this.btnModificarMarca);
            this.Controls.Add(this.lblTituloModificarMarca);
            this.MaximumSize = new System.Drawing.Size(816, 255);
            this.MinimumSize = new System.Drawing.Size(816, 255);
            this.Name = "ModificarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbModificarMarca;
        private System.Windows.Forms.Button btnModificarMarca;
        private System.Windows.Forms.Label lblTituloModificarMarca;
    }
}