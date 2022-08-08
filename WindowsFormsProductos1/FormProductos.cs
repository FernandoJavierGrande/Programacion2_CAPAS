using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsProductos1
{
    public partial class FormProductos : Form
    {
        Guardados gestionar = new Guardados();
        producto nuevoProducto, prod_a_cargar;
        public FormProductos()
        {
            InitializeComponent();
            dgv.AllowUserToAddRows = false;


            dgv.DataSource = gestionar.DT;
            dgv.ReadOnly = true;
            dgv.Columns[0].Width = 70;
            dgv.Columns[1].Width = 120;
            dgv.Columns[2].Width = 50;
        }
        #region botones
        private void button1_Click(object sender, EventArgs e)
        {
            int stock = 0;
            int cod;
            
            try
            {
                cod = int.Parse(txt_codigo.Text.Trim());
                nuevoProducto = new producto(cod, txt_desc.Text.Trim());
                lbl_codMov.Text = nuevoProducto.Codigo.ToString();
                lbl_descMov.Text = nuevoProducto.Descripcion.ToString();
                if (txt_stock.Text!="")
                {
                    stock = int.Parse(txt_stock.Text.ToString().Trim());
                }
                

                nuevoProducto.Ingreso(stock);

                lbl_stockMov.Text = "Hay " + nuevoProducto.Stock.ToString() + " unidades ";

                gestionar.agregar_Producto(nuevoProducto);
                    
                ////MessageBox.Show("Producto Instanciado");


            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error.\nIntente nuevamente","ERROR AL CARGAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void Boton_aceptar_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            try
            {
                cantidad = int.Parse(txt_cant.Text.Trim());

                if (rad_ingreso.Checked)
                {
                    nuevoProducto.Ingreso(cantidad);
                    Console.WriteLine("canti" + cantidad);
                }
                else
                {
                    nuevoProducto.salida(cantidad);
                }

                try
                {
                    gestionar.modificar_Stock(nuevoProducto);
                }
                catch (Exception)
                {
                    Console.WriteLine("erroro segundo try");
                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("erroro primer try");

            }
            

        }



        #endregion

        #region dgv
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Guardados modificar = new Guardados();
            string aux_cod, aux_desc, aux_stock;


            aux_cod = dgv.CurrentRow.Cells[0].Value.ToString();
            aux_desc = dgv.CurrentRow.Cells[1].Value.ToString();
            aux_stock = dgv.CurrentRow.Cells[2].Value.ToString();

            nuevoProducto = new producto(int.Parse(aux_cod), aux_desc);  //creo una nueva instancia de prod y stock inicial cero
            nuevoProducto.Ingreso(int.Parse(aux_stock)); // ingreso el stock existente desde la tabla ya que no puedo hacer directo el set

            lbl_codMov.Text = aux_cod;
            lbl_descMov.Text = aux_desc;
            lbl_stockMov.Text = aux_stock;


            
        }
        #endregion
    }
}
