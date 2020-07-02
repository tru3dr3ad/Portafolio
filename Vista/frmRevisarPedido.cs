using Controlador;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmRevisarPedido : Form
    {
        public static int numeroOrdenModificar = 0;

        int _numeroOrdenSeleccionado = 0;

        public frmRevisarPedido()
        {
            InitializeComponent();
            CargarComboboxEstadoOrden();
            CargarComboboxProveedor();
            CargarGrillaOrden();
        }

        #region Metodos
        private void CargarGrillaOrden()
        {
            OrdenPedido orden = new OrdenPedido();
            grdOrden.DataSource = orden.ListarOrdenPedido();
            EsconderColumnasAutogeneradas();
            CambioNombreColumnaGrillaOrden();
        }
        private void CargarGrillaDetalleOrden(int numero)
        {
            DetallePedido detalle = new DetallePedido();
            grdDetalleOrden.DataSource = detalle.ListarDetallePorOrden(numero);
            EsconderColumnasDetalle();
        }
        private void CargarComboboxEstadoOrden()
        {
            Controlador.EstadoOrden estadoOrden = new Controlador.EstadoOrden();
            cmbEstadoOrden.DisplayMember = "Descripcion";
            cmbEstadoOrden.ValueMember = "Id";
            cmbEstadoOrden.DataSource = estadoOrden.Listar();
        }
        private void CargarComboboxProveedor()
        {
            Controlador.Proveedor proveedor = new Controlador.Proveedor();
            cmbProveedores.DisplayMember = "Nombre";
            cmbProveedores.ValueMember = "Rut";
            cmbProveedores.DataSource = proveedor.ListarCombobox();
        }
        private void LimpiarDatos()
        {
            txtBuscarOrden.Clear();
            cmbProveedores.SelectedIndex = 0;
            cmbEstadoOrden.SelectedIndex = 0;
        }
        private void LimpiarGrillaDetalle()
        {
            grdDetalleOrden.Columns.Clear();
        }
        private void EsconderColumnasAutogeneradas()
        {
            grdOrden.Columns["PROVEEDOR_RUT"].Visible = false;
            grdOrden.Columns["IDESTADO"].Visible = false;
        }
        private void EsconderColumnasDetalle()
        {
            grdDetalleOrden.Columns["ORDEN_PEDIDO_NUMEROORDEN"].Visible = false;
            grdDetalleOrden.Columns["IDDETALLEO"].Visible = false;
            grdDetalleOrden.Columns["PRODUCTO_CODIGO"].Visible = false;
            grdDetalleOrden.Columns["NOMBRE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CambioNombreColumnaGrillaOrden()
        {
            grdOrden.Columns["NUMERO"].HeaderText = "N°";
            grdOrden.Columns["FECHA_CREACION"].HeaderText = "FECHA CREACION";
            grdOrden.Columns["FECHA_RECEPCION"].HeaderText = "FECHA RECEPCION";
            grdOrden.Columns["ESTADO_ORDEN"].HeaderText = "ESTADO";
        }
        #endregion

        #region Metodos de la clase

        private void BuscarOrdenPedidoPorNumero()
        {
            OrdenPedido orden = new OrdenPedido();
            if (txtBuscarOrden.Text != "")
            {
                int nroOrden = int.Parse(txtBuscarOrden.Text);
                grdOrden.DataSource = orden.ListarOrdenPedidoPorNumero(nroOrden);
                txtBuscarOrden.Clear();
                EsconderColumnasAutogeneradas();
            }
            else
            {
                CargarGrillaOrden();
            }
        }
        private void AnularOrdenPedido()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
                EstadoOrden estado = new EstadoOrden();
                estado = estado.ObtenerEstadoOrden(orden.Estado.Id);
                string descripcion = estado.Descripcion;
                bool estaGuardada = orden.OrdenPedidoGuardada(_numeroOrdenSeleccionado);
                if (estaGuardada)
                {
                    bool anularOrden = orden.AnularOrdenPedido(_numeroOrdenSeleccionado);
                    if (anularOrden)
                    {
                        MessageBox.Show("Orden de pedido anulada");
                        _numeroOrdenSeleccionado = 0;
                    }
                    else
                    {
                        MessageBox.Show("Orden de pedido no ha sido anulada");
                        _numeroOrdenSeleccionado = 0;
                    }
                }
                else
                {
                    MessageBox.Show("La orden seleccionada se encuentra " + descripcion + ", no se puede anular.");
                }
            }
        }
        private void ModificarOrdenPedido()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
                EstadoOrden estado = new EstadoOrden();
                estado = estado.ObtenerEstadoOrden(orden.Estado.Id);
                string descripcion = estado.Descripcion;
                bool estaGuardada = orden.OrdenPedidoGuardada(_numeroOrdenSeleccionado);
                if (estaGuardada)
                {
                    numeroOrdenModificar = _numeroOrdenSeleccionado;
                    frmModificarOrdenPedido form = new frmModificarOrdenPedido();
                    form.ShowDialog();
                    CargarGrillaOrden();
                    LimpiarGrillaDetalle();
                }
                else
                {
                    MessageBox.Show("La orden seleccionada se encuentra " + descripcion + ", no se puede modicar.");
                }
            }
        }
        public void RecepcionarOrden()
        {
            if (_numeroOrdenSeleccionado != 0)
            {
                OrdenPedido orden = new OrdenPedido();
                orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);

                EstadoOrden estado = new EstadoOrden();
                estado = estado.ObtenerEstadoOrden(orden.Estado.Id);
                string descripcion = estado.Descripcion;
                if (orden.OrdenPedidoEnviada(orden))
                {
                    estado.Id = (int)cmbEstadoOrden.SelectedValue;
                    if (estado.Id != 1)
                    {
                        if (estado.Id != 2)
                        {
                            if (estado.Id != 6)
                            {
                                DateTime fechaRecepcion = DateTime.Now.Date;
                                orden.Estado = estado;
                                orden.FechaRecepcion = fechaRecepcion;
                                if (estado.Id == 4)
                                {
                                    bool ordenRecepcionada = orden.RecepcionarOrdenPedido(orden);
                                    DetallePedido detalle = new DetallePedido();
                                    bool stockAgregado = detalle.AgregarStockOrdenRecepcionada(orden.Numero);
                                    if (stockAgregado && ordenRecepcionada)
                                    {
                                        LimpiarGrillaDetalle();
                                        MessageBox.Show("Se ha recepcionado y agregado el stock correctamente.");
                                        _numeroOrdenSeleccionado = 0;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se ha podido agregar la recepcion.");
                                    }
                                }
                                else if (estado.Id == 3 || estado.Id == 5)
                                {
                                    bool ordenRecepcionada = orden.RecepcionarOrdenPedido(orden);
                                    if (ordenRecepcionada)
                                    {
                                        LimpiarGrillaDetalle();
                                        MessageBox.Show("Se ha guardado la recepcion de la orden de pedido.");
                                        _numeroOrdenSeleccionado = 0;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se ha guardado la recepcion.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se puede anular la orden desde aqui, intente con el boton anular.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La orden ya ha sido enviada");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La orden de pedido ya ha sido enviada, no puede volver a estado guardada.");
                    }
                }
                else
                {
                    MessageBox.Show("La orden seleccionada se encuentra " + descripcion + " , no se puede recepcionar.");
                }
            }
        }
        public void DescargarOrdenPedido()
        {
            OrdenPedido orden = new OrdenPedido();
            orden = orden.ObtenerOrdenPedido(_numeroOrdenSeleccionado);
            if (orden.OrdenPedidoGuardada(orden.Numero))
            {
                DescargarPDFOrdenPedido(orden);
                //bool estaDescargada = orden.DescargarOrdenPedido(_numeroOrdenSeleccionado);
                //if (estaDescargada)
                //{
                //    MessageBox.Show("Orden Descargada");
                //}
                //else
                //{
                //    MessageBox.Show("Orden no se ha podido descargar");
                //}
            }
            else
            {
                MessageBox.Show("La orden ya fue recepcionada");
            }
        }
        #endregion

        #region Botones
        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            BuscarOrdenPedidoPorNumero();
            LimpiarGrillaDetalle();
        }
        private void btnModificarOrden_Click(object sender, EventArgs e)
        {
            ModificarOrdenPedido();
        }
        private void btnAnularOrden_Click(object sender, EventArgs e)
        {
            AnularOrdenPedido();
            CargarGrillaOrden();
            LimpiarDatos();
        }
        private void btnRecepcionar_Click(object sender, EventArgs e)
        {
            RecepcionarOrden();
            CargarGrillaOrden();
        }
        private void btnDescargarOrden_Click(object sender, EventArgs e)
        {
            DescargarOrdenPedido();
            CargarGrillaOrden();
        }
        #endregion

        #region Metodo Para PDF
        private void DescargarPDFOrdenPedido(OrdenPedido orden)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                    try
                    {
                        string ruta = sfd.FileName;
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();

                        var imagePath = @"C:\Users\krist\source\repos\slnAlmacen\Portafolio\Vista\Logo\Logo.png";
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open))
                        {
                            var png = Image.GetInstance(System.Drawing.Image.FromStream(fs),
                                ImageFormat.Png);
                            png.ScalePercent(18f);
                            png.SetAbsolutePosition(15f, 705f);
                            doc.Add(png);
                        }

                        var spacer = new Paragraph("")
                        {
                            SpacingBefore = 10f,
                            SpacingAfter = 10f,
                        };
                        doc.Add(spacer);
                        doc.Add(spacer);

                        var headerTable = new PdfPTable(new[] { .75f, 2f })
                        {
                            HorizontalAlignment = Left,
                            WidthPercentage = 75,
                            DefaultCell = { MinimumHeight = 22f }
                        };

                        Proveedor proveedor = new Proveedor();
                        proveedor = proveedor.ObtenerProveedor(orden.Proveedor.Rut);

                        headerTable.AddCell("Fecha");
                        headerTable.AddCell(DateTime.Now.Date.ToShortDateString());
                        headerTable.AddCell("Proveedor");
                        headerTable.AddCell(proveedor.Nombre);
                        headerTable.AddCell("Rut");
                        headerTable.AddCell(proveedor.Rut + "-" + proveedor.Dv);

                        doc.Add(headerTable);
                        doc.Add(spacer);

                        //grdDetalleOrden.Columns["NUMEROORDEN"].

                        var columnWidths = new[] { 1f, 1.5f, 0.5f, 0.75f };

                        var table = new PdfPTable(columnWidths)
                        {
                            HorizontalAlignment = Left,
                            WidthPercentage = 100,
                            DefaultCell = { MinimumHeight = 22f }
                        };

                        var cell = new PdfPCell(new Phrase("Detalles de la orden de pedido"))
                        {
                            Colspan = 4,
                            HorizontalAlignment = 1, //0=Left, 1=Centro ,2=Rigth
                            MinimumHeight = 30f
                        };

                        table.AddCell(cell);

                        //headers

                        grdDetalleOrden.Columns.RemoveAt(0);
                        grdDetalleOrden.Columns.RemoveAt(0);
                        grdDetalleOrden.Columns.OfType<DataGridViewColumn>().ToList().
                            ForEach(c => table.AddCell(c.Name));

                        //rows
                        grdDetalleOrden.Rows.OfType<DataGridViewRow>().ToList().
                            ForEach(r =>
                            {
                                var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                                cells.ForEach(c => table.AddCell(c.Value.ToString()));
                            });
                        doc.Add(table);
                        doc.Add(spacer);

                        var totalTable = new PdfPTable(new[] { 2f, 1f })
                        {
                            HorizontalAlignment = 2,
                            WidthPercentage = 75,
                            DefaultCell = { MinimumHeight = 22f }
                        };

                        totalTable.AddCell("TOTAL PEDIDO:");
                        totalTable.AddCell(orden.Total.ToString()); 

                        doc.Add(totalTable);
                        doc.Add(spacer);

                        doc.Close();

                        EnviarEmailAlProveedor(orden, ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw;
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
        private void EnviarEmailAlProveedor(OrdenPedido orden, string ruta)
        {
            bool correoEnviado = orden.EnviarCorreoOrdenPedido(orden, ruta);
            if (correoEnviado)
            {
                MessageBox.Show("Se ha enviado la orden correctamente.");
            }
        }
        #endregion

        #region MetodoGrilla
        private void grdOrden_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _numeroOrdenSeleccionado = int.Parse(this.grdOrden[0, e.RowIndex].Value.ToString());
                CargarGrillaDetalleOrden(_numeroOrdenSeleccionado);
            }
        }
        #endregion

        #region Eventos
        private void cmbProveedores_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbProveedores.SelectedValue != null)
            {
                OrdenPedido ordenPedido = new OrdenPedido();
                grdOrden.DataSource = ordenPedido.ListarOrdenPedidoPorProveedor((int)cmbProveedores.SelectedValue);
                LimpiarGrillaDetalle();
                EsconderColumnasAutogeneradas();
            }
        }

        #endregion


    }
}
