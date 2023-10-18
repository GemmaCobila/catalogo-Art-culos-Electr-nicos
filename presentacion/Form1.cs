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
    public partial class Catalogo : Form
    {

        private List<Articulo> listaArticulo;

        public Catalogo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cbxBuscarPor.Items.Add("Precio");
            cbxBuscarPor.Items.Add("Nombre");
            cbxBuscarPor.Items.Add("Marca");
            cbxBuscarPor.Items.Add("Tipo");
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
      
        }

        private void cargarImagen (string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception)
            {
                pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void cargar()
        {
            articuloNegocio negocio = new articuloNegocio();

            try
            {
                listaArticulo = negocio.listaBase();
                dgvArticulos.DataSource = listaArticulo;

                pbxArticulo.Load(listaArticulo[0].ImagenUrl);

                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["IdMarca"].Visible = false;
                dgvArticulos.Columns["IdCategoria"].Visible = false;
                dgvArticulos.Columns["Codigo"].Width = 60;
                dgvArticulos.Columns["Marca"].Width = 70;
                dgvArticulos.Columns["Categoria"].Width = 70;
                dgvArticulos.Columns["Precio"].Width = 80;            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } 

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmagregarArticulo alta = new frmagregarArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            if(dgvArticulos.CurrentRow == null)
                MessageBox.Show("Debe tener seleccionado un item de la grilla para modificar");
            else
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmagregarArticulo modificar = new frmagregarArticulo(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();
            Articulo seleccionado;

            try
            {
                if (dgvArticulos.CurrentRow == null)
                    MessageBox.Show("Debe tener un item seleccionado ´de la grilla para eliminar");

                else
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar este articulo?", "eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                    if (respuesta==DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);

                        cargar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cbxBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxBuscarPor.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cboCriterio.DataSource = null;
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Precio mayor a:");
                cboCriterio.Items.Add("Precio menor a:");
                tbxBuscar.Visible = true;

            }

            else if (opcion == "Nombre")
            {
                cboCriterio.DataSource = null;
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("que contenga:");
                cboCriterio.Items.Add("que empiece con:");
                tbxBuscar.Visible = true;
            }


            else if (opcion == "Marca")
            {
                cboCriterio.DataSource = null;
                marcaNegocio negocio = new marcaNegocio();
                cboCriterio.DataSource = negocio.listaMarca();
                tbxBuscar.Visible = false;
            }
            else if (opcion == "Tipo")
            {
                cboCriterio.DataSource = null;
                categoriaNegocio negocio = new categoriaNegocio();
                cboCriterio.DataSource = negocio.listaCat();
                tbxBuscar.Visible = false;
            }
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private bool validarFiltro()
        {
            if (cbxBuscarPor.SelectedIndex<0)
            {
                MessageBox.Show("Seleccione una opcion en el menú 'Buscar por'");
                return true;
            }
            if (cboCriterio.SelectedIndex<0)
            {
                MessageBox.Show("Seleccione una opcion en el menu 'Criterio'");
                return true;
            }
            if (cbxBuscarPor.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(tbxBuscar.Text)))
                {
                    MessageBox.Show("solo ingresar numeros enteros en campo numerico");
                    return true;
                }
            }
            return false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            articuloNegocio negocio = new articuloNegocio();           

            try
            {
                if (validarFiltro())
                    return;
                
                else
                {                  
                    string buscarPor = cbxBuscarPor.SelectedItem.ToString();
                    string criterio = cboCriterio.SelectedItem.ToString();
                    string filtro = tbxBuscar.Text;
                    dgvArticulos.DataSource = negocio.filtrar(buscarPor, criterio, filtro);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void tbxBuscar_Enter(object sender, EventArgs e)
        {
            if (tbxBuscar.Text == "Escribir el criterio a buscar")
            {
                tbxBuscar.Text="";
                tbxBuscar.ForeColor = Color.Black;
            }
        }

        private void tbxBuscar_Leave(object sender, EventArgs e)
        {
            if (tbxBuscar.Text == "")
            {
                tbxBuscar.Text = "Escribir el criterio a buscar";
                tbxBuscar.ForeColor = Color.Gray;
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null)
                MessageBox.Show("Debe tener un item seleccionado de la grilla para mostrar la información");

            else
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                MessageBox.Show("Dispositivo: " +seleccionado.Nombre + " - codigo: " + seleccionado.Codigo + "\r\n" + "Descripcion: " + seleccionado.Descripcion + "\r\n" +"Marca: " + seleccionado.Marca + "\r\n" +"Categoria: " +seleccionado.Categoria + "\r\n" +"Precio: $" +seleccionado.Precio);
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
