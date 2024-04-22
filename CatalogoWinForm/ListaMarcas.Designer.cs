namespace CatalogoWinForm
{
    partial class ListaMarcas
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
            this.dgvListaMarcas = new System.Windows.Forms.DataGridView();
            this.btnModificarMarcas = new System.Windows.Forms.Button();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.lblTituloMarcas = new System.Windows.Forms.Label();
            this.tbBuscarMarcas = new System.Windows.Forms.TextBox();
            this.btnBuscarMarcas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaMarcas
            // 
            this.dgvListaMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMarcas.Location = new System.Drawing.Point(108, 128);
            this.dgvListaMarcas.Name = "dgvListaMarcas";
            this.dgvListaMarcas.Size = new System.Drawing.Size(602, 202);
            this.dgvListaMarcas.TabIndex = 0;
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarMarcas.Location = new System.Drawing.Point(108, 359);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(174, 45);
            this.btnModificarMarcas.TabIndex = 1;
            this.btnModificarMarcas.Text = "MODIFICAR";
            this.btnModificarMarcas.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarMarca.Location = new System.Drawing.Point(545, 359);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(165, 45);
            this.btnEliminarMarca.TabIndex = 2;
            this.btnEliminarMarca.Text = "ELIMINAR";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // lblTituloMarcas
            // 
            this.lblTituloMarcas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloMarcas.AutoSize = true;
            this.lblTituloMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMarcas.Location = new System.Drawing.Point(351, 44);
            this.lblTituloMarcas.Name = "lblTituloMarcas";
            this.lblTituloMarcas.Size = new System.Drawing.Size(102, 25);
            this.lblTituloMarcas.TabIndex = 3;
            this.lblTituloMarcas.Text = "MARCAS";
            this.lblTituloMarcas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbBuscarMarcas
            // 
            this.tbBuscarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuscarMarcas.Location = new System.Drawing.Point(472, 102);
            this.tbBuscarMarcas.Name = "tbBuscarMarcas";
            this.tbBuscarMarcas.Size = new System.Drawing.Size(166, 20);
            this.tbBuscarMarcas.TabIndex = 4;
            // 
            // btnBuscarMarcas
            // 
            this.btnBuscarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarMarcas.Location = new System.Drawing.Point(644, 97);
            this.btnBuscarMarcas.Name = "btnBuscarMarcas";
            this.btnBuscarMarcas.Size = new System.Drawing.Size(66, 28);
            this.btnBuscarMarcas.TabIndex = 5;
            this.btnBuscarMarcas.Text = "BUSCAR";
            this.btnBuscarMarcas.UseVisualStyleBackColor = true;
            // 
            // ListaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarMarcas);
            this.Controls.Add(this.tbBuscarMarcas);
            this.Controls.Add(this.lblTituloMarcas);
            this.Controls.Add(this.btnEliminarMarca);
            this.Controls.Add(this.btnModificarMarcas);
            this.Controls.Add(this.dgvListaMarcas);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ListaMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaMarcas;
        private System.Windows.Forms.Button btnModificarMarcas;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Label lblTituloMarcas;
        private System.Windows.Forms.TextBox tbBuscarMarcas;
        private System.Windows.Forms.Button btnBuscarMarcas;
    }
}