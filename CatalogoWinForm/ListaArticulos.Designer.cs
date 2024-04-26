namespace CatalogoWinForm {
    partial class ListaArticulos {
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
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.dgvListaArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(148, 145);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(154, 28);
            this.cboMarca.TabIndex = 11;
            this.cboMarca.Text = "Filtro por Marca..";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(336, 145);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(169, 28);
            this.cboCategoria.TabIndex = 12;
            this.cboCategoria.Text = "Filtro por Categoria";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbBuscar.Location = new System.Drawing.Point(648, 148);
            this.txbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.Size = new System.Drawing.Size(280, 26);
            this.txbBuscar.TabIndex = 13;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(939, 145);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 35);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificar.Location = new System.Drawing.Point(399, 586);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(198, 57);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(854, 586);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(198, 57);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDetalle.Location = new System.Drawing.Point(628, 586);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(198, 57);
            this.btnDetalle.TabIndex = 18;
            this.btnDetalle.Text = "VER DETALLE";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(490, 26);
            this.lblTituloArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(199, 37);
            this.lblTituloArticulos.TabIndex = 19;
            this.lblTituloArticulos.Text = "ARTICULOS";
            // 
            // dgvListaArticulos
            // 
            this.dgvListaArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaArticulos.Location = new System.Drawing.Point(148, 220);
            this.dgvListaArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListaArticulos.MultiSelect = false;
            this.dgvListaArticulos.Name = "dgvListaArticulos";
            this.dgvListaArticulos.RowHeadersWidth = 62;
            this.dgvListaArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArticulos.Size = new System.Drawing.Size(903, 331);
            this.dgvListaArticulos.TabIndex = 20;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarArticulo.Location = new System.Drawing.Point(148, 586);
            this.btnAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(198, 57);
            this.btnAgregarArticulo.TabIndex = 21;
            this.btnAgregarArticulo.Text = "AGREGAR";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(3, 5);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 38);
            this.btnVolver.TabIndex = 22;
            this.btnVolver.Text = "<--";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // ListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.dgvListaArticulos);
            this.Controls.Add(this.lblTituloArticulos);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.MinimumSize = new System.Drawing.Size(1213, 722);
            this.Name = "ListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.DataGridView dgvListaArticulos;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.Button btnVolver;
    }
}