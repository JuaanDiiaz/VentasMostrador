namespace VentasMostrador
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
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnDescripcion = new DataGridViewTextBoxColumn();
            ColumnPrecio = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            ColumnPorcentajeDescuento = new DataGridViewTextBoxColumn();
            ColumnDescuento = new DataGridViewTextBoxColumn();
            ColumnIva = new DataGridViewTextBoxColumn();
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
            panelMenuLateral.Controls.Add(panelResultadoBusqueda);
            panelMenuLateral.Controls.Add(panelBusqueda);
            panelMenuLateral.Controls.Add(buttonCancelar);
            panelMenuLateral.Controls.Add(buttonAceptar);
            panelMenuLateral.Controls.Add(panelMenuContact);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(200, 648);
            panelMenuLateral.TabIndex = 0;
            // 
            // panelResultadoBusqueda
            // 
            panelResultadoBusqueda.AutoScroll = true;
            panelResultadoBusqueda.Dock = DockStyle.Fill;
            panelResultadoBusqueda.Location = new Point(0, 187);
            panelResultadoBusqueda.Name = "panelResultadoBusqueda";
            panelResultadoBusqueda.Size = new Size(200, 415);
            panelResultadoBusqueda.TabIndex = 7;
            // 
            // panelBusqueda
            // 
            panelBusqueda.Controls.Add(textBoxBusqueda);
            panelBusqueda.Controls.Add(buttonBusqueda);
            panelBusqueda.Dock = DockStyle.Top;
            panelBusqueda.Location = new Point(0, 162);
            panelBusqueda.Name = "panelBusqueda";
            panelBusqueda.Size = new Size(200, 25);
            panelBusqueda.TabIndex = 6;
            // 
            // textBoxBusqueda
            // 
            textBoxBusqueda.Dock = DockStyle.Fill;
            textBoxBusqueda.Location = new Point(53, 0);
            textBoxBusqueda.Name = "textBoxBusqueda";
            textBoxBusqueda.Size = new Size(147, 23);
            textBoxBusqueda.TabIndex = 6;
            textBoxBusqueda.KeyDown += textBoxBusqueda_KeyDown;
            // 
            // buttonBusqueda
            // 
            buttonBusqueda.Dock = DockStyle.Left;
            buttonBusqueda.Location = new Point(0, 0);
            buttonBusqueda.Name = "buttonBusqueda";
            buttonBusqueda.Size = new Size(53, 25);
            buttonBusqueda.TabIndex = 5;
            buttonBusqueda.Text = "buscar";
            buttonBusqueda.UseVisualStyleBackColor = true;
            buttonBusqueda.Click += buttonBusqueda_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Dock = DockStyle.Bottom;
            buttonCancelar.Location = new Point(0, 602);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(200, 23);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Dock = DockStyle.Bottom;
            buttonAceptar.Location = new Point(0, 625);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(200, 23);
            buttonAceptar.TabIndex = 3;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // panelMenuContact
            // 
            panelMenuContact.Controls.Add(labelFecha);
            panelMenuContact.Controls.Add(pictureBoxLogo);
            panelMenuContact.Dock = DockStyle.Top;
            panelMenuContact.Location = new Point(0, 0);
            panelMenuContact.Name = "panelMenuContact";
            panelMenuContact.Size = new Size(200, 162);
            panelMenuContact.TabIndex = 1;
            // 
            // labelFecha
            // 
            labelFecha.Dock = DockStyle.Top;
            labelFecha.Location = new Point(0, 144);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(200, 15);
            labelFecha.TabIndex = 1;
            labelFecha.Text = "2/27/2024 9:32:09 PM";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 144);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelCabecera
            // 
            panelCabecera.Controls.Add(panelBusquedaArticulo);
            panelCabecera.Controls.Add(panelCabeceraVenta);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(200, 0);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(892, 218);
            panelCabecera.TabIndex = 1;
            // 
            // panelBusquedaArticulo
            // 
            panelBusquedaArticulo.BackColor = SystemColors.ControlLightLight;
            panelBusquedaArticulo.Controls.Add(buttonAgregar);
            panelBusquedaArticulo.Controls.Add(labelDescuentos);
            panelBusquedaArticulo.Controls.Add(labelPrecio);
            panelBusquedaArticulo.Controls.Add(labelDescripcion);
            panelBusquedaArticulo.Controls.Add(labelNombre);
            panelBusquedaArticulo.Controls.Add(pictureBoxArticulo);
            panelBusquedaArticulo.Dock = DockStyle.Fill;
            panelBusquedaArticulo.Location = new Point(317, 0);
            panelBusquedaArticulo.Name = "panelBusquedaArticulo";
            panelBusquedaArticulo.Size = new Size(575, 218);
            panelBusquedaArticulo.TabIndex = 1;
            panelBusquedaArticulo.Visible = false;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(263, 187);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(250, 23);
            buttonAgregar.TabIndex = 5;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // labelDescuentos
            // 
            labelDescuentos.AutoSize = true;
            labelDescuentos.Location = new Point(263, 85);
            labelDescuentos.Name = "labelDescuentos";
            labelDescuentos.Size = new Size(74, 15);
            labelDescuentos.TabIndex = 4;
            labelDescuentos.Text = "Descuentos: ";
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Location = new Point(263, 70);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(46, 15);
            labelPrecio.TabIndex = 3;
            labelPrecio.Text = "Precio: ";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(263, 55);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(75, 15);
            labelDescripcion.TabIndex = 2;
            labelDescripcion.Text = "Descripcion: ";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(263, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(57, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre: ";
            // 
            // pictureBoxArticulo
            // 
            pictureBoxArticulo.Location = new Point(6, 12);
            pictureBoxArticulo.Name = "pictureBoxArticulo";
            pictureBoxArticulo.Size = new Size(251, 198);
            pictureBoxArticulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxArticulo.TabIndex = 0;
            pictureBoxArticulo.TabStop = false;
            // 
            // panelCabeceraVenta
            // 
            panelCabeceraVenta.Controls.Add(labelTotal);
            panelCabeceraVenta.Controls.Add(labelSubtotal);
            panelCabeceraVenta.Controls.Add(labelImpuestosVenta);
            panelCabeceraVenta.Controls.Add(labelDescuentoVenta);
            panelCabeceraVenta.Dock = DockStyle.Left;
            panelCabeceraVenta.Location = new Point(0, 0);
            panelCabeceraVenta.Name = "panelCabeceraVenta";
            panelCabeceraVenta.Size = new Size(317, 218);
            panelCabeceraVenta.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(16, 94);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(38, 15);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Total: ";
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(16, 79);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(61, 15);
            labelSubtotal.TabIndex = 2;
            labelSubtotal.Text = "Sub Total: ";
            // 
            // labelImpuestosVenta
            // 
            labelImpuestosVenta.AutoSize = true;
            labelImpuestosVenta.Location = new Point(16, 64);
            labelImpuestosVenta.Name = "labelImpuestosVenta";
            labelImpuestosVenta.Size = new Size(68, 15);
            labelImpuestosVenta.TabIndex = 1;
            labelImpuestosVenta.Text = "Impuestos: ";
            // 
            // labelDescuentoVenta
            // 
            labelDescuentoVenta.AutoSize = true;
            labelDescuentoVenta.Location = new Point(16, 49);
            labelDescuentoVenta.Name = "labelDescuentoVenta";
            labelDescuentoVenta.Size = new Size(74, 15);
            labelDescuentoVenta.TabIndex = 0;
            labelDescuentoVenta.Text = "Descuentos: ";
            // 
            // panelDetalleVenta
            // 
            panelDetalleVenta.Controls.Add(dataGridViewDetalleVenta);
            panelDetalleVenta.Dock = DockStyle.Fill;
            panelDetalleVenta.Location = new Point(200, 218);
            panelDetalleVenta.Name = "panelDetalleVenta";
            panelDetalleVenta.Size = new Size(892, 430);
            panelDetalleVenta.TabIndex = 2;
            // 
            // dataGridViewDetalleVenta
            // 
            dataGridViewDetalleVenta.AllowUserToAddRows = false;
            dataGridViewDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { ColumnNombre, ColumnDescripcion, ColumnPrecio, ColumnCantidad, ColumnPorcentajeDescuento, ColumnDescuento, ColumnIva });
            dataGridViewDetalleVenta.Dock = DockStyle.Fill;
            dataGridViewDetalleVenta.Location = new Point(0, 0);
            dataGridViewDetalleVenta.Name = "dataGridViewDetalleVenta";
            dataGridViewDetalleVenta.RowTemplate.Height = 25;
            dataGridViewDetalleVenta.Size = new Size(892, 430);
            dataGridViewDetalleVenta.TabIndex = 0;
            dataGridViewDetalleVenta.CellEndEdit += dataGridViewDetalleVenta_CellEndEdit;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            // 
            // ColumnDescripcion
            // 
            ColumnDescripcion.HeaderText = "Descripcion";
            ColumnDescripcion.Name = "ColumnDescripcion";
            ColumnDescripcion.ReadOnly = true;
            ColumnDescripcion.Width = 250;
            // 
            // ColumnPrecio
            // 
            ColumnPrecio.HeaderText = "Precio";
            ColumnPrecio.Name = "ColumnPrecio";
            ColumnPrecio.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.HeaderText = "Cantidad";
            ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumnPorcentajeDescuento
            // 
            ColumnPorcentajeDescuento.HeaderText = "%";
            ColumnPorcentajeDescuento.Name = "ColumnPorcentajeDescuento";
            ColumnPorcentajeDescuento.ReadOnly = true;
            ColumnPorcentajeDescuento.Width = 50;
            // 
            // ColumnDescuento
            // 
            ColumnDescuento.HeaderText = "Descuento";
            ColumnDescuento.Name = "ColumnDescuento";
            ColumnDescuento.ReadOnly = true;
            // 
            // ColumnIva
            // 
            ColumnIva.HeaderText = "Iva";
            ColumnIva.Name = "ColumnIva";
            ColumnIva.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 648);
            Controls.Add(panelDetalleVenta);
            Controls.Add(panelCabecera);
            Controls.Add(panelMenuLateral);
            Name = "Form1";
            Text = "Form1";
            panelMenuLateral.ResumeLayout(false);
            panelBusqueda.ResumeLayout(false);
            panelBusqueda.PerformLayout();
            panelMenuContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelCabecera.ResumeLayout(false);
            panelBusquedaArticulo.ResumeLayout(false);
            panelBusquedaArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxArticulo).EndInit();
            panelCabeceraVenta.ResumeLayout(false);
            panelCabeceraVenta.PerformLayout();
            panelDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDetalleVenta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Panel panelMenuContact;
        private Label labelFecha;
        private PictureBox pictureBoxLogo;
        private Button buttonCancelar;
        private Button buttonAceptar;
        private Panel panelCabecera;
        private Panel panelBusquedaArticulo;
        private Panel panelCabeceraVenta;
        private Panel panelDetalleVenta;
        private Panel panelBusqueda;
        private TextBox textBoxBusqueda;
        private Button buttonBusqueda;
        private Panel panelResultadoBusqueda;
        private PictureBox pictureBoxArticulo;
        private Label labelPrecio;
        private Label labelDescripcion;
        private Label labelNombre;
        private Label labelDescuentos;
        private DataGridView dataGridViewDetalleVenta;
        private Button buttonAgregar;
        private Label labelTotal;
        private Label labelSubtotal;
        private Label labelImpuestosVenta;
        private Label labelDescuentoVenta;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnCantidad;
        private DataGridViewTextBoxColumn ColumnPorcentajeDescuento;
        private DataGridViewTextBoxColumn ColumnDescuento;
        private DataGridViewTextBoxColumn ColumnIva;
    }
}