using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyecto_bausi_csharp
{
    public partial class ventas : Form
    {

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=proyecto_bausi; Uid=root; pwd=");
        public static string id = "";
       // public static string sentencia = "";

        public ventas()
        {
            InitializeComponent();
            mostrardt_venta();
        }
        private void mostrardt_venta()
        {
            conexion.Open();
            String query = "SELECT C.id 'ID DE LA COMPRA:',ciudad_envio 'CIUDAD PARA EL ENVIO:'," +
                "C.direccion_envio 'DIRECCION PARA EL ENVIO:',cod_postal 'CODIGO POSTAL:'," +
                " C.nombres_completo_cliente 'NOMBRE COMPLETO:', C.telefono_cliente 'TELEFONO DEL CLIENTE:'," +
                " C.correo_cliente 'CORREO DEL CLIENTE:' from cliente_compra_producto C";
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid_venta.DataSource = dt;
            conexion.Close();

        }

        private void mostrardt_detalleventa()

        {
            conexion.Open();
            String sentencia = "select P.nombre 'NOMBRE DEL PRODUCTO:',P.descripcion 'DESCRIPCION DEL PRODUCTO:'," +
                "D.cantidad 'CANTIDAD:',D.talla 'TALLA:',D.precio_unitario 'PRECIO UNITARIO:'" +
                " from detalle_venta D INNER JOIN cliente_compra_producto C" +
                " ON D.id_venta=C.id AND d.id_venta="+id+" INNER JOIN productos P ON d.id_producto=p.id";
            MySqlCommand cmd = new MySqlCommand(sentencia, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid_detalle_venta.DataSource = dt;
            conexion.Close();
        }
        private void estado()
        {


            conexion.Open();
            String cmd = "SELECT estado FROM cliente_compra_producto WHERE id=" + id;
            
            MySqlCommand cm = new MySqlCommand(cmd, conexion);
            MySqlDataReader c = cm.ExecuteReader();

            if (c.Read())
            {
                label_estado.Text = c["estado"].ToString().ToUpper();
            }

            c.Close();

            conexion.Close();


          
        }
        private void buscar(String id)
        {
           // conexion.Open();
            int idd = int.Parse(id);
            String query = "SELECT C.id 'ID DE LA COMPRA:',ciudad_envio 'CIUDAD PARA EL ENVIO:'," +
                 "C.direccion_envio 'DIRECCION PARA EL ENVIO:',cod_postal 'CODIGO POSTAL:'," +
                 " C.nombres_completo_cliente 'NOMBRE COMPLETO:', C.telefono_cliente 'TELEFONO DEL CLIENTE:'," +
                 " C.correo_cliente 'CORREO DEL CLIENTE:' from cliente_compra_producto C WHERE id="+idd;
            MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid_venta.DataSource = dt;
           // conexion.Close();



        }
        public bool NoExiste(int id)
        {
           // conexion.Open();
            string sql = @"SELECT COUNT(*) FROM cliente_compra_producto WHERE id =" + id;


             

            MySqlCommand cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count == 0;

           //  conexion.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Visible = true;
            Visible = false;
        }

        private void datagrid_venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* // MessageBox.Show(datagrid_venta.CurrentCell.Value.ToString());
              string valorPrimerCelda = datagrid_venta.Rows[e.RowIndex].Cells[0].Value.ToString();
              MessageBox.Show(valorPrimerCelda);
              string valorCelda = datagrid_venta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
              MessageBox.Show(valorCelda);*/
            id = datagrid_venta.Rows[e.RowIndex].Cells[0].Value.ToString();
            mostrardt_detalleventa();
            estado();
            //  estado();
        }

        private void ventas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            txt_buscar.Text = "";
            label_estado.Text = "aqui veras el estado";
            mostrardt_venta();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            if (txt_buscar.Text == "")
            {
                
                const string a = "¡AGREGA EL ID PARA BUSCAR!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);

            } else if (NoExiste(int.Parse(txt_buscar.Text)) == true)
            {
                const string a = "¡EL ID INGRESADO NO SE ENCUENTRA EN LA BASE DE DATOS!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe);

            } else
            {
                buscar(txt_buscar.Text);
            }
            conexion.Close();
            txt_buscar.Text = "";
            label_estado.Text = "aqui veras el estado";
            

        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }


            }
            catch (Exception ex)
            {
                const string a = "¡INGRESA UN PRECIO valido!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            txt_buscar.MaxLength = 9;
        }
    }
}
