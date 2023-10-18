using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class marcaNegocio
    {
        public List<marcas> listaMarca() 
        {
            List<marcas> lista = new List<marcas>();
            accesoDatos datos = new accesoDatos();

            try
            {
            datos.setearConsulta("select Id, Descripcion from MARCAS");
            datos.ejecutarLectura();

            while (datos.Lector.Read())
            {
                marcas aux = new marcas();
                aux.id = (int)datos.Lector["Id"];
                aux.descripcion = (string)datos.Lector["Descripcion"];
                lista.Add(aux);
            }
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


    }
}
