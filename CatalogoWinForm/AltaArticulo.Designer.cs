namespace CatalogoWinForm
{
    partial class AltaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaArticulo));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnSubirImgAgregarArt = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.btnBeforeImg = new System.Windows.Forms.Button();
            this.btnNextImg = new System.Windows.Forms.Button();
            this.pbImgAgregar = new System.Windows.Forms.PictureBox();
            this.txtUrlImg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(246, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(79, 20);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(250, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 26);
            this.txtNombre.TabIndex = 13;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(246, 167);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(104, 20);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(250, 192);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(360, 28);
            this.cboCategoria.TabIndex = 17;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(249, 241);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 20);
            this.lblMarca.TabIndex = 18;
            this.lblMarca.Text = "MARCA";
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(250, 264);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(360, 28);
            this.cboMarca.TabIndex = 19;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(246, 321);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(70, 20);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(250, 344);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(360, 26);
            this.txtPrecio.TabIndex = 23;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(292, 867);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(273, 52);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(250, 424);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(360, 26);
            this.txtDescripcion.TabIndex = 26;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(246, 398);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(120, 20);
            this.lblDescripcion.TabIndex = 25;
            this.lblDescripcion.Text = "DESCRIPCION";
            // 
            // btnSubirImgAgregarArt
            // 
            this.btnSubirImgAgregarArt.Location = new System.Drawing.Point(621, 509);
            this.btnSubirImgAgregarArt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubirImgAgregarArt.Name = "btnSubirImgAgregarArt";
            this.btnSubirImgAgregarArt.Size = new System.Drawing.Size(114, 35);
            this.btnSubirImgAgregarArt.TabIndex = 38;
            this.btnSubirImgAgregarArt.Text = "Agregar";
            this.btnSubirImgAgregarArt.UseVisualStyleBackColor = true;
            this.btnSubirImgAgregarArt.Click += new System.EventHandler(this.btnSubirImgAgregarArt_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(250, 121);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(360, 26);
            this.txtCodigo.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "CODIGO";
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.BackColor = System.Drawing.Color.Red;
            this.btnEliminarImg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarImg.Location = new System.Drawing.Point(632, 577);
            this.btnEliminarImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(32, 31);
            this.btnEliminarImg.TabIndex = 45;
            this.btnEliminarImg.Text = "X";
            this.btnEliminarImg.UseVisualStyleBackColor = false;
            this.btnEliminarImg.Click += new System.EventHandler(this.btnEliminarImg_Click);
            // 
            // btnBeforeImg
            // 
            this.btnBeforeImg.Location = new System.Drawing.Point(150, 686);
            this.btnBeforeImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBeforeImg.Name = "btnBeforeImg";
            this.btnBeforeImg.Size = new System.Drawing.Size(44, 52);
            this.btnBeforeImg.TabIndex = 44;
            this.btnBeforeImg.Text = "<";
            this.btnBeforeImg.UseVisualStyleBackColor = true;
            this.btnBeforeImg.Click += new System.EventHandler(this.btnBeforeImg_Click);
            // 
            // btnNextImg
            // 
            this.btnNextImg.Location = new System.Drawing.Point(672, 686);
            this.btnNextImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNextImg.Name = "btnNextImg";
            this.btnNextImg.Size = new System.Drawing.Size(44, 52);
            this.btnNextImg.TabIndex = 43;
            this.btnNextImg.Text = ">";
            this.btnNextImg.UseVisualStyleBackColor = true;
            this.btnNextImg.Click += new System.EventHandler(this.btnNextImg_Click);
            // 
            // pbImgAgregar
            // 
            this.pbImgAgregar.Image = ((System.Drawing.Image)(resources.GetObject("pbImgAgregar.Image")));
            this.pbImgAgregar.Location = new System.Drawing.Point(202, 577);
            this.pbImgAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImgAgregar.Name = "pbImgAgregar";
            this.pbImgAgregar.Size = new System.Drawing.Size(460, 260);
            this.pbImgAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImgAgregar.TabIndex = 42;
            this.pbImgAgregar.TabStop = false;
            // 
            // txtUrlImg
            // 
            this.txtUrlImg.Location = new System.Drawing.Point(250, 512);
            this.txtUrlImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrlImg.Name = "txtUrlImg";
            this.txtUrlImg.Size = new System.Drawing.Size(360, 26);
            this.txtUrlImg.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "URL DE IMAGEN";
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 962);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrlImg);
            this.Controls.Add(this.btnEliminarImg);
            this.Controls.Add(this.btnBeforeImg);
            this.Controls.Add(this.btnNextImg);
            this.Controls.Add(this.pbImgAgregar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubirImgAgregarArt);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.MaximumSize = new System.Drawing.Size(822, 1024);
            this.MinimumSize = new System.Drawing.Size(822, 1018);
            this.Name = "AltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnSubirImgAgregarArt;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarImg;
        private System.Windows.Forms.Button btnBeforeImg;
        private System.Windows.Forms.Button btnNextImg;
        private System.Windows.Forms.PictureBox pbImgAgregar;
        private System.Windows.Forms.TextBox txtUrlImg;
        private System.Windows.Forms.Label label2;
    }
}