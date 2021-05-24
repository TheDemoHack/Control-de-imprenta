using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpresosBernal.Crear
{
    public partial class Crear_Material : Form
    {
        public Crear_Material()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void rbtNuevo_CheckedChanged(object sender, EventArgs e)
        {
            cbxMaterial.Enabled = false;
            cbxTipo.Enabled = false;
            txtMaterial.Enabled = true;         //Habilitamos los controles correspondientes 
            txtTipo.Enabled = true;
        }

        private void rbtExistente_CheckedChanged(object sender, EventArgs e)
        {
            txtMaterial.Enabled = false;
            txtTipo.Enabled = false;
            cbxMaterial.Enabled = true;         //Habilitamos los controles correspondientes 
            cbxTipo.Enabled = true;
        }

        private void Crear_Material_Load(object sender, EventArgs e)
        {
            rbtExistente.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (ImpresosBernal.Login.tipoCompartido == "Jefe")
            {
                Form jefe = new ImpresosBernal.DashBoard_Jefe();//Vemos el rango del usuario actual y lo regresamos a
                jefe.Show();                                    //su ventana correspondiente 
                this.Close();
            }
        }

        private void CargarElementos()
        {
            cbxMaterial.DataSource = null;
            cbxTipo.DataSource = null;
            cbxMaterial.Items.Clear();
            cbxTipo.Items.Clear();
        }
    }
}
