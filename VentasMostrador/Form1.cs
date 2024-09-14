using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using VentasMostrador.Properties;

namespace VentasMostrador
{
    public partial class Form1 : Form
    {
        DataBaseSimulation _dataContex;
        int folioTicket;
        public Form1()
        {
            InitializeComponent();
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            _dataContex = new DataBaseSimulation();
            folioTicket = 110020;
        }

        private void textBoxBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarYAgregarBotones();
            }
        }

        private void buttonBusqueda_Click(object sender, EventArgs e)
        {
            BuscarYAgregarBotones();
        }

        private void LoadImageFromUrl(string url)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(url);
                    using (var ms = new System.IO.MemoryStream(imageBytes))
                    {
                        pictureBoxArticulo.Image = Image.FromStream(ms);
                        pictureBoxArticulo.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
            }
        }

        private void BuscarYAgregarBotones()
        {
            panelResultadoBusqueda.Controls.Clear();
            var articulosEncontrados = _dataContex.BuscarPorNombreODescripcion(textBoxBusqueda.Text);
            foreach (var articulo in articulosEncontrados)
            {
                Button boton = new Button();
                boton.Text = articulo.Nombre;
                boton.Dock = DockStyle.Top;
                boton.AutoSize = true;
                boton.FlatStyle = FlatStyle.Flat;  // Estilo plano
                boton.FlatAppearance.BorderSize = 0;  // Sin borde
                boton.BackColor = Color.FromArgb(0, 122, 204);  // Color de fondo
                boton.ForeColor = Color.White;  // Color de texto
                boton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);  // Fuente moderna
                boton.Click += (sender, e) =>
                {
                    LoadImageFromUrl(articulo.RutaImagen);
                    labelNombre.Text = $"Nombre: {articulo.Nombre}";
                    labelDescripcion.Text = $"Descripcion: {articulo.Descripcion}";
                    labelPrecio.Text = $"Precio: ${articulo.Precio}";
                    labelDescuentos.Text = $"Descuento: {articulo.Descuento}";
                    panelBusquedaArticulo.Visible = true;
                };
                panelResultadoBusqueda.Controls.Add(boton);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            var articulo = _dataContex.BuscarPorNombre(labelNombre.Text.Replace("Nombre: ", ""));
            var rowIndex = -1;
            foreach (DataGridViewRow row in dataGridViewDetalleVenta.Rows)
            {
                if (row.Cells["ColumnNombre"].Value?.ToString() == articulo.Nombre)
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex == -1)
            {
                var descuento = articulo.Precio * (articulo.Descuento / 100);
                var precioConDescuento = articulo.Precio - descuento;
                var iva = precioConDescuento * (decimal)0.16;
                dataGridViewDetalleVenta.Rows.Add(articulo.Nombre, articulo.Descripcion, articulo.Precio, 1, articulo.Descuento, descuento, iva);
            }
            else
            {
                var row = dataGridViewDetalleVenta.Rows[rowIndex];
                var cantidad = Convert.ToInt32(row.Cells["ColumnCantidad"].Value) + 1;
                var descuento = articulo.Precio * (articulo.Descuento / 100) * cantidad;
                var precioConDescuento = (articulo.Precio * cantidad) - descuento;
                var iva = precioConDescuento * (decimal)0.16;
                row.Cells["ColumnCantidad"].Value = cantidad;
                row.Cells["ColumnDescuento"].Value = descuento;
                row.Cells["ColumnIva"].Value = iva;
            }
            ActualizarTotales();
        }

        private void dataGridViewDetalleVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDetalleVenta.Columns["ColumnCantidad"].Index)
            {
                var row = dataGridViewDetalleVenta.Rows[e.RowIndex];
                var articulo = _dataContex.BuscarPorNombre(row.Cells["ColumnNombre"].Value.ToString());
                var cantidad = Convert.ToInt32(row.Cells["ColumnCantidad"].Value);
                var descuento = articulo.Precio * (articulo.Descuento / 100) * cantidad;
                var precioConDescuento = (articulo.Precio * cantidad) - descuento;
                var iva = precioConDescuento * (decimal)0.16;
                row.Cells["ColumnDescuento"].Value = descuento;
                row.Cells["ColumnIva"].Value = iva;
                ActualizarTotales();
            }
        }

        private void ActualizarTotales()
        {
            var subtotal = dataGridViewDetalleVenta.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells["ColumnPrecio"].Value) * Convert.ToInt32(row.Cells["ColumnCantidad"].Value));
            var descuentos = dataGridViewDetalleVenta.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells["ColumnDescuento"].Value));
            var iva = dataGridViewDetalleVenta.Rows.Cast<DataGridViewRow>().Sum(row => Convert.ToDecimal(row.Cells["ColumnIva"].Value));
            var total = subtotal - descuentos + iva;

            labelSubtotal.Text = $"Subtotal: {subtotal:C2}";
            labelDescuentoVenta.Text = $"Descuentos: {descuentos:C2}";
            labelImpuestosVenta.Text = $"Impuestos: {iva:C2}";
            labelTotal.Text = $"Total: {total:C2}";
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            FinalizarVenta();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            restart();
        }
        private void restart()
        {
            this.Controls.Clear();
            this.InitializeComponent();
            labelFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            _dataContex = new DataBaseSimulation();
        }

        private void FinalizarVenta()
        {
            folioTicket = folioTicket + 1;
            var venta = new
            {
                FechaVenta = DateTime.Now,
                FolioTicket = folioTicket.ToString(),
                TotalVenta = Convert.ToDecimal(labelTotal.Text.Replace("Total: ", string.Empty).Replace("$", string.Empty)),
                EstadoTimbrado = "Sintimbrar",
                Detalleventa = dataGridViewDetalleVenta.Rows.Cast<DataGridViewRow>().Select(row => new
                {
                    Producto = row.Cells["ColumnNombre"].Value.ToString(),
                    Cantidad = Convert.ToInt32(row.Cells["ColumnCantidad"].Value),
                    PrecioUnitario = Convert.ToDecimal(row.Cells["ColumnPrecio"].Value),
                    Subtotal = Convert.ToDecimal(row.Cells["ColumnPrecio"].Value) * Convert.ToInt32(row.Cells["ColumnCantidad"].Value),
                    Impuestosdescuentosdetalles = new dynamic[] // This needs to be defined
                    {
                            new
                            {
                                Tipo = "i",
                                Porcentaje = 16,
                                Monto = Convert.ToDecimal(row.Cells["ColumnPrecio"].Value) * 0.16m,
                            },
                            new
                            {
                                Tipo = "d",
                                Porcentaje = Convert.ToDecimal(row.Cells["ColumnPorcentajeDescuento"].Value), // Use the discount percentage from the grid
                                Monto = Convert.ToDecimal(row.Cells["ColumnPrecio"].Value) * Convert.ToDecimal(row.Cells["ColumnPorcentajeDescuento"].Value) / 100, // Calculate the discount amount using the discount percentage from the grid
                            }
                    }
                }).ToArray()
            };

            var json = JsonConvert.SerializeObject(venta, Newtonsoft.Json.Formatting.Indented);
            MessageBox.Show($"Venta finalizada con folio {folioTicket}");
            //PostToApiAsync("http://ise.somee.com/api/Sales", json).Wait();
            restart();
        }
        public async Task PostToApiAsync(string url, string data)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Respuesta del servicio del kiosko {responseContent}");
                }
                else
                {
                    MessageBox.Show($"Error en la peticion");
                }
            }
        }

    }
}