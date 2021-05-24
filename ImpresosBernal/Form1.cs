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
            string conexion = "datasource = mysql5044.site4now.net; username=a6f6c3_ibernal; password=sIyNbvYEf8H0; database=db_a6f6c3_ibernal;"
;
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

        internal static string tipoCompartido;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource = mysql5044.site4now.net; username=a6f6c3_ibernal; password=sIyNbvYEf8H0; database=db_a6f6c3_ibernal;"
);
            MySqlCommand command; //Establecemos variables de tipo comando
            MySqlDataReader mdr;//Establecemos variables de tipo DataReader

            connection.Open();//Abrimos la coneccion con la BD
            string selectQuery = "SELECT * FROM usuarios WHERE Nombre = '" + txtUsuario.Text + "' AND Contrasena = '" + txtContra.Text + "';";
            //Establecemos una secuencia SQL
            command = new MySqlCommand(selectQuery, connection);
            //La mandamos en conjunto de la conexion a la BD
            mdr = command.ExecuteReader();//Vemos si la secuencia arrpjp datos de regreso
            if (mdr.Read())//si lo encontro datos
            {
                string MyConnection2 = "datasource = mysql5044.site4now.net; username=a6f6c3_ibernal; password=sIyNbvYEf8H0; database=db_a6f6c3_ibernal;"
;
                string Query = "update usuarios set LastLogin='" + dateTimePicker1.Value + "' where Nombre='" + this.txtUsuario.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //Establecemos una nueva coneccion pero esta vez vamos a grabar la ultima fecha de coneccion del usuario
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();

                MessageBox.Show("Bienvenido!", "Acceso comprobado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                //Una vez comprobado el acceso procedemos a ver que tipo de usuario es
                string idtenti = @"SELECT Tipo FROM usuarios WHERE Nombre='"+this.txtUsuario.Text+"';";//realizamos la consulta 
                MySqlCommand Identificador = new MySqlCommand(idtenti, MyConn2);
                MySqlDataReader MyReader3;
                MyConn2.Open();
                MyReader3 = Identificador.ExecuteReader();

                string tipo;
                if (MyReader3.Read())//si MyrRader3 lee datos entonces
                {
                    tipo = MyReader3["Tipo"].ToString();//asignamos en la variable string el tipo de usuario
                    //MessageBox.Show(tipo);
                    tipoCompartido = tipo;

                    Form jefe = new ImpresosBernal.DashBoard_Jefe();
                    txtContra.Text = " ";
                    txtUsuario.Text = "";
                    
                    if (tipo == "Jefe")
                    {
                        jefe.Show();
                    }
                    this.Visible = false;
                }
                
                MyConn2.Close();
            }
            else
            {
                if (!(string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContra.Text)))//Nos aseguramos que no esten vacias los textbox
                {
                    MessageBox.Show("Credenciales incorrectas, por favor intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            connection.Close();
        }



        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty && txtUsuario.Text.All(char.IsLetterOrDigit))
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(txtUsuario, "");
            }
            else
            {
                if (!(txtUsuario.Text.All(char.IsLetterOrDigit)))
                {
                    errorProvider1.SetError(txtUsuario, "El nombre de usuario solo debe contener letras y numeros");
                }
                else
                {
                    errorProvider1.SetError(txtUsuario, "Debe ingresar un nombre de usuario");
                }
                btnIngresar.Enabled = false;
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            if (txtContra.Text.Trim() != string.Empty && txtContra.Text.All(char.IsLetterOrDigit))
            {
                btnIngresar.Enabled = true;
                errorProvider1.SetError(txtContra, "");
            }
            else
            {
                if (!(txtContra.Text.All(char.IsLetterOrDigit)))
                {
                    //errorProvider1.SetError(txtContra, "El nombre de usuario solo debe contener letras y numeros");
                }
                else
                {
                    errorProvider1.SetError(txtContra, "Debe ingresar una contraseña");
                }
                btnIngresar.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)//ocultar caracteres 
            {
                if (txtContra.PasswordChar == '*')
                {
                    txtContra.PasswordChar = '\0';
                }
            }
            else
            {
                txtContra.PasswordChar = '*';
            }
        }
    }
}
