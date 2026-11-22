namespace SistemaVentas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnGuardar = new Button();
            dgvProductos = new DataGridView();
            Producto = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            btnGuardarArchivo = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 24);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Highlight;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(591, 16);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.WhiteSmoke;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Producto, Precio, Cantidad, Total });
            dgvProductos.Location = new Point(0, 63);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.Size = new Size(920, 537);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto ";
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(131, 25);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 27);
            txtPrecio.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 5;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(272, 25);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(114, 27);
            txtCantidad.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Cantidad";
            // 
            // btnGuardarArchivo
            // 
            btnGuardarArchivo.BackColor = SystemColors.Highlight;
            btnGuardarArchivo.FlatStyle = FlatStyle.Flat;
            btnGuardarArchivo.ForeColor = SystemColors.ButtonFace;
            btnGuardarArchivo.Location = new Point(450, 16);
            btnGuardarArchivo.Margin = new Padding(3, 4, 3, 4);
            btnGuardarArchivo.Name = "btnGuardarArchivo";
            btnGuardarArchivo.Size = new Size(134, 31);
            btnGuardarArchivo.TabIndex = 9;
            btnGuardarArchivo.Text = "Guardar archivo";
            btnGuardarArchivo.UseVisualStyleBackColor = false;
            btnGuardarArchivo.Click += btnGuardarArchivo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(683, 16);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardarArchivo);
            Controls.Add(label3);
            Controls.Add(txtCantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(dgvProductos);
            Controls.Add(btnGuardar);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Ventas e Inventario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnGuardar;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Producto;
        private TextBox txtPrecio;
        private DataGridViewTextBoxColumn Precio;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Cantidad;
        private TextBox txtCantidad;
        private Label label3;
        private Button btnGuardarArchivo;
        private Button btnEliminar;
        private DataGridViewTextBoxColumn Total;
    }
}
