using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class producto
    {
        #region atributos
        private string codigo;
        private string descripcion;
        private int stock;
        #endregion


        #region prop

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Stock { get { return stock; } }

        #endregion

        #region const
        public producto()
        {
        }

        public producto(string codigo, string descripcion, int stock =0)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.stock = stock;
        }

        
        #endregion

        #region metodos
        public void Ingreso( int cant)
        {
            stock += cant;
        }
        public void salida(int cant)
        {
            stock -= cant;
        }
        #endregion
    }
}//7 min 21

