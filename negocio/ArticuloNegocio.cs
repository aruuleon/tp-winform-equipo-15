using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio {
    public class ArticuloNegocio {
        public List <Articulo> listar() {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try {
                accesoDatos.setearConsulta("SELECT Codigo, Nombre, Descripcion FROM ARTICULOS");
                accesoDatos.ejecutarLectura();
                while(accesoDatos.Lector.Read()) {
                    Articulo articulo = new Articulo();
                    articulo.Codigo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    //articulo.Precio = (float)accesoDatos.Lector["Precio"];
                    //articulo.Marca = new Marca();
                    //articulo.Categoria = new Categoria();
                    //articulo.Marca.Descripcion = (string)accesoDatos.Lector["IdMarca"];
                    //articulo.Categoria.Descripcion = (string)accesoDatos.Lector["IdCategoria"];
                    listaArticulos.Add(articulo);
                }
                return listaArticulos;
            } catch (Exception exception) {
                throw exception;
            } finally {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
