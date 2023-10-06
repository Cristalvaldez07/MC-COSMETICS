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

namespace BeautyProducts
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            string connectionString = @"Data Source=VZCRISTAL\SQLEXPRESS;Initial Catalog=BellezaDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
        }

        private bool ValidarCredenciales(string Usuario, string Contraseña)
        {
            try
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Usuario WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@Usuario", Usuario);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);
                int count = (int)comando.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse a la base de datos: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código que deseas ejecutar cuando el formulario se carga
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string Usuario = textBox1.Text;
            string Contraseña = textBox2.Text;



            if (!string.IsNullOrEmpty(Usuario) && !string.IsNullOrEmpty(Contraseña))
            {
                if (ValidarCredenciales(Usuario, Contraseña))
                {
                    // Credenciales válidas, iniciar sesión y mostrar el formulario principal
                    MessageBox.Show("Inicio de sesión exitoso");

                    Form3 form3 = new Form3();
                    form3.Show();

                    // Opcionalmente, puedes ocultar el formulario de inicio de sesión
                    this.Hide();
                }
                else
                {
                    // Credenciales inválidas, mostrar mensaje de error
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            else
            {
                // Usuario o contraseña vacíos, mostrar mensaje de error
                MessageBox.Show("Por favor ingrese un usuario y contraseña");


            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text; // Obtén el nombre de usuario del campo de texto
            string correoElectronico = GetCorreoElectronicoFromDatabase(usuario); // Obtén el correo electrónico del usuario desde la base de datos

            // Verifica si se encontró un correo electrónico válido para el usuario
            if (!string.IsNullOrEmpty(correoElectronico))
            {
                // Aquí puedes implementar la lógica para restablecer la contraseña.
                // Esto podría incluir enviar un correo electrónico al usuario con un enlace o una nueva contraseña generada automáticamente.

                // Ejemplo: Mostrar un mensaje al usuario después de enviar el correo electrónico de restablecimiento de contraseña.
                MessageBox.Show("Se ha enviado un correo electrónico de restablecimiento de contraseña a la dirección asociada a su cuenta.");
            }
            else
            {
                // No se encontró un correo electrónico para el usuario, muestra un mensaje de error.
                MessageBox.Show("No se encontró un correo electrónico asociado a su cuenta de usuario.");
            }
        }

        private string GetCorreoElectronicoFromDatabase(string usuario)
        {
            try
            {
                connection.Open();
                string query = "SELECT CorreoElectronico FROM Usuario WHERE Usuario = @Usuario";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                string correoElectronico = comando.ExecuteScalar()?.ToString();
                return correoElectronico;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el correo electrónico: " + ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Mostrar el formulario Form2
            form2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
    }
