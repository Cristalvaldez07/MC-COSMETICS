using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeautyProducts
{
    public partial class Form2 : Form
    {
        private SqlConnection connection;

        public Form2()
        {
            InitializeComponent();
            AgregarOpcionesComboBox();

            string connectionString = @"Data Source=VZCRISTAL\SQLEXPRESS;Initial Catalog=BellezaDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private void AgregarOpcionesComboBox()
        {
            comboBox1.Items.Clear(); // Limpiamos las opciones existentes, en caso de ser necesario

            comboBox1.Items.Add("M");
            comboBox1.Items.Add("F");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Código para el evento label8_Click
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Código para el evento label3_Click
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos de texto u otros controles
            int id = int.Parse(textBox1.Text);
            string nombre = textBox2.Text;
            string apellido = textBox3.Text;
            string genero = comboBox1.SelectedItem.ToString();
            int edad = int.Parse(textBox5.Text);
            string correoElectronico = textBox6.Text;
            string usuario = textBox7.Text;
            string contraseña = textBox8.Text;

            // Establecer una conexión con la base de datos
            try
            {
                connection.Open();

                // Crear la consulta SQL para insertar los datos en la base de datos
                string query = "INSERT INTO Usuario (ID, Nombre, Apellido, Genero, Edad, CorreoElectronico, Usuario, Contraseña) " +
                               "VALUES (@ID, @Nombre, @Apellido, @Genero, @Edad, @CorreoElectronico, @Usuario, @Contraseña)";

                // Crear un objeto SqlCommand para ejecutar la consulta
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Asignar los valores a los parámetros en la consulta SQL
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Genero", genero);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);

                    // Ejecutar la consulta SQL
                    command.ExecuteNonQuery();
                }

                // Mostrar un mensaje de éxito
                MessageBox.Show("Los datos se han guardado exitosamente en la base de datos.");
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si ocurre un problema al guardar los datos
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                // Cerrar la conexión con la base de datos
                connection.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para el evento comboBox1_SelectedIndexChanged
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}