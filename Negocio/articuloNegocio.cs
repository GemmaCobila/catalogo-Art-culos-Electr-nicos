using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Negocio
{
    public class articuloNegocio
    {
        public List <Articulo> listaBase()
        {
            List<Articulo> lista = new List<Articulo>();
            accesoDatos datos = new accesoDatos();

            try
            {
                datos.setearConsulta("select a.Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Dispositivo, Precio, ImagenUrl, IdCategoria, IdMarca, A.Id from ARTICULOS A, MARCAS M , CATEGORIAS C where m.Id = a.IdMarca and c.Id = a.IdCategoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Id = (int)datos.Lector["Id"];

                    aux.Marca = new marcas();
                    aux.Marca.id = (int)datos.Lector["IdMarca"];
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["Dispositivo"];                    

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    lista.Add(aux);
                }
                datos.cerrarConexion();
                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }


        public void modificar(Articulo nuevo)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, ImagenUrl = @imagenUrl, Precio = @precio, IdMarca = @idMarca, IdCategoria = @idCategoria where id = @id");
                datos.setearParametro("@codigo", nuevo.Codigo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@precio", nuevo.Precio);
                datos.setearParametro("@idMarca", nuevo.Marca.id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@id", nuevo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar (Articulo nuevo)
        {
            accesoDatos datos = new accesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria) values ('" +nuevo.Codigo+"', '"+nuevo.Nombre+"', '"+nuevo.Descripcion+"', '"+nuevo.ImagenUrl+"', "+ "@Precio, @IdMarca, @IdCategoria)");
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdMarca", nuevo.Marca.id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar (int id)
        {
            try
            {
                accesoDatos datos = new accesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametro("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Articulo> filtrar(string buscarPor, string criterio, string filtroTexto)
        {
            List<Articulo> listaAr = new List<Articulo>();
            accesoDatos datos = new accesoDatos();
            try
            {
                string consulta = "select a.Codigo, Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Dispositivo, Precio, ImagenUrl, IdCategoria, IdMarca, A.Id from ARTICULOS A, MARCAS M , CATEGORIAS C where m.Id = a.IdMarca and c.Id = a.IdCategoria and ";

                if (buscarPor == "Precio")
                {
                    switch (criterio)
                    {
                        case "Precio mayor a:":
                            consulta += " Precio >" + filtroTexto;
                            break;
                        default:
                            consulta += " Precio <" + filtroTexto;
                            break;
                    }
                } else if (buscarPor == "Nombre")
                {
                    switch (criterio)
                    {
                        case "que empiece con:":
                            consulta += "Nombre like '"+filtroTexto+"%'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtroTexto + "%'";
                            break;
                    }
                } else if (buscarPor == "Marca")
                    consulta += "m.Descripcion = '" + criterio+"'";

                  else if (buscarPor == "Tipo")
                    consulta += "c.Descripcion = '" + criterio + "'";

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Id = (int)datos.Lector["Id"];

                    aux.Marca = new marcas();
                    aux.Marca.id = (int)datos.Lector["IdMarca"];
                    aux.Marca.descripcion = (string)datos.Lector["Marca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.descripcion = (string)datos.Lector["Dispositivo"];

                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    listaAr.Add(aux);
                }
                return listaAr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
