using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_Extraordinaria.Datos;

namespace Software
{
    public partial class FPagoReserva : Form
    {
        NReserva nReserva = new NReserva();
        NPagoReserva nPagoReserva = new NPagoReserva();
        PagoReserva pPago = new PagoReserva();
        
        public FPagoReserva()
        {
            InitializeComponent();
        }

        

        // ARMAR ENTIDAD DE PAGO
        private PagoReserva ArmarEntidadPago()
        {
            try
            {
                this.pPago.Fecha = dtpFechaActual.Value;
                this.pPago.Motivo = txtPagoMotivo.Text;
                this.pPago.Observacion = txtPagoObserv.Text;
                this.pPago.Monto = Convert.ToDecimal(txtMonto.Text);
                this.pPago.Eliminado = false;
                this.pPago.IdReserva = Convert.ToInt32(txtReservaCod.Text);
            }
            catch 
            {
                MessageBox.Show("ERROR AL CARGAR LOS DATOS. VERIFIQUE LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return pPago;
        }

        private void ClearTextBoxes(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    ClearTextBoxes(c);
                }
            }
        }

        private void ReadOnlyTextBoxex(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ReadOnly = true; 
                }

                if (c.HasChildren)
                {
                    ReadOnlyTextBoxex(c);
                }
            }
        }
        private void txtCodReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    Reserva atext = nReserva.DevolverReserva(Convert.ToInt32(txtCodReserva.Text)) ;
                    txtReservaCod.Text = Convert.ToString(atext.Codigo);
                    txtArea.Text = atext.Area.Descripcion;
                    txtCedulaIdentidad.Text = atext.CedulaIdentidad;
                    txtGarantia.Text = Convert.ToString(atext.Garantia);
                    txtNombreAsoc.Text = atext.Nombre;
                    txtApellido1.Text = atext.Apellido1;
                    dtpFechaReserva.Value = atext.Fecha.Value;
                    txtObservacion.Text = atext.Observacion;
                }
                catch (Exception)
                {
                    MessageBox.Show("NO SE ENCONTRO LA RESERVA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMonto.Text != "")
                {
                    nPagoReserva.RegistrarPago(ArmarEntidadPago());
                    MessageBox.Show("PAGO REALIZADO CON EXITO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel.PerformClick();
                }
            }
            catch 
            {
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodPago.ReadOnly == true)
            {
                txtCodPago.ReadOnly = false;
                btnEliminado.Enabled = true; ;
            }
            else 
            {
            btnPagar.Enabled = false;
            PagoReserva pago =  nPagoReserva.DevolverPagoReserva (Convert.ToInt32(txtCodPago.Text));
            if (pago != null)
            {
                txtReservaCod.Text = Convert.ToString(pago.Reserva.Codigo);
                txtArea.Text = pago.Reserva.Area.Descripcion;
                txtCedulaIdentidad.Text = pago.Reserva.CedulaIdentidad;
                txtGarantia.Text = Convert.ToString(pago.Reserva.Garantia);
                txtNombreAsoc.Text = pago.Reserva.Nombre;
                txtApellido1.Text = pago.Reserva.Apellido1;
                dtpFechaReserva.Value = pago.Reserva.Fecha.Value;
                txtObservacion.Text = pago.Reserva.Observacion;
                //llenar info pago

                txtCodReserva.Text = Convert.ToString(pago.IdReserva);
                txtPagoMotivo.Text = pago.Motivo;
                txtObservacion.Text = pago.Motivo;
                txtMonto.Text = Convert.ToString(pago.Monto);
                txtCodPago.ReadOnly = true;

                //ReadOnlyTextBoxex(this);
            }
            else 
            {
                MessageBox.Show("CODIGO DE PAGO INCORRECTO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
            
            
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
            txtPagoMotivo.Text = "PAGO RESERVA";
            txtCodPago.ReadOnly = true;
            btnEliminado.Enabled = true;
            btnPagar.Enabled = true;

        }
    }
}
