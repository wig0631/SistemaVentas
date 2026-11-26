namespace SistemaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("inventario.txt"))
            {
                foreach (string linea in File.ReadAllLines("inventario.txt"))
                {
                    string[] partes = linea.Split(';');
                    dgvProductos.Rows.Add(partes[0], partes[1], partes[2], partes[3]);
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos()) return;
            decimal precio = decimal.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            decimal total = precio * cantidad;
            dgvProductos.Rows.Add(textBox1.Text, precio, cantidad, total);
            textBox1.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();


        }
        private void ActualizarTotal()
        {
            decimal suma = 0;
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;

                decimal.TryParse(Convert.ToString(fila.Cells[3].Value), out decimal t);
                int.TryParse(Convert.ToString(fila.Cells[2].Value), out int cant);

                suma += t;
                fila.DefaultCellStyle.BackColor = cant < 5 ? Color.LightCoral : Color.White;
            }
            lblTotalGeneral.Text = "Total general: " + suma.ToString("N2");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardarArchivo_Click(object sender, EventArgs e)
        {
            var lineas = new List<string>();
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;
                lineas.Add(fila.Cells[0].Value + ";" + fila.Cells[1].Value + ";" + fila.Cells[2].Value + ";" + fila.Cells[3].Value);
            }
            File.WriteAllLines("inventario.txt", lineas);
            MessageBox.Show("Inventario guardado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null && !dgvProductos.CurrentRow.IsNewRow)
            {
                dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
            }
        }
        private bool DatosValidos()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Escribe el nombre del producto.");
                textBox1.Focus();
                return false;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor que 0.");
                txtPrecio.Focus();
                return false;
            }
            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero mayor que 0.");
                txtCantidad.Focus();
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            ActualizarTotal();
        }

        private void dgvProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ActualizarTotal();
        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.CurrentCell = null;
            string texto = txtBuscar.Text.Trim().ToLower();

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.IsNewRow) continue;
                string nombre = Convert.ToString(fila.Cells[0].Value) ?? "";
                fila.Visible = nombre.ToLower().Contains(texto);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            textBox1.Focus();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjustar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null || dgvProductos.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un producto de la tabla");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Escribe el nombre del producto");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero");
                return;
            }

            var fila = dgvProductos.CurrentRow;
            fila.Cells[0].Value = textBox1.Text;
            fila.Cells[1].Value = precio;
            fila.Cells[2].Value = cantidad;
            fila.Cells[3].Value = precio * cantidad;

            textBox1.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }
    }
}
