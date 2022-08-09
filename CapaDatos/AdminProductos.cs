using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using CapaDatos;

namespace CapaDatos
{
    public class AdminProductos : DatosConexion
    {
        SqlCommand cmd;

        #region crud
        public bool AgregarProd_D(producto producto)
        {
            string query = $"INSERT INTO Productos VALUES {producto.Codigo},{producto.Descripcion},{producto.Stock}";
            int rows;

            try
            {
                cmd = new SqlCommand(query, conexion);
                rows = cmd.ExecuteNonQuery();

                if (rows<1)
                {
                    throw new Exception($"No se pudo guardar el producto {producto.Codigo}");
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }
        public bool ModificarProd_D(producto producto)
        {
            string query = $"UPDATE Productos SET Descripcion={producto.Descripcion} WHERE Codigo={producto.Codigo}";
            int rows;
            
            try
            {
                cmd = new SqlCommand(query, conexion);
                rows = cmd.ExecuteNonQuery();

                if (rows < 1)
                {
                    throw new Exception("No se completo la modificacion");
                }
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        public DataSet Listado_D(string codigo = null)
        {
            string query;

            if (codigo==null)
            {
                query = "SELECT * FROM Productos";

            }
            else
            {
                query = $"SELECT * FROM Poductos WHERE Codigo= {codigo} ";
            }

            SqlCommand cmd = new SqlCommand(query,conexion);

            DataSet dataset = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            try
            {
                AbrirConn();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(dataset);

                return dataset;
            }
            catch (Exception)
            {

                throw new Exception("No se pudo realizar la busqueda");
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
                
            }
        }



        //public bool validarCodigo(string codigo)
        //{
        //    string query = $"SELECT [Codigo] FROM Productos WHERE Codigo = {codigo}";

        //    DataSet ds = new DataSet();
        //    SqlDataReader da = new SqlDataAdapt();
        //    try
        //    {
        //        AbrirConn();
        //        cmd.ex
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
        #endregion
    }
}
