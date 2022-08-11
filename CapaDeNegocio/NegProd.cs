using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;
using System.Data;

namespace CapaDeNegocio
{
    public class NegProd
    {
        AdminProductos Prod_Datos = new AdminProductos();
        public bool AgregarProd_N(producto producto)
            => Prod_Datos.AgregarProd_D(producto);

        public bool ModificarStock_N(string codigo, int cantidad) 
            => Prod_Datos.ModificarStock_D(codigo,cantidad);

        public DataSet Listado_N(string codigo=null)
            => Prod_Datos.Listado_D(codigo);
        
    }
}
