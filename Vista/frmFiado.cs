using Controlador;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmFiado : Form
    {
        int _numeroBoleta = 0;
        int _idAbono = 0;
        public frmFiado()
        {
            InitializeComponent();
            CargarComboboxCliente();
            CargarGrillaVentasFiadas();
        }

        #region Metodos
        private void CargarGrillaVentasFiadas()
        {
            Boleta boleta = new Boleta();
            grdVentaFiadas.DataSource = boleta.ListarBoletasPorMedioPagoFiado();
            OcultarColumnasAutogeneradas();
            CambioNombreColumnaGrilla();
        }
        private void CargarGrillaAbonoPorBoleta(int nroBoleta)
        {
            Abono abono = new Abono();
            grdAbono.DataSource = abono.ListarAbonosPorBoleta(nroBoleta);
            OcultarColumnasAutogeneradasDetalle();
            CambioNombreColumnaGrillaDetalle();
        }
        private void OcultarColumnasAutogeneradas()
        {
            grdVentaFiadas.Columns["RUN_USUARIO"].Visible = false;
            grdVentaFiadas.Columns["RUN_CLIENTE"].Visible = false;
            grdVentaFiadas.Columns["IDMEDIOPAGO"].Visible = false;
            grdVentaFiadas.Columns["IDESTADO"].Visible = false;
        }
        private void OcultarColumnasAutogeneradasDetalle()
        {
            grdAbono.Columns["BOLETA_NUMEROBOLETA"].Visible = false;
        }
        private void CargarComboboxCliente()
        {
            Controlador.Cliente cliente = new Controlador.Cliente();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Run";
            cmbCliente.DataSource = cliente.ListarComboboxFiado();
        }
        public void MostrarDeuda(int numeroBoleta)
        {
            Abono abono = new Abono();
            decimal deuda = abono.ObtenerDeuda(numeroBoleta);
            txtDeuda.Text = deuda.ToString();
        }
        private void MostrarMontoAbono(int idAbono)
        {
            Abono abono = new Abono();
            abono = abono.ObtenerAbono(idAbono);
            decimal montoAbono = abono.Total;
            txtMontoAbono.Text = montoAbono.ToString();
        }
        private void DatosClienteBoleta(int nroBoleta)
        {
            Boleta boleta = new Boleta();
            boleta = boleta.ObtenerBoleta(nroBoleta);
            Cliente cliente = new Cliente();
            cliente = cliente.ObtenerCliente(boleta.Cliente.Run);
            string run = boleta.Cliente.Run.ToString() + "-" + cliente.Dv.ToString();
            txtRunCliente.Text = run;
            cmbCliente.SelectedValue = boleta.Cliente.Run;
        }
        private void CambioNombreColumnaGrilla()
        {
            grdVentaFiadas.Columns["NUMERO"].HeaderText = "N°";
            grdVentaFiadas.Columns["FECHA_CREACION"].HeaderText = "FECHA VENTA";
            grdVentaFiadas.Columns["MEDIO_PAGO"].HeaderText = "MEDIO PAGO";
            grdVentaFiadas.Columns["NOMBRE_CLIENTE"].HeaderText = "CLIENTE";
            grdVentaFiadas.Columns["NOMBRE_VENDEDOR"].HeaderText = "VENDEDOR";
            grdVentaFiadas.Columns["DESCRIPCION"].HeaderText = "ESTADO";
            grdVentaFiadas.Columns["NOMBRE_CLIENTE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void CambioNombreColumnaGrillaDetalle()
        {
            grdAbono.Columns["IDABONO"].HeaderText = "N° ABONO";
            grdAbono.Columns["FECHAABONO"].HeaderText = "FECHA DEL ABONO";
            grdAbono.Columns["FECHALIMITE"].HeaderText = "FECHA LIMITE DE PAGO";
            grdAbono.Columns["FECHALIMITE"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void LimpiarMontos()
        {
            rdbDeudaParcial.Enabled = true;
            rdbDeudaTotal.Enabled = true;
            rdbDeudaTotal.Checked = false;
            rdbDeudaParcial.Checked = false;
            txtMontoAbono.Clear();
        }
        private void LimpiarGrillaAbono()
        {
            grdAbono.DataSource = null;
            txtMontoAbono.Clear();
        }
        private void PersonalizarAbono()
        {
            rdbDeudaParcial.Enabled = false;
            rdbDeudaTotal.Enabled = false;
            txtDeuda.Text = "--";
            txtMontoAbono.Enabled = true;
        }
        private void CargarLabelDeudaTotal()
        {
            Boleta boleta = new Boleta();
            if ((int)cmbCliente.SelectedValue > 0)
            {
                decimal deuda = 0;
                deuda = boleta.CalcularDeudaTotal((int)cmbCliente.SelectedValue);
                lblDeudaTotal.Text = deuda.ToString();
            }
        }
        public void EvaluarDeudaParaEstadoFiador(int numeroBoleta)
        {
            Boleta boleta = new Boleta();
            boleta = boleta.ObtenerBoleta(numeroBoleta);
            decimal deuda = boleta.CalcularDeudaTotal(boleta.Cliente.Run);
            Cliente cliente = new Cliente();
            cliente = cliente.ObtenerCliente(boleta.Cliente.Run);
            if (deuda == 0)
            {
                bool clientePagado = cliente.CambiarEstadoDeudaPagada(cliente.Run);
                if (clientePagado)
                {
                    MessageBox.Show("La deuda ha sido pagada por completo");
                }
            }
            else if (deuda > 0)
            {
                bool clienteNoHaPagado = cliente.CambiarEstadoDeudaImpaga(cliente.Run);
                if (clienteNoHaPagado)
                {
                    MessageBox.Show("Ojo! Aun queda por pagar $" + deuda + ", tiene hasta "
                    + boleta.FechaCreacion.AddMonths(1).ToShortDateString() + " para pagar!");
                }
            }
        }
        #endregion

        #region Metodos de la clase
        public void BuscarBoletasPorNombreCliente()
        {
            string nombre = txtBuscarUsuario.Text.ToUpper();
            Boleta boleta = new Boleta();
            if (nombre == "")
            {
                grdVentaFiadas.DataSource = boleta.ListarBoletasPorMedioPago(4);
            }
            else
            {
                grdVentaFiadas.DataSource = boleta.ListarBoletasPorNombreClienteFiador(nombre);
            }
            txtBuscarUsuario.Clear();
            OcultarColumnasAutogeneradas();
        }
        public void AgregarAbono()
        {
            if (!string.IsNullOrEmpty(txtDeuda.Text) && txtDeuda.Text != "--")
            {
                if (!string.IsNullOrEmpty(txtMontoAbono.Text))
                {
                    if (int.Parse(txtMontoAbono.Text) > 0)
                    {
                        if (int.Parse(txtMontoAbono.Text) <= int.Parse(txtDeuda.Text))
                        {
                            DateTime fechaAbono = DateTime.Now.Date;
                            int montoAbono = int.Parse(txtMontoAbono.Text);
                            Boleta boleta = new Boleta();
                            boleta = boleta.ObtenerBoleta(_numeroBoleta);
                            DateTime fechaLimite = boleta.FechaCreacion.AddMonths(1);

                            Abono abono = new Abono(boleta, montoAbono, fechaAbono, fechaLimite);
                            if (abono.AgregarAbono())
                            {
                                int idAbono = abono.ObtenerIdMaximoAbono();
                                CargarGrillaAbonoPorBoleta(boleta.Numero);
                                MessageBox.Show("Abono N°" + idAbono + " agregado.");
                                EvaluarDeudaParaEstadoFiador(boleta.Numero);
                                CargarLabelDeudaTotal();
                                txtDeuda.Clear();
                                _numeroBoleta = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Monto del abono no puede ser mayor a lo adeudado.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El monto ingresado no puede ser $0.");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningun monto ingresado para agregar");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una boleta para pagar primero");
            }
        }
        private void ModificarAbono()
        {
            if (!string.IsNullOrEmpty(txtMontoAbono.Text))
            {
                if (int.Parse(txtMontoAbono.Text) > 0)
                {
                    Abono abono = new Abono();
                    Boleta boleta = new Boleta();
                    abono = abono.ObtenerAbono(_idAbono);
                    boleta = boleta.ObtenerBoleta(abono.Boleta.Numero);
                    decimal deuda = abono.ObtenerDeuda(boleta.Numero);
                    deuda = deuda + abono.Total;
                    if (abono != null)
                    {
                        if (decimal.Parse(txtMontoAbono.Text) <= deuda)
                        {
                            abono.Total = decimal.Parse(txtMontoAbono.Text);
                            bool estaModificado = abono.ModificarAbono(abono);
                            if (estaModificado)
                            {
                                MessageBox.Show("El abono ha sido modificado");
                                EvaluarDeudaParaEstadoFiador(abono.Boleta.Numero);
                                CargarLabelDeudaTotal();
                                txtDeuda.Clear();
                                _idAbono = 0;
                            }
                            else
                            {
                                MessageBox.Show("Error al modificar abono");
                            }
                        }
                        else if (decimal.Parse(txtMontoAbono.Text) == abono.Total)
                        {
                            MessageBox.Show("El monto ingresado es igual al monto guardado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ningun abono para modificar");
                    }
                }
                else
                {
                    MessageBox.Show("El monto ingresado no puede ser $0.");
                }
            }
            else
            {
                MessageBox.Show("No hay ningun monto ingresado para modificar");
            }
        }
        private void EliminarAbono()
        {
            Abono abono = new Abono();
            if (_idAbono>0)
            {
                abono = abono.ObtenerAbono(_idAbono);
                if (abono != null)
                {
                    bool estaEliminado = abono.EliminarAbono(abono.Id);
                    if (estaEliminado)
                    {
                        MessageBox.Show("El abono ha sido eliminado.");
                        EvaluarDeudaParaEstadoFiador(abono.Boleta.Numero);
                        CargarLabelDeudaTotal();
                        _idAbono = 0;
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar el abono");
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun abono para eliminar");
                }
            }
        }

        #endregion

        #region Botones
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarBoletasPorNombreCliente();
            LimpiarGrillaAbono();
            LimpiarMontos();
        }
        private void btnAgregarAbono_Click(object sender, EventArgs e)
        {
            AgregarAbono();
            LimpiarMontos();
        }
        private void btnModificarAbono_Click(object sender, EventArgs e)
        {
            ModificarAbono();
            CargarGrillaAbonoPorBoleta(_numeroBoleta);
            LimpiarMontos();
        }
        private void btnEliminarAbono_Click(object sender, EventArgs e)
        {
            EliminarAbono();
            CargarGrillaAbonoPorBoleta(_numeroBoleta);
            LimpiarMontos();
        }
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Fiados.htm");
        }

        #endregion

        #region Eventos
        private void rdbDeudaTotal_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeudaTotal.Checked)
            {
                txtMontoAbono.Enabled = false;
                txtMontoAbono.Text = txtDeuda.Text;
            }
        }
        private void rdbDeudaParcial_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeudaParcial.Checked)
            {
                txtMontoAbono.Enabled = true;
                txtMontoAbono.Clear();
            }
        }
        private void cmbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedValue != null)
            {
                Boleta boleta = new Boleta();
                grdVentaFiadas.DataSource = boleta.ListarBoletasPorClienteFiador((int)cmbCliente.SelectedValue);
                Cliente cliente = new Cliente();
                cliente = cliente.ObtenerCliente((int)cmbCliente.SelectedValue);
                string run = cmbCliente.SelectedValue.ToString() + "-" + cliente.Dv.ToString();
                txtRunCliente.Text = run;
                LimpiarMontos();
                LimpiarGrillaAbono();
                CargarLabelDeudaTotal();
            }
        }
        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtMontoAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtBuscarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        #endregion

        #region Metodos Grilla
        private void grdVentaFiadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                _numeroBoleta = int.Parse(grdVentaFiadas.Rows[rowIndex].Cells[0].Value.ToString());
                MostrarDeuda(_numeroBoleta);
                DatosClienteBoleta(_numeroBoleta);
                CargarGrillaAbonoPorBoleta(_numeroBoleta);
                LimpiarMontos();
            }
        }
        private void grdAbono_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                _idAbono = int.Parse(grdAbono.Rows[rowIndex].Cells[0].Value.ToString());
                MostrarMontoAbono(_idAbono);
                PersonalizarAbono();
            }
        }

        #endregion

        
    }
}
