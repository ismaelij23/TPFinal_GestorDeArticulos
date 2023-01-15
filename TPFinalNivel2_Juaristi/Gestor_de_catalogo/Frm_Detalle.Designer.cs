namespace Gestor_de_catalogo
{
    partial class Frm_Detalle
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
            this.txtCodigo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.picBoxImg = new System.Windows.Forms.PictureBox();
            this.lblCodigoHijo = new System.Windows.Forms.Label();
            this.lblNombreHijo = new System.Windows.Forms.Label();
            this.lblDescripcionHijo = new System.Windows.Forms.Label();
            this.lblPrecioHijo = new System.Windows.Forms.Label();
            this.grBoxArticulo = new System.Windows.Forms.GroupBox();
            this.lblMarcaHijo = new System.Windows.Forms.Label();
            this.lblCategoriaHijo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).BeginInit();
            this.grBoxArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.Chocolate;
            this.txtCodigo.Location = new System.Drawing.Point(278, 71);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "CÓDIGO";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Chocolate;
            this.txtNombre.Location = new System.Drawing.Point(282, 155);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(85, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "NOMBRE";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.Chocolate;
            this.txtDescripcion.Location = new System.Drawing.Point(282, 233);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(131, 20);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "DESCRIPCIÓN";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.Color.Chocolate;
            this.txtPrecio.Location = new System.Drawing.Point(490, 233);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.Text = "PRECIO";
            // 
            // picBoxImg
            // 
            this.picBoxImg.Location = new System.Drawing.Point(6, 28);
            this.picBoxImg.Name = "picBoxImg";
            this.picBoxImg.Size = new System.Drawing.Size(239, 316);
            this.picBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImg.TabIndex = 4;
            this.picBoxImg.TabStop = false;
            // 
            // lblCodigoHijo
            // 
            this.lblCodigoHijo.AutoSize = true;
            this.lblCodigoHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoHijo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblCodigoHijo.Location = new System.Drawing.Point(286, 116);
            this.lblCodigoHijo.Name = "lblCodigoHijo";
            this.lblCodigoHijo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoHijo.TabIndex = 5;
            this.lblCodigoHijo.Text = "Código";
            // 
            // lblNombreHijo
            // 
            this.lblNombreHijo.AutoSize = true;
            this.lblNombreHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHijo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblNombreHijo.Location = new System.Drawing.Point(289, 197);
            this.lblNombreHijo.Name = "lblNombreHijo";
            this.lblNombreHijo.Size = new System.Drawing.Size(56, 16);
            this.lblNombreHijo.TabIndex = 6;
            this.lblNombreHijo.Text = "Nombre";
            // 
            // lblDescripcionHijo
            // 
            this.lblDescripcionHijo.AutoSize = true;
            this.lblDescripcionHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionHijo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblDescripcionHijo.Location = new System.Drawing.Point(288, 277);
            this.lblDescripcionHijo.Name = "lblDescripcionHijo";
            this.lblDescripcionHijo.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionHijo.TabIndex = 7;
            this.lblDescripcionHijo.Text = "Descripción";
            // 
            // lblPrecioHijo
            // 
            this.lblPrecioHijo.AutoSize = true;
            this.lblPrecioHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioHijo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblPrecioHijo.Location = new System.Drawing.Point(497, 270);
            this.lblPrecioHijo.Name = "lblPrecioHijo";
            this.lblPrecioHijo.Size = new System.Drawing.Size(46, 16);
            this.lblPrecioHijo.TabIndex = 8;
            this.lblPrecioHijo.Text = "Precio";
            // 
            // grBoxArticulo
            // 
            this.grBoxArticulo.Controls.Add(this.lblMarcaHijo);
            this.grBoxArticulo.Controls.Add(this.lblCategoriaHijo);
            this.grBoxArticulo.Controls.Add(this.lblMarca);
            this.grBoxArticulo.Controls.Add(this.lblCategoria);
            this.grBoxArticulo.Controls.Add(this.picBoxImg);
            this.grBoxArticulo.Controls.Add(this.lblPrecioHijo);
            this.grBoxArticulo.Controls.Add(this.txtCodigo);
            this.grBoxArticulo.Controls.Add(this.lblDescripcionHijo);
            this.grBoxArticulo.Controls.Add(this.txtNombre);
            this.grBoxArticulo.Controls.Add(this.lblNombreHijo);
            this.grBoxArticulo.Controls.Add(this.txtDescripcion);
            this.grBoxArticulo.Controls.Add(this.lblCodigoHijo);
            this.grBoxArticulo.Controls.Add(this.txtPrecio);
            this.grBoxArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxArticulo.ForeColor = System.Drawing.Color.Chocolate;
            this.grBoxArticulo.Location = new System.Drawing.Point(12, 12);
            this.grBoxArticulo.MaximumSize = new System.Drawing.Size(617, 359);
            this.grBoxArticulo.MinimumSize = new System.Drawing.Size(617, 359);
            this.grBoxArticulo.Name = "grBoxArticulo";
            this.grBoxArticulo.Size = new System.Drawing.Size(617, 359);
            this.grBoxArticulo.TabIndex = 9;
            this.grBoxArticulo.TabStop = false;
            this.grBoxArticulo.Text = "Detalles del artículo";
            // 
            // lblMarcaHijo
            // 
            this.lblMarcaHijo.AutoSize = true;
            this.lblMarcaHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaHijo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblMarcaHijo.Location = new System.Drawing.Point(506, 197);
            this.lblMarcaHijo.Name = "lblMarcaHijo";
            this.lblMarcaHijo.Size = new System.Drawing.Size(45, 16);
            this.lblMarcaHijo.TabIndex = 12;
            this.lblMarcaHijo.Text = "Marca";
            // 
            // lblCategoriaHijo
            // 
            this.lblCategoriaHijo.AutoSize = true;
            this.lblCategoriaHijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaHijo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblCategoriaHijo.Location = new System.Drawing.Point(506, 116);
            this.lblCategoriaHijo.Name = "lblCategoriaHijo";
            this.lblCategoriaHijo.Size = new System.Drawing.Size(66, 16);
            this.lblCategoriaHijo.TabIndex = 11;
            this.lblCategoriaHijo.Text = "Categoría";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Chocolate;
            this.lblMarca.Location = new System.Drawing.Point(494, 155);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(72, 20);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "MARCA";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Chocolate;
            this.lblCategoria.Location = new System.Drawing.Point(475, 68);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(113, 20);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "CATEGORÍA";
            // 
            // Frm_Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(649, 375);
            this.Controls.Add(this.grBoxArticulo);
            this.Name = "Frm_Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.Frm_Detalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).EndInit();
            this.grBoxArticulo.ResumeLayout(false);
            this.grBoxArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.PictureBox picBoxImg;
        private System.Windows.Forms.Label lblCodigoHijo;
        private System.Windows.Forms.Label lblNombreHijo;
        private System.Windows.Forms.Label lblDescripcionHijo;
        private System.Windows.Forms.Label lblPrecioHijo;
        private System.Windows.Forms.GroupBox grBoxArticulo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarcaHijo;
        private System.Windows.Forms.Label lblCategoriaHijo;
    }
}