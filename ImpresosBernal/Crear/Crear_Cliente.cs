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


namespace ImpresosBernal.Crear
{
    public partial class Crear_Cliente : Form
    {

        public Crear_Cliente()
        {
            InitializeComponent();
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
        
        private void Crear_Cliente_Load(object sender, EventArgs e)
        {
            Form jefe = new ImpresosBernal.DashBoard_Jefe();//Cerramos la ventana anterior
            jefe.Close();

            //Llenado de datos para el dataGridView

            string MyConnection2 = "datasource = mysql5044.site4now.net; username=a6f6c3_ibernal; password=sIyNbvYEf8H0; database=db_a6f6c3_ibernal;";
            //secuencia para conectar la base de datos
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //conectamos la base de datos

            MySqlCommand SELECT = new MySqlCommand("SELECT Material, Tipo, Precio FROM precios WHERE Cliente='Publico en general'", MyConn2);
            MySqlDataAdapter data = new MySqlDataAdapter(SELECT);
            DataTable tabla = new DataTable();

            data.Fill(tabla);

            DataGrid.DataSource = tabla;
            

            //Llenado de datos para el dataGridView
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {

                string insert = "INSERT INTO clientes(Nombre, Direccion, NumeroTelefono) VALUES ('" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtNumero.Text + "');";
                //secuencuia para insertar los valores
                string Select = "SELECT * FROM clientes WHERE Nombre = ('" + txtNombre.Text + "');";
                //Secuencia para saber si el cliente existe


                string MyConnection2 = "datasource = mysql5044.site4now.net; username=a6f6c3_ibernal; password=sIyNbvYEf8H0; database=db_a6f6c3_ibernal;";
                //secuencia para conectar la base de datos
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //conectamos la base de datos


                MySqlCommand MyCommand2 = new MySqlCommand(insert, MyConn2);
                MySqlDataReader MyReader2;
                MySqlCommand MyCommand = new MySqlCommand(Select, MyConn2);
                MySqlDataReader lectora;

                //Buscamos el cliente 
                MyConn2.Open();
                lectora = MyCommand.ExecuteReader();
                Boolean userExist = lectora.Read();
                MyConn2.Close();

                if (userExist == true)
                {
                    MessageBox.Show("Usuario existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    try
                    {
                        MyConn2.Open();
                        MyReader2 = MyCommand2.ExecuteReader();
                        MyConn2.Close();
                        preciosPresonalizados(); //añadimos los precios personalizados al cliente ligado
                        MessageBox.Show("El usuario se ha agregado correctamente", "Sucesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDireccion.Text = "";
                        txtNombre.Text = "";
                        txtNumero.Text = "";
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("¡OCURRIO UN ERROR!---" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                errorProvider1.SetError(txtNombre, ("Ingrese un nombre"));
            }


            
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            float temp = 0;

            if (!float.TryParse(txtNumero.Text, out temp))
            {
                errorProvider1.SetError(txtNumero, "Solo debe contener caracteres numericos");
                btnSend.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtNumero, "");
                btnSend.Enabled = true;
            }
        }

        private void preciosPresonalizados()
        {
            string material;
            string tipo;
            int precio;
            string cliente;
            string MyConnection2 = "datasource = mysql5044.site4now.net; username=a6f6c3_ibernal; password=sIyNbvYEf8H0; database=db_a6f6c3_ibernal;";
            //secuencia para conectar la base de datos
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //conectamos la base de datos

            try
            {
                foreach (DataGridViewRow row in DataGrid.Rows)
                {
                    material = Convert.ToString(row.Cells["Material"].Value);
                    tipo = Convert.ToString(row.Cells["Tipo"].Value);               //Asignamos a las variables sus 
                    precio = Convert.ToInt32(row.Cells["Precio"].Value);           //sus valores correspondientes
                    cliente = txtNombre.Text;

                    MySqlCommand agregar = new MySqlCommand("INSERT INTO PRECIOS (Material, Tipo, Precio, Cliente) VALUES ('" +
                    material + "','" + tipo + "', " + precio + ", '" + cliente + "');", MyConn2);

                    MyConn2.Open();
                    agregar.ExecuteReader();            //ejecutamos la consulta
                    MyConn2.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("¡OCURRIO UN ERROR!---" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
