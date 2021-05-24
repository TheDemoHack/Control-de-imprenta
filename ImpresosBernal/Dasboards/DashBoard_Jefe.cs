using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpresosBernal
{
    public partial class DashBoard_Jefe : Form
    {
        public DashBoard_Jefe()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form crear = new ImpresosBernal.Ramificaciones.Crear_Jefe();
            crear.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Form eliminar = new ImpresosBernal.Ramificaciones.Eliminar_Jefe();
            eliminar.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form modi = new ImpresosBernal.Ramificaciones.Modificar_Jefe();
            modi.Show();
        }

        private void DashBoard_Jefe_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form search = new ImpresosBernal.Ramificaciones.Buscar_Jefe();
            search.Show();
        }

        private void DashBoard_Jefe_Load(object sender, EventArgs e)
        {

        }
    }
}
