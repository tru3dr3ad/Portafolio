using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmInforme : Form
    {
        public frmInforme()
        {
            InitializeComponent();
        }

        private void frmInforme_Load(object sender, EventArgs e)
        {
            cboxForma.Items.Add("Débito");
            cboxForma.Items.Add("Crédito");
            cboxForma.Items.Add("Efectivo");
            cboxProducto.Items.Add("Vendidos");
            cboxCliente.Items.Add("Morosos");
            cboxCliente.Items.Add("Que más debe");
            cboxDinero.Items.Add("Fiado");
            cboxDinero.Items.Add("Del día");
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Informes.htm");
        }

        private void VerForma_Click(object sender, EventArgs e)
        {
            if (cboxForma.Text.Equals(""))
            {
                MessageBox.Show("Eliga una Opción");
            }
            else
            {
                if (cboxForma.Text.Equals("Débito"))
                {
                    Form Informe1 = new InfMedioDebito();
                    Informe1.Show();
                }
                if (cboxForma.Text.Equals("Crédito"))
                {
                    Form Informe2 = new InfMedioCredito();
                    Informe2.Show();
                }
                if (cboxForma.Text.Equals("Efectivo"))
                {
                    Form Informe3 = new InfMedioEfectivo();
                    Informe3.Show();
                }
            }
        }

        private void VerCliente_Click(object sender, EventArgs e)
        {
            if (cboxCliente.Text.Equals(""))
            {
                MessageBox.Show("Eliga una Opción");
            }
            else
            {
                if (cboxCliente.Text.Equals("Morosos"))
                {
                    Form Informe1 = new InfMorosos();
                    Informe1.Show();
                }
                if (cboxCliente.Text.Equals("Que más debe"))
                {
                    Form Informe2 = new InfClienteDeuda();
                    Informe2.Show();
                }
            }
        }

        private void VerDinero_Click(object sender, EventArgs e)
        {
            if (cboxDinero.Text.Equals(""))
            {
                MessageBox.Show("Eliga una Opción");
            }
            else
            {
                if (cboxDinero.Text.Equals("Fiado"))
                {
                    Form Informe1 = new InfFiado();
                    Informe1.Show();
                }
                if (cboxDinero.Text.Equals("Del día"))
                {
                    Form Informe2 = new InfCaja();
                    Informe2.Show();
                }
            }
        }

        private void VerProducto_Click(object sender, EventArgs e)
        {
            if (cboxProducto.Text.Equals(""))
            {
                MessageBox.Show("Eliga una Opción");
            }
            else
            {
                if (cboxProducto.Text.Equals("Vendidos"))
                {
                    Form Informe1 = new InfProductoMas();
                    Informe1.Show();
                }
                
            }
        }
    }
}
