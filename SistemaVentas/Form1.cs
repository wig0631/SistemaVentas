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
            decimal precio = decimal.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            decimal total = precio * cantidad;
            dgvProductos.Rows.Add(textBox1.Text, precio, cantidad, total);
            textBox1.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();


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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}