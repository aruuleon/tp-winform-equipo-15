namespace CatalogoWinForm
{
    partial class ModificarArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarArticulo));
            this.btnBeforeImgModificar = new System.Windows.Forms.Button();
            this.btnNextImgModificar = new System.Windows.Forms.Button();
            this.pbModificarArticulo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarImgModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubirImgAgregarArt = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBeforeImgModificar
            // 
            this.btnBeforeImgModificar.Location = new System.Drawing.Point(77, 454);
            this.btnBeforeImgModificar.Name = "btnBeforeImgModificar";
            this.btnBeforeImgModificar.Size = new System.Drawing.Size(29, 34);
            this.btnBeforeImgModificar.TabIndex = 27;
            this.btnBeforeImgModificar.Text = "<";
            this.btnBeforeImgModificar.UseVisualStyleBackColor = true;
            // 
            // btnNextImgModificar
            // 
            this.btnNextImgModificar.Location = new System.Drawing.Point(425, 454);
            this.btnNextImgModificar.Name = "btnNextImgModificar";
            this.btnNextImgModificar.Size = new System.Drawing.Size(29, 34);
            this.btnNextImgModificar.TabIndex = 26;
            this.btnNextImgModificar.Text = ">";
            this.btnNextImgModificar.UseVisualStyleBackColor = true;
            // 
            // pbModificarArticulo
            // 
            this.pbModificarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("pbModificarArticulo.Image")));
            this.pbModificarArticulo.Location = new System.Drawing.Point(113, 383);
            this.pbModificarArticulo.Name = "pbModificarArticulo";
            this.pbModificarArticulo.Size = new System.Drawing.Size(307, 169);
            this.pbModificarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbModificarArticulo.TabIndex = 25;
            this.pbModificarArticulo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(169, 573);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(204, 36);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarImgModificar
            // 
            this.btnEliminarImgModificar.BackColor = System.Drawing.Color.Red;
            this.btnEliminarImgModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarImgModificar.Location = new System.Drawing.Point(399, 383);
            this.btnEliminarImgModificar.Name = "btnEliminarImgModificar";
            this.btnEliminarImgModificar.Size = new System.Drawing.Size(21, 20);
            this.btnEliminarImgModificar.TabIndex = 38;
            this.btnEliminarImgModificar.Text = "X";
            this.btnEliminarImgModificar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "URL DE IMAGEN";
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Location = new System.Drawing.Point(143, 341);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(241, 20);
            this.txtUrlImg.TabIndex = 61;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(143, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(241, 20);
            this.txtCodigo.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "CODIGO";
            // 
            // btnSubirImgAgregarArt
            // 
            this.btnSubirImgAgregarArt.Location = new System.Drawing.Point(390, 339);
            this.btnSubirImgAgregarArt.Name = "btnSubirImgAgregarArt";
            this.btnSubirImgAgregarArt.Size = new System.Drawing.Size(76, 23);
            this.btnSubirImgAgregarArt.TabIndex = 58;
            this.btnSubirImgAgregarArt.Text = "Agregar";
            this.btnSubirImgAgregarArt.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(143, 284);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(241, 20);
            this.txtDescripcion.TabIndex = 57;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(140, 267);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 13);
            this.lblDescripcion.TabIndex = 56;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(143, 232);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(241, 20);
            this.txtPrecio.TabIndex = 55;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(140, 217);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 13);
            this.lblPrecio.TabIndex = 54;
            this.lblPrecio.Text = "PRECIO";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(143, 180);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(241, 21);
            this.cboMarca.TabIndex = 53;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(142, 165);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 13);
            this.lblMarca.TabIndex = 52;
            this.lblMarca.Text = "MARCA";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(143, 133);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(241, 21);
            this.cboCategoria.TabIndex = 51;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(140, 117);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 13);
            this.lblCategoria.TabIndex = 50;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(143, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(140, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 48;
            this.lblNombre.Text = "NOMBRE";
            // 
            // ModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrlImg);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubirImgAgregarArt);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEliminarImgModificar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBeforeImgModificar);
            this.Controls.Add(this.btnNextImgModificar);
            this.Controls.Add(this.pbModificarArticulo);
            this.MaximumSize = new System.Drawing.Size(553, 679);
            this.MinimumSize = new System.Drawing.Size(553, 675);
            this.Name = "ModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.pbModificarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBeforeImgModificar;
        private System.Windows.Forms.Button btnNextImgModificar;
        private System.Windows.Forms.PictureBox pbModificarArticulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarImgModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubirImgAgregarArt;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}