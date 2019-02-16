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

namespace BDMySQL
{
    public partial class FormConectarMySQL : Form
    {
        public FormConectarMySQL()
        {
            InitializeComponent();
        }

        private void FormTestingMySQL_Load(object sender, EventArgs e)
        {
            ServidorTextBox.Focus();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConectarButton_Click(object sender, EventArgs e)
        {
            // inicializar variables.
            string servidor = "";
            uint puerto = 0;
            string usuario = "";
            string password = "";
            string datos = "";
            // asignar los datos del Formulario.
            servidor = ServidorTextBox.Text;
            puerto = Convert.ToUInt32(PuertoTextBox.Text);
            usuario = UsuarioTextBox.Text;
            password = PassWordTextBox.Text;
            // establecer la Cadena de Conexión.
            MySqlConnectionStringBuilder toMySQL = new MySqlConnectionStringBuilder();
            toMySQL.Server = servidor;
            toMySQL.Port = puerto;
            toMySQL.UserID = usuario;
            toMySQL.Password = password;
            // Conectar con MySQL.
            MySqlConnection connection = new MySqlConnection(toMySQL.ToString());
            try
            {
                // Abrir la Conexion.
                connection.Open();
                // Inicializar el lector.
                MySqlDataReader reader = null;
                // Establecer la Operacion a Realizar.
                MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", connection);
                // Ejecutar la Lectura Mientras existan datos.
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    datos += reader.GetString(0) + "\n";
                }
            }
            // Si existe algun Error, lo despliega.
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.ToString());
            }
            // Muestra las BD en un MessageBox y Cierra la Conexión.
            MessageBox.Show(datos);
            connection.Close();

        }
    }
}
