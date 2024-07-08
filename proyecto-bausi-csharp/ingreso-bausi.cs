using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_bausi_csharp
{
    public partial class ingreso_bausi : Form
    {

        public ingreso_bausi()
        {
            InitializeComponent();
        }
        
        private void btn_ingreso_Click(object sender, EventArgs e)
        {
           // txt_id.Text = "";

            
           /* txt_id.PasswordChar = '•';
            txt_id.MaxLength = 14;*/
            
            if (txt_id.Text == "")
            {
                const string a = "¡INGRESA EL CODIGO!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_id.Text!= "23")
            {
                const string a = "¡CODIGO INCORRECTO!";
                const string oe = "BAUSI";
                MessageBox.Show(a, oe, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_id.Text = "";


            } else
            {

                index i = new index();
                i.Visible = true;
                Visible = false;


            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            txt_id.PasswordChar = '•';
            txt_id.MaxLength = 14;
        }

        private void ingreso_bausi_Load(object sender, EventArgs e)
        {

        }
    }
}
