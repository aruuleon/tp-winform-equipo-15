using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ImagenNegocio
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
        public void agregar(List<string> img, int id)
        {

            try
            {
                foreach (string item in img)
                {
                    AccesoDatos datos = new AccesoDatos();
                    datos.setearConsulta("INSERT INTO IMAGENES VALUES (@IdArt,'" + item + "')");
                    datos.setearParametros("@IdArt", id);
                    datos.ejecutarAccion();
                    datos.cerrarConexion();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

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
