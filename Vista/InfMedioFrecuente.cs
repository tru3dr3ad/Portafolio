﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class InfMedioFrecuente : Form
    {
        public InfMedioFrecuente()
        {
            InitializeComponent();
        }

        private void InfMedioFrecuente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsMedioFrecuente.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DsMedioFrecuente.DataTable1);


            this.reportViewer1.RefreshReport();
        }
    }
}
