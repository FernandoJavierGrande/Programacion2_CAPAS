using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guardados 
    {
        public DataTable DT { get; set; } = new DataTable();

        #region Constructores
        public Guardados()
        {
            DT.TableName = "Productos cargados";

            DT.Columns.Add("Codigo");
            DT.Columns.Add("Descripcion");
            DT.Columns.Add("Stock");
        }
        #endregion

        #region metodos

        public DataTable agregar_Producto(producto nuevoProd)
        {
            DT.Rows.Add();
            int fila = DT.Rows.Count-1;

            DT.Rows[fila]["Codigo"] = nuevoProd.Codigo.ToString().Trim();
            DT.Rows[fila]["Descripcion"] = nuevoProd.Descripcion;
            DT.Rows[fila]["Stock"] = nuevoProd.Stock.ToString().Trim(); 


            return DT;
        }
        public void modificar_Stock(producto prod)
        {
            try
            {
                for (int fila = 0; fila < DT.Rows.Count; fila++)
                {
                    if (DT.Rows[fila]["Codigo"].Equals(prod.Codigo))
                    {
                        
                        DT.Rows[fila]["Stock"] = prod.Stock;
                        
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine(" error al modificar");

            }
            
        }

        #endregion


    }
}
