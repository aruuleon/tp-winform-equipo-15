using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;



        public SqlDataReader Lector { get; set; }

        public AccesoDatos()
        {
            conexion = new SqlConnection(".\\SQLEXPRESS; database=CATALOGO_DB_v3; integrated security=true");
            comando = new SqlCommand();

        }
            public void setearConsulta(string consulta)
                {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            { 
                conexion.Open();
                lector = comando.ExecuteReader();
                Lector = lector;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cerrarConexion()
        {
            if (lector != null) 
                lector.Close();
            conexion.Close();
        }


    }
}
