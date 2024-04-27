using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio {
    public class ArticuloNegocio {
        private AccesoDatos accesoDatos = new AccesoDatos();
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            try
            {
                accesoDatos.setearConsulta(
                    "SELECT  Codigo, Nombre, A.Descripcion, C.Descripcion, Precio, A.Id AS IdArt " +
                    "FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id"
                );
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                   
                    //articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.Codigo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    articulo.Precio = accesoDatos.Lector.GetDecimal(4);
                    //articulo.Marca = new Marca();
                    //articulo.Marca.Descripcion = (string)accesoDatos.Lector["IdMarca"];
                    listaArticulos.Add(articulo);
                }
                return listaArticulos;
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
        public void agregar(Articulo articulo)
        {
            try
            {
                accesoDatos.setearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdCategoria, Precio) " +
                    "VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Precio)"
                );
                accesoDatos.setearParametros("@Codigo", articulo.Codigo);
                accesoDatos.setearParametros("@Nombre", articulo.Nombre);
                accesoDatos.setearParametros("@Descripcion", articulo.Descripcion);
                accesoDatos.setearParametros("@IdCategoria", articulo.Categoria.ID);
                accesoDatos.setearParametros("@Precio", articulo.Precio);
                accesoDatos.ejecutarAccion();
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
        public Articulo buscar(string codigo)
        {
            Articulo articulo = new Articulo();
            try
            {
                accesoDatos.setearConsulta(
                    "SELECT Codigo, Nombre, Descripcion, IdCategoria, Precio FROM ARTICULOS " +
                    "WHERE Codigo = '" + codigo + "'"
                );
                accesoDatos.ejecutarAccion();
                while(accesoDatos.Lector.Read()) {
                    //articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.Codigo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.ID = (int)accesoDatos.Lector["IdCategoria"];
                    articulo.Categoria.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    articulo.Precio = accesoDatos.Lector.GetDecimal(4);
                    //articulo.Marca = new Marca();
                    //articulo.Marca.Descripcion = (string)accesoDatos.Lector["IdMarca"];
                }
                return articulo;
            } catch (Exception exception)
            {
                throw exception;
            } finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
