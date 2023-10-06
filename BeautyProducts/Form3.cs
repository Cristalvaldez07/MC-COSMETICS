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
    public partial class Form3 : Form
    {
        private SqlConnection connection;
        private List<string> productosSeleccionados = new List<string>();
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private BindingSource bindingSource;

        private bool detallesVisible = false;


        public Form3()
        {

            InitializeComponent();
            dataGridViewProductos.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            pictureBox1.Visible = false;




            // Ocultar el control DataGridView al cargar el formulario
            string connectionString = @"Data Source=VZCRISTAL\SQLEXPRESS;Initial Catalog=BellezaDB;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();



            dataGridViewProductos.CellContentClick += dataGridViewProductos_CellContentClick_1; // Suscripción al evento CellContentClick
        }



        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void cOMPRARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            detallesVisible = true;
            ActualizarVisibilidadDetalles();

            // Mostrar el control DataGridView
            dataGridViewProductos.Visible = true;

            // Ocultar los elementos existentes en el formulario
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pictureBox1.Visible = false;
            textBox1.Visible = true;
            button1.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;



            // ...

            // Mostrar el control DataGridView
            dataGridViewProductos.Visible = true;
            // Realizar aquí la lógica para cargar los datos en el DataGridView
            try
            {
                string connectionString = @"Data Source=VZCRISTAL\SQLEXPRESS;Initial Catalog=BellezaDB;Integrated Security=True";

                // Crear una nueva conexión utilizando la cadena de conexión
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abrir la conexión
                    connection.Open();

                    // Crear un objeto SqlCommand para ejecutar la consulta SQL
                    SqlCommand command = new SqlCommand("SELECT NombreProducto, Precio, Marca, Categoria FROM Productos ORDER BY Categoria", connection);

                    // Crear un objeto SqlDataAdapter para obtener los datos de la consulta
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // Crear un objeto DataTable para almacenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos del SqlDataAdapter
                    adapter.Fill(dataTable);

                    // Asignar el DataTable al control DataGridView
                    dataGridViewProductos.DataSource = dataTable;

                    // Opcional: Personalizar los encabezados de las columnas
                    dataGridViewProductos.Columns["NombreProducto"].HeaderText = "Producto";
                    dataGridViewProductos.Columns["Precio"].HeaderText = "Precio";
                    dataGridViewProductos.Columns["Marca"].HeaderText = "Marca";
                    dataGridViewProductos.Columns["Categoria"].HeaderText = "Categoría";

                    // Cerrar la conexión
                    connection.Close();
                }
            }
            catch (SqlException ex)
            {
                // Manejar cualquier error de conexión o consulta SQL
                MessageBox.Show("Error al obtener los productos: " + ex.Message, "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string searchTerm = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                // Filtrar los datos del DataGridView según el término de búsqueda
                (dataGridViewProductos.DataSource as DataTable).DefaultView.RowFilter = $"NombreProducto LIKE '%{searchTerm}%' OR Marca LIKE '%{searchTerm}%'";
            }
            else
            {
                // Restablecer el filtro y mostrar todos los datos
                (dataGridViewProductos.DataSource as DataTable).DefaultView.RowFilter = string.Empty;


            }
        }

        private void dataGridViewProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridViewProductos.Columns[e.ColumnIndex].Name == "Producto")
            {
                string nombreProducto = dataGridViewProductos.Rows[e.RowIndex].Cells["NombreProducto"].Value.ToString();

                DialogResult resultado = MessageBox.Show($"¿Quieres comprar el producto '{nombreProducto}'?", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Lógica para realizar la compra del producto
                    // ...
                }
                else if (resultado == DialogResult.No)
                {
                    // Lógica para no realizar la compra del producto
                    // ...
                }
            }
        }

        private void CargarDatos()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Productos";
                SqlCommand comando = new SqlCommand(query, connection);
                SqlDataReader reader = comando.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                dataGridViewProductos.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void ActualizarVisibilidadDetalles()
        {
            dataGridViewProductos.Visible = detallesVisible;
            textBox1.Visible = detallesVisible;
            button1.Visible = detallesVisible;
            button2.Visible = detallesVisible;
            button3.Visible = detallesVisible;
            label2.Visible = detallesVisible;
            label3.Visible = detallesVisible;
            label4.Visible = detallesVisible;
            label5.Visible = detallesVisible;
            label6.Visible = detallesVisible;
            textBox2.Visible = detallesVisible;
            textBox3.Visible = detallesVisible;
            textBox4.Visible = detallesVisible;
            textBox5.Visible = detallesVisible;
            textBox6.Visible = detallesVisible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(textBox2.Text);
            string nombreProducto = textBox3.Text;
            string marcaProducto = textBox4.Text;
            string categoriaProducto = textBox5.Text;
            decimal precioProducto = Convert.ToDecimal(textBox6.Text);

            try
            {
                connection.Open();
                string query = "INSERT INTO Productos (ID, NombreProducto, Marca, Categoria, Precio) VALUES (@ID, @Nombre, @Marca, @Categoria, @Precio)";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@ID", idProducto);
                comando.Parameters.AddWithValue("@Nombre", nombreProducto);
                comando.Parameters.AddWithValue("@Marca", marcaProducto);
                comando.Parameters.AddWithValue("@Categoria", categoriaProducto);
                comando.Parameters.AddWithValue("@Precio", precioProducto);
                comando.ExecuteNonQuery();

                MessageBox.Show("Producto agregado correctamente a la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
            finally
            {
                connection.Close();

                CargarDatos(); // Actualizar el DataGridView después de agregar el producto
                LimpiarCampos();

            }
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label4.Visible = true;
            label2.Visible = true;



        }

        private void cONTACTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idProducto = Convert.ToInt32(textBox2.Text);
            string nombreProducto = textBox3.Text;
            string marcaProducto = textBox4.Text;
            string categoriaProducto = textBox5.Text;
            decimal precioProducto = Convert.ToDecimal(textBox6.Text);

            try
            {
                connection.Open();
                string query = "UPDATE Productos SET NombreProducto = @Nombre, Marca = @Marca, Categoria = @Categoria, Precio = @Precio WHERE ID = @ID";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@Nombre", nombreProducto);
                comando.Parameters.AddWithValue("@Marca", marcaProducto);
                comando.Parameters.AddWithValue("@Categoria", categoriaProducto);
                comando.Parameters.AddWithValue("@Precio", precioProducto);
                comando.Parameters.AddWithValue("@ID", idProducto);
                comando.ExecuteNonQuery();

                MessageBox.Show("Producto actualizado correctamente en la base de datos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
            finally
            {
                connection.Close();

                CargarDatos(); // Actualizar el DataGridView después de actualizar el producto
                LimpiarCampos();

            }
        }

        private void LimpiarCampos()
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }

        private void mIPERFILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }
    }
}