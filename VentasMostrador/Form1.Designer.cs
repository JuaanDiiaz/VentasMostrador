namespace VentasMostrador
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenuLateral = new Panel();
            panelResultadoBusqueda = new Panel();
            panelBusqueda = new Panel();
            textBoxBusqueda = new TextBox();
            buttonBusqueda = new Button();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            panelMenuContact = new Panel();
            labelFecha = new Label();
            pictureBoxLogo = new PictureBox();
            panelCabecera = new Panel();
            panelBusquedaArticulo = new Panel();
            buttonAgregar = new Button();
            labelDescuentos = new Label();
            labelPrecio = new Label();
            labelDescripcion = new Label();
            labelNombre = new Label();
            pictureBoxArticulo = new PictureBox();
            panelCabeceraVenta = new Panel();
            labelTotal = new Label();
            labelSubtotal = new Label();
            labelImpuestosVenta = new Label();
            labelDescuentoVenta = new Label();
            panelDetalleVenta = new Panel();
            dataGridViewDetalleVenta = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            ColumnPrecio = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            ColumnPorcentajeDescuento = new DataGridViewTextBoxColumn();
            ColumnDescuento = new DataGridViewTextBoxColumn();
            ColumnIva = new DataGridViewTextBoxColumn();
            ColumnTotal = new DataGridViewTextBoxColumn();
            panelMenuLateral.SuspendLayout();
            panelBusqueda.SuspendLayout();
            panelMenuContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelCabecera.SuspendLayout();
            panelBusquedaArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArticulo).BeginInit();
            panelCabeceraVenta.SuspendLayout();
            panelDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.FromArgb(240, 240, 240);
            panelMenuLateral.Controls.Add(panelResultadoBusqueda);
            panelMenuLateral.Controls.Add(panelBusqueda);
            panelMenuLateral.Controls.Add(buttonCancelar);
            panelMenuLateral.Controls.Add(buttonAceptar);
            panelMenuLateral.Controls.Add(panelMenuContact);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(250, 648);
            panelMenuLateral.TabIndex = 0;
            // 
            // panelResultadoBusqueda
            // 
            panelResultadoBusqueda.AutoScroll = true;
            panelResultadoBusqueda.Dock = DockStyle.Fill;
            panelResultadoBusqueda.Location = new Point(0, 200);
            panelResultadoBusqueda.Name = "panelResultadoBusqueda";
            panelResultadoBusqueda.Size = new Size(250, 402);
            panelResultadoBusqueda.TabIndex = 7;
            // 
            // panelBusqueda
            // 
            panelBusqueda.BackColor = Color.FromArgb(230, 230, 230);
            panelBusqueda.Controls.Add(textBoxBusqueda);
            panelBusqueda.Controls.Add(buttonBusqueda);
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.Location = new Point(0, 175);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(250, 25);
            panelBusqueda.TabIndex = 6;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Dock = DockStyle.Fill;
            textBoxBusqueda.Location = new Point(59, 0);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(191, 23);
            textBoxBusqueda.TabIndex = 6;
            textBoxBusqueda.KeyDown += textBoxBusqueda_KeyDown;
            // 
            // buttonBusqueda
            // 
            buttonBusqueda.BackColor = Color.FromArgb(33, 150, 243);
            buttonBusqueda.Dock = DockStyle.Left;
            buttonBusqueda.FlatStyle = FlatStyle.Flat;
            buttonBusqueda.ForeColor = Color.White;
            buttonBusqueda.Location = new Point(0, 0);
            buttonBusqueda.Name = "buttonBusqueda";
            buttonBusqueda.Size = new Size(59, 25);
            buttonBusqueda.TabIndex = 5;
            buttonBusqueda.Text = "Buscar";
            buttonBusqueda.UseVisualStyleBackColor = false;
            buttonBusqueda.Click += buttonBusqueda_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(33, 150, 243);
            buttonCancelar.Dock = DockStyle.Bottom;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(0, 602);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(250, 23);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.BackColor = Color.FromArgb(76, 175, 80);
            buttonAceptar.Dock = DockStyle.Bottom;
            buttonAceptar.FlatStyle = FlatStyle.Flat;
            buttonAceptar.ForeColor = Color.White;
            buttonAceptar.Location = new Point(0, 625);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(250, 23);
            buttonAceptar.TabIndex = 3;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = false;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // panelMenuContact
            // 
            panelMenuContact.BackColor = Color.FromArgb(200, 200, 200);
            panelMenuContact.Controls.Add(labelFecha);
            panelMenuContact.Controls.Add(pictureBoxLogo);
            panelMenuContact.Dock = DockStyle.Top;
            panelMenuContact.Location = new Point(0, 0);
            panelMenuContact.Name = "panelMenuContact";
            panelMenuContact.Size = new Size(250, 175);
            panelMenuContact.TabIndex = 1;
            // 
            // labelFecha
            // 
            labelFecha.Dock = DockStyle.Bottom;
            labelFecha.ForeColor = Color.Black;
            labelFecha.Location = new Point(0, 160);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(250, 15);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "2/27/2024 9:32:09 PM";
            labelFecha.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(250, 157);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelCabecera
            // 
            panelCabecera.Controls.Add(panelBusquedaArticulo);
            panelCabecera.Controls.Add(panelCabeceraVenta);
            panelCabecera.Dock = DockStyle.Bottom;
            panelCabecera.Location = new Point(250, 448);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(903, 200);
            panelCabecera.TabIndex = 1;
            // 
            // panelBusquedaArticulo
            // 
            panelBusquedaArticulo.BackColor = Color.White;
            panelBusquedaArticulo.Controls.Add(buttonAgregar);
            panelBusquedaArticulo.Controls.Add(labelDescuentos);
            panelBusquedaArticulo.Controls.Add(labelPrecio);
            panelBusquedaArticulo.Controls.Add(labelDescripcion);
            panelBusquedaArticulo.Controls.Add(labelNombre);
            panelBusquedaArticulo.Controls.Add(pictureBoxArticulo);
            panelBusquedaArticulo.Dock = DockStyle.Fill;
            panelBusquedaArticulo.Location = new Point(0, 0);
            panelBusquedaArticulo.Name = "panelBusquedaArticulo";
            panelBusquedaArticulo.Size = new Size(586, 200);
            panelBusquedaArticulo.TabIndex = 1;
            panelBusquedaArticulo.Visible = false;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(76, 175, 80);
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.ForeColor = Color.White;
            buttonAgregar.Location = new Point(15, 171);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(150, 25);
            buttonAgregar.TabIndex = 7;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // labelDescuentos
            // 
            labelDescuentos.ForeColor = Color.Black;
            labelDescuentos.Location = new Point(180, 150);
            labelDescuentos.Name = "labelDescuentos";
            labelDescuentos.Size = new Size(245, 15);
            labelDescuentos.TabIndex = 6;
            labelDescuentos.Text = "Descuentos: 10%";
            labelDescuentos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPrecio
            // 
            labelPrecio.ForeColor = Color.Black;
            labelPrecio.Location = new Point(180, 115);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(245, 15);
            labelPrecio.TabIndex = 5;
            labelPrecio.Text = "Precio: $100";
            labelPrecio.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescripcion
            // 
            labelDescripcion.ForeColor = Color.Black;
            labelDescripcion.Location = new Point(180, 80);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(245, 15);
            labelDescripcion.TabIndex = 4;
            labelDescripcion.Text = "Descripción: Artículo de prueba";
            labelDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNombre
            // 
            labelNombre.ForeColor = Color.Black;
            labelNombre.Location = new Point(180, 45);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(245, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre: Artículo Ejemplo";
            labelNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxArticulo
            // 
            pictureBoxArticulo.BackColor = Color.Transparent;
            pictureBoxArticulo.Location = new Point(15, 15);
            pictureBoxArticulo.Name = "pictureBoxArticulo";
            pictureBoxArticulo.Size = new Size(150, 150);
            pictureBoxArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxArticulo.TabIndex = 0;
            pictureBoxArticulo.TabStop = false;
            // 
            // panelCabeceraVenta
            // 
            panelCabeceraVenta.BackColor = SystemColors.ButtonFace;
            panelCabeceraVenta.Controls.Add(labelTotal);
            panelCabeceraVenta.Controls.Add(labelSubtotal);
            panelCabeceraVenta.Controls.Add(labelImpuestosVenta);
            panelCabeceraVenta.Controls.Add(labelDescuentoVenta);
            panelCabeceraVenta.Dock = DockStyle.Right;
            panelCabeceraVenta.Location = new Point(586, 0);
            panelCabeceraVenta.Name = "panelCabeceraVenta";
            panelCabeceraVenta.Size = new Size(317, 200);
            panelCabeceraVenta.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.ForeColor = Color.Black;
            labelTotal.Location = new Point(15, 150);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(200, 15);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Total: $0";
            labelTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelSubtotal
            // 
            labelSubtotal.ForeColor = Color.Black;
            labelSubtotal.Location = new Point(15, 115);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(200, 15);
            labelSubtotal.TabIndex = 2;
            labelSubtotal.Text = "Subtotal: $0";
            labelSubtotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelImpuestosVenta
            // 
            labelImpuestosVenta.ForeColor = Color.Black;
            labelImpuestosVenta.Location = new Point(15, 80);
            labelImpuestosVenta.Name = "labelImpuestosVenta";
            labelImpuestosVenta.Size = new Size(200, 15);
            labelImpuestosVenta.TabIndex = 1;
            labelImpuestosVenta.Text = "Impuestos: $0";
            labelImpuestosVenta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDescuentoVenta
            // 
            labelDescuentoVenta.ForeColor = Color.Black;
            labelDescuentoVenta.Location = new Point(15, 45);
            labelDescuentoVenta.Name = "labelDescuentoVenta";
            labelDescuentoVenta.Size = new Size(200, 15);
            labelDescuentoVenta.TabIndex = 0;
            labelDescuentoVenta.Text = "Descuento: $0";
            labelDescuentoVenta.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelDetalleVenta
            // 
            panelDetalleVenta.Controls.Add(dataGridViewDetalleVenta);
            panelDetalleVenta.Dock = DockStyle.Fill;
            panelDetalleVenta.Location = new Point(250, 0);
            panelDetalleVenta.Name = "panelDetalleVenta";
            panelDetalleVenta.Size = new Size(903, 448);
            panelDetalleVenta.TabIndex = 2;
            // 
            // dataGridViewDetalleVenta
            // 
            dataGridViewDetalleVenta.AllowUserToAddRows = false;
            dataGridViewDetalleVenta.AllowUserToDeleteRows = false;
            dataGridViewDetalleVenta.AllowUserToOrderColumns = true;
            dataGridViewDetalleVenta.AllowUserToResizeRows = false;
            dataGridViewDetalleVenta.BackgroundColor = Color.WhiteSmoke;
            dataGridViewDetalleVenta.BorderStyle = BorderStyle.None;
            dataGridViewDetalleVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnNombre, ColumnDescripcion, ColumnPrecio, ColumnCantidad, ColumnPorcentajeDescuento, ColumnDescuento, ColumnIva, ColumnTotal });
            dataGridViewDetalleVenta.Dock = DockStyle.Fill;
            dataGridViewDetalleVenta.Location = new Point(0, 0);
            dataGridViewDetalleVenta.Name = "dataGridViewDetalleVenta";
            dataGridViewDetalleVenta.RowHeadersVisible = false;
            dataGridViewDetalleVenta.RowTemplate.Height = 25;
            dataGridViewDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDetalleVenta.Size = new Size(903, 448);
            dataGridViewDetalleVenta.TabIndex = 0;
            dataGridViewDetalleVenta.CellEndEdit += dataGridViewDetalleVenta_CellEndEdit;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "Codigo";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            // 
            // ColumnDescripcion
            // 
            ColumnDescripcion.HeaderText = "Descripción";
            ColumnDescripcion.Name = "ColumnDescripcion";
            ColumnDescripcion.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            ColumnPrecio.HeaderText = "Precio";
            ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.HeaderText = "Cantidad";
            ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumnPorcentajeDescuento
            // 
            ColumnPorcentajeDescuento.HeaderText = "Descuento (%)";
            ColumnPorcentajeDescuento.Name = "ColumnPorcentajeDescuento";
            // 
            // ColumnDescuento
            // 
            ColumnDescuento.HeaderText = "Descuento";
            ColumnDescuento.Name = "ColumnDescuento";
            ColumnDescuento.ReadOnly = true;
            // 
            // ColumnIva
            // 
            ColumnIva.HeaderText = "IVA";
            ColumnIva.Name = "ColumnIva";
            ColumnIva.ReadOnly = true;
            // 
            // ColumnTotal
            // 
            ColumnTotal.HeaderText = "Total";
            ColumnTotal.Name = "ColumnTotal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 648);
            Controls.Add(panelDetalleVenta);
            Controls.Add(panelCabecera);
            Controls.Add(panelMenuLateral);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ventas Mostrador";
            panelMenuLateral.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelMenuContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelCabecera.ResumeLayout(false);
            panelBusquedaArticulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxArticulo).EndInit();
            panelCabeceraVenta.ResumeLayout(false);
            panelDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleVenta).EndInit();
            ResumeLayout(false);
        }

        private Panel panelMenuLateral;
        private Panel panelResultadoBusqueda;
        private Panel panelBusqueda;
        private TextBox textBoxBusqueda;
        private Button buttonBusqueda;
        private Button buttonCancelar;
        private Button buttonAceptar;
        private Panel panelMenuContact;
        private Label labelFecha;
        private PictureBox pictureBoxLogo;
        private Panel panelCabecera;
        private Panel panelBusquedaArticulo;
        private Button buttonAgregar;
        private Label labelDescuentos;
        private Label labelPrecio;
        private Label labelDescripcion;
        private Label labelNombre;
        private PictureBox pictureBoxArticulo;
        private Panel panelCabeceraVenta;
        private Label labelTotal;
        private Label labelSubtotal;
        private Label labelImpuestosVenta;
        private Label labelDescuentoVenta;
        private Panel panelDetalleVenta;
        private DataGridView dataGridViewDetalleVenta;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnCantidad;
        private DataGridViewTextBoxColumn ColumnPorcentajeDescuento;
        private DataGridViewTextBoxColumn ColumnDescuento;
        private DataGridViewTextBoxColumn ColumnIva;
        private DataGridViewTextBoxColumn ColumnTotal;
    }
}
