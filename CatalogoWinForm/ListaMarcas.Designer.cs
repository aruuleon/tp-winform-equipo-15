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
            this.btnAgregarMarcas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaMarcas
            // 
            this.dgvListaMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaMarcas.Location = new System.Drawing.Point(108, 128);
            this.dgvListaMarcas.MultiSelect = false;
            this.dgvListaMarcas.Name = "dgvListaMarcas";
            this.dgvListaMarcas.RowHeadersWidth = 51;
            this.dgvListaMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaMarcas.Size = new System.Drawing.Size(602, 202);
            this.dgvListaMarcas.TabIndex = 0;
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModificarMarcas.Location = new System.Drawing.Point(334, 359);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(174, 45);
            this.btnModificarMarcas.TabIndex = 2;
            this.btnModificarMarcas.Text = "MODIFICAR";
            this.btnModificarMarcas.UseVisualStyleBackColor = true;
            this.btnModificarMarcas.Click += new System.EventHandler(this.btnModificarMarcas_Click);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEliminarMarca.Location = new System.Drawing.Point(545, 359);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(165, 45);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "ELIMINAR";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
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
            this.tbBuscarMarcas.TabIndex = 5;
            this.tbBuscarMarcas.TextChanged += new System.EventHandler(this.tbBuscarMarcas_TextChanged);
            // 
            // btnBuscarMarcas
            // 
            this.btnBuscarMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarMarcas.Location = new System.Drawing.Point(644, 97);
            this.btnBuscarMarcas.Name = "btnBuscarMarcas";
            this.btnBuscarMarcas.Size = new System.Drawing.Size(66, 28);
            this.btnBuscarMarcas.TabIndex = 4;
            this.btnBuscarMarcas.Text = "BUSCAR";
            this.btnBuscarMarcas.UseVisualStyleBackColor = true;
            this.btnBuscarMarcas.Click += new System.EventHandler(this.btnBuscarMarcas_Click);
            // 
            // btnAgregarMarcas
            // 
            this.btnAgregarMarcas.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAgregarMarcas.Location = new System.Drawing.Point(108, 359);
            this.btnAgregarMarcas.Name = "btnAgregarMarcas";
            this.btnAgregarMarcas.Size = new System.Drawing.Size(174, 45);
            this.btnAgregarMarcas.TabIndex = 1;
            this.btnAgregarMarcas.Text = "AGREGAR";
            this.btnAgregarMarcas.UseVisualStyleBackColor = true;
            this.btnAgregarMarcas.Click += new System.EventHandler(this.btnAgregarMarcas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(2, 1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(69, 25);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "<--";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolverCat_Click);
            // 
            // ListaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarMarcas);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListaMarcas_Load);
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
        private System.Windows.Forms.Button btnAgregarMarcas;
        private System.Windows.Forms.Button btnVolver;
    }
}