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
    public partial class frmEstadistica : Form
    {
        public frmEstadistica()
        {
            InitializeComponent();
        }

        private void frmEstadistica_Load(object sender, EventArgs e)
        {
            cboxForma.Items.Add("Preferencias");
            cboxProducto.Items.Add("Stock categorias");
            cboxCliente.Items.Add("Más frecuentes");
            cboxDinero.Items.Add("Del mes");
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string rutaAyuda = @"\Ayuda\Ayuda.chm";
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            string ayudaPath = projectDirectory + rutaAyuda;
            Help.ShowHelp(this, ayudaPath, "Estadistica.htm");
        }

        private void VerForma_Click(object sender, EventArgs e)
        {
            if (cboxForma.Text.Equals(""))
            {
                MessageBox.Show("Eliga una Opción");
            }
            else
            {
                if (cboxForma.Text.Equals("Preferencias"))
                {
                    Form Informe1 = new InfMedioFrecuente();
                    Informe1.Show();
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
                if (cboxCliente.Text.Equals("Más frecuentes"))
                {
                    Form Informe1 = new InfClienteFrecuente();
                    Informe1.Show();
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
                if (cboxDinero.Text.Equals("Del mes"))
                {
                    Form Informe1 = new InfDelMes();
                    Informe1.Show();
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
                if (cboxProducto.Text.Equals("Stock categorias"))
                {
                    Form Informe1 = new InfStock();
                    Informe1.Show();
                }

            }
        }
    }
}
