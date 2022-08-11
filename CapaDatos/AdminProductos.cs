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
            string query = $"INSERT INTO Productos VALUES ('{producto.Codigo}','{producto.Descripcion}',{producto.Stock})";
            int rows;

            try
            {
                AbrirConn();
                
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
                Console.WriteLine("try guardar adminprod " + e);
                return false;
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
            }
        }
        public bool ModificarStock_D(string codigo, int cant)
        {
            

            DataSet resp = Listado_D(codigo);
            int auxCant;

            if (resp == null)
                return false;

            auxCant = int.Parse(resp.Tables[0].Rows[0]["Stock"].ToString()) + (cant);


            string query = $"UPDATE Productos SET Stock={auxCant} WHERE Codigo='{codigo}'";
            int rows;
            
            try
            {

                AbrirConn();
                cmd = new SqlCommand(query, conexion);

                rows = cmd.ExecuteNonQuery();

                if (rows < 1)
                {
                    throw new Exception("No se completo la modificacion");
                }
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        public DataSet Listado_D(string codigo = null)
        {
            string query;

            if (codigo==null)
                query = "SELECT * FROM Productos";   
            else 
                query = $"SELECT * FROM Productos WHERE Codigo= '{codigo}' ";
            

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
            catch (Exception )
            {

                throw new Exception("No se pudo realizar la busqueda" );
            }
            finally
            {
                CerrarConn();
                cmd.Dispose();
                
            }
        }

        #endregion
    }
}
