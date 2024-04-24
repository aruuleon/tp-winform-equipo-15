using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos accesoCategoria = new AccesoDatos();    

            try
            {
                accesoCategoria.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                accesoCategoria.ejecutarLectura();

                while (accesoCategoria.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.ID = (int)accesoCategoria.Lector["Id"];
                    aux.Descripcion = (string)accesoCategoria.Lector["Descripcion"];

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
                accesoCategoria.cerrarConexion();
            }
           
            

        }
    }
}
