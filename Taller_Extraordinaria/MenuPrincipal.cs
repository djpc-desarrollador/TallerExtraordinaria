using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Software
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestionAsociados a = new GestionAsociados();
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FReservas res = new FReservas();
            res.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FPagoReserva pa = new FPagoReserva();
            pa.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VistaTipoArea vista = new VistaTipoArea();
            vista.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            VistaArea vista = new VistaArea();
            vista.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VistaTipoAsociados vista = new VistaTipoAsociados();
            vista.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VistaProfesor vista = new VistaProfesor();
            vista.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaDeporte vista = new VistaDeporte();
            vista.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VistaCurso vista = new VistaCurso();
            vista.ShowDialog();
        }
    }
}
