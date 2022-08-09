using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DatosConexion
    {
        protected SqlConnection conexion;
        protected string cadenaConexion = "Server=DESKTOP-55OJM29; Database=Prod; Trusted_Connection=true;";

        public DatosConexion()
        {
            conexion = new SqlConnection(cadenaConexion);
        }

        #region metodos
        public void AbrirConn()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed) conexion.Open();
            }
            catch (Exception)
            {

                throw new Exception("Error al abrir la conexion");
            }
            
        }
            
        public void CerrarConn()
        {
            try
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
 
            }
            catch (Exception)
            {

                throw new Exception("Error al cerrar la conexion");
            }
        }
        #endregion
    }

} 
