using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;


namespace proyecto_bausi_csharp
{
    public partial class index : Form
    {

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=proyecto_bausi; Uid=root; pwd=");
        public index()
        {
            InitializeComponent();

            
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregar_descuento_Click(object sender, EventArgs e)
        {
            agregar_descuento i = new agregar_descuento();
            i.Visible = true;
            Visible = false;

        }

        private void btn_ver_existencia_productos_Click(object sender, EventArgs e)
        {
            existencia_productos i = new existencia_productos();
            i.Visible = true;
            Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ventas i = new ventas();
            i.Visible = true;
            Visible = false;
        }

        private void lbl_salir_Click(object sender, EventArgs e)
        {
            ingreso_bausi i = new ingreso_bausi();
            i.Visible = true;
            Visible = false;
        }

        private void btn_agregar_producto_Click(object sender, EventArgs e)
        {
            agregar_producto i = new agregar_producto();
             i.Visible = true;
             Visible = false;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminar_producto i = new eliminar_producto();
            i.Visible = true;
            Visible = false;


        }
    }
}
