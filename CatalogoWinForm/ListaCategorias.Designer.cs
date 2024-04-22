namespace CatalogoWinForm
{
    partial class ListaCategorias
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
            this.btnBuscarCategorias = new System.Windows.Forms.Button();
            this.tbBuscarCategorias = new System.Windows.Forms.TextBox();
            this.lblTituloCategorias = new System.Windows.Forms.Label();
            this.btnEliminarCategorias = new System.Windows.Forms.Button();
            this.btnModificarCategorias = new System.Windows.Forms.Button();
            this.dgvListaCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCategorias
            // 
            this.btnBuscarCategorias.Location = new System.Drawing.Point(635, 98);
            this.btnBuscarCategorias.Name = "btnBuscarCategorias";
            this.btnBuscarCategorias.Size = new System.Drawing.Size(66, 28);
            this.btnBuscarCategorias.TabIndex = 11;
            this.btnBuscarCategorias.Text = "BUSCAR";
            this.btnBuscarCategorias.UseVisualStyleBackColor = true;
            // 
            // tbBuscarCategorias
            // 
            this.tbBuscarCategorias.Location = new System.Drawing.Point(463, 103);
            this.tbBuscarCategorias.Name = "tbBuscarCategorias";
            this.tbBuscarCategorias.Size = new System.Drawing.Size(166, 20);
            this.tbBuscarCategorias.TabIndex = 10;
            // 
            // lblTituloCategorias
            // 
            this.lblTituloCategorias.AutoSize = true;
            this.lblTituloCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategorias.Location = new System.Drawing.Point(342, 45);
            this.lblTituloCategorias.Name = "lblTituloCategorias";
            this.lblTituloCategorias.Size = new System.Drawing.Size(148, 25);
            this.lblTituloCategorias.TabIndex = 9;
            this.lblTituloCategorias.Text = "CATEGORIAS";
            this.lblTituloCategorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEliminarCategorias
            // 
            this.btnEliminarCategorias.Location = new System.Drawing.Point(536, 360);
            this.btnEliminarCategorias.Name = "btnEliminarCategorias";
            this.btnEliminarCategorias.Size = new System.Drawing.Size(165, 45);
            this.btnEliminarCategorias.TabIndex = 8;
            this.btnEliminarCategorias.Text = "ELIMINAR";
            this.btnEliminarCategorias.UseVisualStyleBackColor = true;
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.Location = new System.Drawing.Point(99, 360);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(174, 45);
            this.btnModificarCategorias.TabIndex = 7;
            this.btnModificarCategorias.Text = "MODIFICAR";
            this.btnModificarCategorias.UseVisualStyleBackColor = true;
            // 
            // dgvListaCategorias
            // 
            this.dgvListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCategorias.Location = new System.Drawing.Point(99, 129);
            this.dgvListaCategorias.Name = "dgvListaCategorias";
            this.dgvListaCategorias.Size = new System.Drawing.Size(602, 202);
            this.dgvListaCategorias.TabIndex = 6;
            // 
            // ListaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarCategorias);
            this.Controls.Add(this.tbBuscarCategorias);
            this.Controls.Add(this.lblTituloCategorias);
            this.Controls.Add(this.btnEliminarCategorias);
            this.Controls.Add(this.btnModificarCategorias);
            this.Controls.Add(this.dgvListaCategorias);
            this.Name = "ListaCategorias";
            this.Text = "Lista de Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCategorias;
        private System.Windows.Forms.TextBox tbBuscarCategorias;
        private System.Windows.Forms.Label lblTituloCategorias;
        private System.Windows.Forms.Button btnEliminarCategorias;
        private System.Windows.Forms.Button btnModificarCategorias;
        private System.Windows.Forms.DataGridView dgvListaCategorias;
    }
}