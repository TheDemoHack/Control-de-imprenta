using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpresosBernal.Ramificaciones
{
    public partial class DashBoard_Jefe : Form
    {
        public DashBoard_Jefe()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form crear = new Crear_Jefe(); 
            crear.Show();
            //this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form eliminar = new ImpresosBernal.Jefe.Eliminar_Jefe();
            eliminar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form modificar = new ImpresosBernal.Jefe.Modificar_Jefe();
            modificar.Show();
        }
    }
}
