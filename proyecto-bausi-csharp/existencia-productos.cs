using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace proyecto_bausi_csharp
{
    public partial class existencia_productos : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=proyecto_bausi; Uid=root; pwd=");

        public static string talla = "";
        public static string cantidad = "";
        public static string id = "";
        public static string nombre_producto = "";


        public existencia_productos()
        {
            InitializeComponent();
        }
        private void mostrardt()
        {
            conexion.Open();
            String query = "SELECT id_producto " +
                "'ID DEL PRODUCTO:',P.nombre 'NOMBRE DEL PRODUCTO:',talla 'TALLAS:',existencia 'CANTIDAD DISPONIBLE:'  " +
                "FROM existencia_productos INNER JOIN productos P ON" +
                " existencia_productos.id_producto = P.id";
             MySqlCommand cmd = new MySqlCommand(query, conexion);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid.DataSource = dt;
            conexion.Close();

        }

        private void existencia_productos_Load(object sender, EventArgs e)
        {
            mostrardt();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conexion.Open();
           // string tallaa = txt_talla_para_surtir.Text.ToUpper();
            

            if (txt_cantidad_para_surtir.Text == "")
            {


                const string a = "¡INGRESA EL ID PARA CONTINUAR!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                const string message =
                     "¿Esta seguro de surtir este producto?";
                const string caption = "BAUSI";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);



                if (result == DialogResult.No)
                {

                    label_talla.Text = "";
                   // txt_id_para_surtir.Text = "";
                    label_id.Text = "";
                }
                else if (result == DialogResult.Yes)
                {
                    try
                    {

                        

                        int id = int.Parse(label_id.Text);
                        string talla = label_talla.Text.ToUpper();
                        int cantidad = int.Parse(txt_cantidad_para_surtir.Text);

                        string sentencia = "UPDATE existencia_productos SET existencia=existencia+" + cantidad + " " +
                            "WHERE id_producto=" + id + " AND talla='" + talla + "'";
                        MySqlCommand cmd2 = new MySqlCommand(sentencia, conexion);
                        cmd2.ExecuteNonQuery();

                        const string m = "¡SURTIDO CORRECTO!";
                        const string c = "BAUSI";
                        MessageBox.Show(m, c);
                        label_talla.Text = "aqui veras la talla";
                        label_id.Text = "selecciona el id";
                        txt_cantidad_para_surtir.Text = "";


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }






            }

            conexion.Close();
            mostrardt();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            index i = new index();
            i.Visible = true;
            Visible = false;
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = datagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            nombre_producto= datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            talla = datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
             cantidad = datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
             
            
            txt_cantidad_para_surtir.Text = cantidad;
            label_id.Text = id;
            label_talla.Text = talla;
            lbl_nombre.Text = nombre_producto;


        }

        private void txt_cantidad_para_surtir_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_cantidad_para_surtir_TextChanged(object sender, EventArgs e)
        {
            txt_cantidad_para_surtir.MaxLength = 9;
        }
    }
}
