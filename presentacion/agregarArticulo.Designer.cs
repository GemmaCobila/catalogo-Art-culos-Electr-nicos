
namespace presentacion
{
    partial class frmagregarArticulo
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
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.txbDescripcion = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.urlImagen = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxAgregarPokemon = new System.Windows.Forms.PictureBox();
            this.lblAsterisco1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAsteriscoCategoria = new System.Windows.Forms.Label();
            this.lblAsteriscoMarca = new System.Windows.Forms.Label();
            this.lblAsteriscoPrecio = new System.Windows.Forms.Label();
            this.lblAsteriscoNombre = new System.Windows.Forms.Label();
            this.lblCampoObligatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(99, 35);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(181, 20);
            this.txbCodigo.TabIndex = 0;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(99, 68);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(181, 20);
            this.txbNombre.TabIndex = 1;
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(99, 168);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(181, 20);
            this.txbUrl.TabIndex = 3;
            this.txbUrl.Leave += new System.EventHandler(this.txbUrl_Leave);
            // 
            // txbDescripcion
            // 
            this.txbDescripcion.Location = new System.Drawing.Point(99, 101);
            this.txbDescripcion.Multiline = true;
            this.txbDescripcion.Name = "txbDescripcion";
            this.txbDescripcion.Size = new System.Drawing.Size(181, 54);
            this.txbDescripcion.TabIndex = 2;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(99, 201);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(181, 20);
            this.txbPrecio.TabIndex = 4;
            this.txbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecio_KeyPress);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(52, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(48, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // urlImagen
            // 
            this.urlImagen.AutoSize = true;
            this.urlImagen.Location = new System.Drawing.Point(34, 171);
            this.urlImagen.Name = "urlImagen";
            this.urlImagen.Size = new System.Drawing.Size(58, 13);
            this.urlImagen.TabIndex = 11;
            this.urlImagen.Text = "Url Imagen";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(32, 120);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(60, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "Descipción";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(55, 204);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(99, 234);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(181, 21);
            this.cbxMarca.TabIndex = 13;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(55, 238);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 14;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(40, 272);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 16;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(99, 268);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(181, 21);
            this.cbxCategoria.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(185, 311);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 34);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(298, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 34);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxAgregarPokemon
            // 
            this.pbxAgregarPokemon.Location = new System.Drawing.Point(302, 35);
            this.pbxAgregarPokemon.Name = "pbxAgregarPokemon";
            this.pbxAgregarPokemon.Size = new System.Drawing.Size(254, 250);
            this.pbxAgregarPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAgregarPokemon.TabIndex = 19;
            this.pbxAgregarPokemon.TabStop = false;
            // 
            // lblAsterisco1
            // 
            this.lblAsterisco1.AutoSize = true;
            this.lblAsterisco1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterisco1.Location = new System.Drawing.Point(43, 37);
            this.lblAsterisco1.Name = "lblAsterisco1";
            this.lblAsterisco1.Size = new System.Drawing.Size(14, 18);
            this.lblAsterisco1.TabIndex = 20;
            this.lblAsterisco1.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 21;
            // 
            // lblAsteriscoCategoria
            // 
            this.lblAsteriscoCategoria.AutoSize = true;
            this.lblAsteriscoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoCategoria.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoCategoria.Location = new System.Drawing.Point(30, 271);
            this.lblAsteriscoCategoria.Name = "lblAsteriscoCategoria";
            this.lblAsteriscoCategoria.Size = new System.Drawing.Size(14, 18);
            this.lblAsteriscoCategoria.TabIndex = 23;
            this.lblAsteriscoCategoria.Text = "*";
            // 
            // lblAsteriscoMarca
            // 
            this.lblAsteriscoMarca.AutoSize = true;
            this.lblAsteriscoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoMarca.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoMarca.Location = new System.Drawing.Point(46, 238);
            this.lblAsteriscoMarca.Name = "lblAsteriscoMarca";
            this.lblAsteriscoMarca.Size = new System.Drawing.Size(14, 18);
            this.lblAsteriscoMarca.TabIndex = 24;
            this.lblAsteriscoMarca.Text = "*";
            // 
            // lblAsteriscoPrecio
            // 
            this.lblAsteriscoPrecio.AutoSize = true;
            this.lblAsteriscoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoPrecio.Location = new System.Drawing.Point(46, 203);
            this.lblAsteriscoPrecio.Name = "lblAsteriscoPrecio";
            this.lblAsteriscoPrecio.Size = new System.Drawing.Size(14, 18);
            this.lblAsteriscoPrecio.TabIndex = 25;
            this.lblAsteriscoPrecio.Text = "*";
            // 
            // lblAsteriscoNombre
            // 
            this.lblAsteriscoNombre.AutoSize = true;
            this.lblAsteriscoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoNombre.ForeColor = System.Drawing.Color.Red;
            this.lblAsteriscoNombre.Location = new System.Drawing.Point(39, 70);
            this.lblAsteriscoNombre.Name = "lblAsteriscoNombre";
            this.lblAsteriscoNombre.Size = new System.Drawing.Size(14, 18);
            this.lblAsteriscoNombre.TabIndex = 26;
            this.lblAsteriscoNombre.Text = "*";
            // 
            // lblCampoObligatorio
            // 
            this.lblCampoObligatorio.AutoSize = true;
            this.lblCampoObligatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampoObligatorio.ForeColor = System.Drawing.Color.Red;
            this.lblCampoObligatorio.Location = new System.Drawing.Point(12, 365);
            this.lblCampoObligatorio.Name = "lblCampoObligatorio";
            this.lblCampoObligatorio.Size = new System.Drawing.Size(105, 13);
            this.lblCampoObligatorio.TabIndex = 27;
            this.lblCampoObligatorio.Text = "*Campos obligatorios";
            // 
            // frmagregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 387);
            this.Controls.Add(this.lblCampoObligatorio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAsteriscoNombre);
            this.Controls.Add(this.lblAsteriscoPrecio);
            this.Controls.Add(this.lblAsteriscoMarca);
            this.Controls.Add(this.lblAsteriscoCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.lblAsterisco1);
            this.Controls.Add(this.pbxAgregarPokemon);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.urlImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.txbDescripcion);
            this.Controls.Add(this.txbNombre);
            this.Name = "frmagregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.frmagregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.TextBox txbDescripcion;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label urlImagen;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxAgregarPokemon;
        private System.Windows.Forms.Label lblAsterisco1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAsteriscoCategoria;
        private System.Windows.Forms.Label lblAsteriscoMarca;
        private System.Windows.Forms.Label lblAsteriscoPrecio;
        private System.Windows.Forms.Label lblAsteriscoNombre;
        private System.Windows.Forms.Label lblCampoObligatorio;
    }
}