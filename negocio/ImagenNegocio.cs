using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    internal class ImagenNegocio
    {
        public List<Imagen> Imagenes(int id)
        {
            List<Imagen> listaimagenes = new List<Imagen>();
            AccesoDatos accesoDatos = new AccesoDatos();  

            try
            {
                accesoDatos.setearConsulta(
                    "SELECT Id, IdArticulo, ImagenUrl FROM IMAGENES"

                ); ;
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Imagen img = new Imagen();
                    img.ID = (int)accesoDatos.Lector["Id"]; 
                    img.IDArticulo = (int)accesoDatos.Lector["IdArticulo"]; 
                    img.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"]; 

                    listaimagenes.Add(img);
                }
                return listaimagenes;
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
         public void agregar(Imagen nueva)
         {
             AccesoDatos datos = new AccesoDatos();
             try
             {
                 datos.setearConsulta("INSERT INTO IMAGENES VALUES (" + nueva.IDArticulo + ", '" + nueva.ImagenUrl + "')");
                 datos.ejecutarAccion();
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
         /*public void modificar(Categoria nueva)
         {
             AccesoDatos datos = new AccesoDatos();
             try
             {
                 datos.setearConsulta("UPDATE IMAGENES SET Descripcion = '" + nueva.Descripcion + "' WHERE ID = " + nueva.ID);
                 datos.ejecutarAccion();
             }
             catch (Exception ex)
             {

                 throw ex;
             }
             finally
             {
                 datos.cerrarConexion();
             }
         }*/
         public void eliminar(int id)
         {
             AccesoDatos datos = new AccesoDatos();
             try
             {
                 datos.setearConsulta("DELETE IMAGENES WHERE Id =" + id);
                 datos.ejecutarAccion();
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
