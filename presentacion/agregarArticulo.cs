using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace presentacion
{
    public partial class frmagregarArticulo : Form
    {
        private Articulo arti = null;
        public frmagregarArticulo()
        {
            InitializeComponent();
        }

        public frmagregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.arti = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();

            if (arti == null)
                arti = new Articulo();             
            try
              {
                if (txbCodigo.Text == "" || txbNombre.Text == "" || txbPrecio.Text == "")
                {
                    MessageBox.Show("Complete los campos obligatorios");
                }
                
                else
                {
                    arti.Codigo = txbCodigo.Text;
                    arti.Nombre = txbNombre.Text;
                    arti.Descripcion = txbDescripcion.Text;
                    arti.ImagenUrl = txbUrl.Text;

                    if (txbPrecio.Text == ",")
                        arti.Precio = decimal.Parse("0,0");
                    else 
                        arti.Precio = decimal.Parse(txbPrecio.Text);

                    arti.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    arti.Marca = (marcas)cbxMarca.SelectedItem;

                    if (arti.Id != 0)
                    {
                        negocio.modificar(arti);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        negocio.agregar(arti);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    Close();
                }             
              }
              catch (Exception ex)
              {
                MessageBox.Show(ex.ToString());
              }         
        }

        private void frmagregarArticulo_Load(object sender, EventArgs e)
        {
            categoriaNegocio categoriaNegocio = new categoriaNegocio();
            marcaNegocio marcaNegocio = new marcaNegocio();


            try
            {
                cbxCategoria.DataSource = categoriaNegocio.listaCat();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                cbxMarca.DataSource = marcaNegocio.listaMarca();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
             
                if (arti != null)
                {
                    txbCodigo.Text = arti.Codigo;
                    txbNombre.Text = arti.Nombre;
                    txbDescripcion.Text = arti.Descripcion;
                    txbPrecio.Text = arti.Precio.ToString();
                    txbUrl.Text = arti.ImagenUrl;

                    cargarImagen(arti.ImagenUrl);

                    cbxMarca.SelectedValue = arti.Marca.id;
                    cbxCategoria.SelectedValue = arti.Categoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAgregarPokemon.Load(imagen);
            }
            catch (Exception)
            {
                pbxAgregarPokemon.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void txbUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrl.Text);
        }

        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        
    }
}
