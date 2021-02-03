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

namespace ImpresosBernal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        
        private void Login_Load(object sender, EventArgs e)
        {
            DBConeccion();
        }

        //
        //Cadena para la conexion a la base de datos en MySQL
        //
        private void DBConeccion()
        {
            string conexion = "datasource = localhost; username=root; password=; database=impresosbernal;";
            MySqlConnection con = new MySqlConnection(conexion);
            try
            {
                con.Open();
                //MessageBox.Show("Eres la reata, te amo");
            }
            catch(Exception e)
            {
                MessageBox.Show("¡OCURRIO UN ERROR! ---" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string conexion = "datasource = localhost; username=root; password=; database=impresosbernal;";
            MySqlConnection con = new MySqlConnection(conexion);
            //Aseguramos la conexion nuevamente 

            String Consulta = "select Contrasena, Nombre from usuarios where Contrasena='" + txtContra.Text + "' and Nombre ='" + txtUsuario.Text + "';";
            MySqlCommand comando = new MySqlCommand(Consulta, con);
            //Relaizamos la consulta a ver si existiera el usuario con la contraseña
            MySqlDataReader lectora = comando.ExecuteReader();
             


        }
    }
}
