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
    public partial class FReservas : Form
    {
        NAsociado nAsociado = new NAsociado();
        NArea narea = new NArea();
        NReserva nReserva = new NReserva();
        Reserva rReserva = new Reserva();
        public FReservas()
        {
            InitializeComponent();
        }
        private void FReservas_Load(object sender, EventArgs e)
        {
            this.cmbArea.DataSource = this.narea.ListarTodos();
            this.cmbArea.DisplayMember = "Descripcion";
            this.cmbArea.ValueMember = "Codigo";
            this.horaDeInicio.ValidatingType = typeof(TimeSpan);
            this.horaDeFin.ValidatingType = typeof(TimeSpan);
        }


        // Armar Entidad Reserva
        public Reserva ArmarEntidadReserva() 
        {
            try
            {
                this.rReserva.Nombre = txtNombreAsoc.Text;
                this.rReserva.Apellido1 = txtApellido1.Text;
                this.rReserva.Apellido2 = txtApellido2.Text;
                this.rReserva.CedulaIdentidad = txtCedulaIdentidad.Text;
                this.rReserva.CodigoArea = Convert.ToInt32(cmbArea.SelectedValue);
                this.rReserva.Fecha = dtpFechaReserva.Value.Date;
                //string horainicio = Convert.ToString(nupHoraInicio.Value) + ":" + Convert.ToString(nupMinutoI.Value);
                //string horafinal = Convert.ToString(nupHoraFin.Value) + ":" + Convert.ToString(nupMinutoI.Value);
                this.rReserva.HoraInicio = TimeSpan.Parse(this.horaDeInicio.Text);
                this.rReserva.HoraFin = TimeSpan.Parse(this.horaDeFin.Text);
                this.rReserva.TelefonoRef = txtTelefono.Text;
                this.rReserva.Observacion = txtObservacion.Text;
                this.rReserva.Pagada = false;
                this.rReserva.Eliminado = false;
                if (rbParticular.Checked == false)
                {
                    this.rReserva.IdAsociado = Convert.ToInt32(txtIdInterno.Text);
                    this.rReserva.CodAsociado = Convert.ToInt32(txtCodigoAso.Text);
                }
                else 
                {
                    this.rReserva.IdAsociado = 0;
                    this.rReserva.CodAsociado = 0;
                }

                if (rbSi.Checked == true)
                {
                    this.rReserva.Garantia = Convert.ToDecimal(txtGarantia.Text);
                }
                else
                {
                    this.rReserva.Garantia = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("VERIFIQUE LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            return this.rReserva;
        }

        // Pasar Datos Busqueda
        private void PasarDatosReserva() 
        {
            try
            {
                txtCodReserva.Text = Convert.ToString(this.rReserva.Codigo);
                txtNombreAsoc.Text = this.rReserva.Nombre;
                txtApellido1.Text =this.rReserva.Apellido1;
                txtApellido2.Text = this.rReserva.Apellido2;
                txtCedulaIdentidad.Text = this.rReserva.CedulaIdentidad;
                cmbArea.SelectedValue = this.rReserva.CodigoArea;
                dtpFechaReserva.Value = this.rReserva.Fecha.Value;
                nupHoraInicio.Value = this.rReserva.HoraInicio.Value.Hours;
                nupMinutoI.Value = this.rReserva.HoraInicio.Value.Minutes;
                nupHoraFin.Value = this.rReserva.HoraFin.Value.Hours;
                nupMinutoFin.Value = this.rReserva.HoraFin.Value.Minutes;
                txtTelefono.Text  = this.rReserva.TelefonoRef ;
                txtObservacion.Text = this.rReserva.Observacion;
                txtCodigoAso.Text = Convert.ToString(this.rReserva.CodAsociado);
                txtIdInterno.Text = Convert.ToString(this.rReserva.IdAsociado);
                txtGarantia.Text = Convert.ToString(this.rReserva.Garantia);
                if (this.rReserva.IdAsociado == 0)
                {
                    this.rbParticular.Checked = true;
                }
                else 
                {
                    this.rbAsociado.Checked = true;
                }
                if (this.rReserva.Garantia > 0)
                {
                    rbSi.Checked = true;
                }
                else 
                {
                    rbNo.Checked = true;
                }
            }
            catch
            {
                MessageBox.Show("NO SE PUDO CARGAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        // LIMPIAR TAP RESERVA
        private void LimpiarTapReserva ()
        {
            try
            {
                txtCodReserva.Text = string.Empty;
                txtNombreAsoc.Text = string.Empty;
                txtApellido1.Text = string.Empty;
                txtApellido2.Text = string.Empty;
                txtCedulaIdentidad.Text = string.Empty;
                cmbArea.SelectedValue = 1;
                nupHoraInicio.Value = 1;
                nupMinutoI.Value = 0;
                nupHoraFin.Value = 1;
                nupMinutoFin.Value = 0;
                txtTelefono.Text = string.Empty;
                txtObservacion.Text = string.Empty ;
                txtCodigoAso.Text = string.Empty;
                txtIdInterno.Text = string.Empty;
                txtGarantia.Text = string.Empty;
                this.rbParticular.Checked = false;
                this.rbAsociado.Checked = false;
                this.rbSi.Checked = false;        
                this.rbNo.Checked = false;
                // ReadOnly los campos que fueron habilitados
                txtNombreAsoc.ReadOnly = true;
                txtApellido1.ReadOnly = true;
                txtApellido2.ReadOnly = true;
                txtCedulaIdentidad.ReadOnly = true;
                
            }
            catch
            {
                MessageBox.Show("ERROR AL LIMPIAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // LIMPIAR TAB BUSQUEDA
        private void LimpiarTapBusqueda()
        {
            try
            {
                txt1CodigoReserva.Text = string.Empty;
                txt1Nombre.Text = string.Empty;
                txt1Apellido1.Text = string.Empty;
                txt1Apellido2.Text = string.Empty;
                txt1Cedula.Text = string.Empty;
                txt1Codigo.Text = string.Empty;
                txt1Interno.Text = string.Empty;
                dgvResult.DataSource = null;
            }
            catch
            {
                MessageBox.Show("ERROR AL LIMPIAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //Pasar Datos Busqueda
        private void PasarDatosBusqueda()
        {
            try
            {
                txt1Nombre.Text = this.rReserva.Nombre;
                txt1Apellido1.Text = this.rReserva.Apellido1;
                txt1Apellido2.Text = this.rReserva.Apellido2;
                txt1Cedula.Text = this.rReserva.CedulaIdentidad;
                dtp1FechaReserva.Value = this.rReserva.Fecha.Value;
                txt1Codigo.Text = Convert.ToString(this.rReserva.CodAsociado);
                txt1Interno.Text = Convert.ToString(this.rReserva.IdAsociado);
                txt1CodigoReserva.Text = Convert.ToString(this.rReserva.Codigo);
            }
            catch
            {
                MessageBox.Show("NO SE PUDO CARGAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        // Validar Formulario
        private void rbAsociado_Click(object sender, EventArgs e)
        {
            rbParticular.Checked = false;
            rbAsociado.Checked = true;

            txtNombreAsoc.ReadOnly = true;
            txtApellido2.ReadOnly = true;
            txtApellido1.ReadOnly = true;
            txtCodigoAso.ReadOnly = false;
            txtCedulaIdentidad.ReadOnly = false;
            txtTelefono.ReadOnly = false;

        }

        private void rbParticular_Click(object sender, EventArgs e)
        {
            rbAsociado.Checked = false;
            rbParticular.Checked = true;
            txtNombreAsoc.ReadOnly = false;
            txtApellido2.ReadOnly = false;
            txtApellido1.ReadOnly = false;
            txtCodigoAso.ReadOnly = true;
            txtCedulaIdentidad.ReadOnly = false;
            txtTelefono.ReadOnly = false;
        }

        private void rbNo_Click(object sender, EventArgs e)
        {
            rbSi.Checked = false;
            rbNo.Checked = true;

            txtGarantia.ReadOnly = true;
        }

        private void rbSi_Click(object sender, EventArgs e)
        {
            rbNo.Checked = false;
            rbSi.Checked = true;

            txtGarantia.ReadOnly = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva a = this.ArmarEntidadReserva();
                this.nReserva.VerificarValidezDeLaReserva(a);
                nReserva.RegistrarReserva(a);
                MessageBox.Show("RESERVA REGISTRADA CON EXITO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.LimpiarTapReserva();
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR AL GUARDAR LA INFORMACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void txtCodigoAso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                  Asociado atext =  nAsociado.BuscarInformacionBasica(Convert.ToInt32(txtCodigoAso.Text), txtCedulaIdentidad.Text);
                  txtNombreAsoc.Text = atext.Nombre;
                  txtApellido1.Text = atext.Apellido1;
                  txtApellido2.Text = atext.Apellido2;
                  txtCedulaIdentidad.Text = Convert.ToString(atext.CedulaIdentidad);
                  txtIdInterno.Text = Convert.ToString(atext.Id);
                  txtCodigoAso.Text = Convert.ToString(atext.Codigo);
                }
                catch (Exception)
                {
                    MessageBox.Show("NO SE ENCONTRO EL ASOCIADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = dtp1FechaReserva.Value.ToShortDateString();
                dgvResult.DataSource = nReserva.BusquedaReserva(txt1Codigo.Text, fecha, txt1Nombre.Text, txt1Apellido1.Text, txt1Apellido2.Text, txt1Cedula.Text);
                dgvResult.Columns.Remove("Area");
                dgvResult.Columns.Remove("Asociado");
                dgvResult.Columns.Remove("PagoReserva");
            }
            catch (Exception)
            {
                MessageBox.Show("NO SE ENCONTRARON RESERVAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                rbAsociado.Enabled = true;
                rbParticular.Enabled = true;
                txtCodReserva.Text = Convert.ToString(nReserva.SiguienteReserva());
                btnRegister.Enabled = true;
            }
            catch (Exception) 
            {
                MessageBox.Show("NO SE PUEDE CARGAR CODIGO DE RESERVA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            }

        private void txtCedulaIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                try
                {
                    Asociado atext = nAsociado.BuscarInformacionBasica(Convert.ToInt32(txtCedulaIdentidad .Text), txtCedulaIdentidad.Text);
                    txtNombreAsoc.Text = atext.Nombre;
                    txtApellido1.Text = atext.Apellido1;
                    txtApellido2.Text = atext.Apellido2;
                    txtCedulaIdentidad.Text = Convert.ToString(atext.CedulaIdentidad);
                    txtIdInterno.Text = Convert.ToString(atext.Id);
                    txtCodigoAso.Text = Convert.ToString(atext.Codigo);
                }
                catch (Exception)
                {
                    MessageBox.Show("NO SE ENCONTRO EL ASOCIADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dgvResult_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.rReserva = this.nReserva.DevolverReserva(Convert.ToInt32(dgvResult.CurrentRow.Cells[0].Value));
                Global.reservaGlobal = this.rReserva;
                this.PasarDatosBusqueda();
            }
            catch
            {
                MessageBox.Show("NO SE PUEDE CARGAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnPasarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                this.PasarDatosReserva();
                this.LimpiarTapBusqueda();
                this.tabControl1.SelectTab(1);
                //Activar Botones
                this.btnEdit.Enabled = true;
                this.btnRegister.Enabled = false;
            }
            catch 
            {
                MessageBox.Show("NO SE PUEDE CARGAR LOS DATOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarTapBusqueda();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LimpiarTapReserva();
            this.btnRegister.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnSalvar.Enabled = false;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnSalvar.Enabled = true;
            this.btnEdit.Enabled = false;
            this.rbAsociado.Enabled = false;
            this.rbParticular.Enabled = false;
            this.txtTelefono.ReadOnly = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                nReserva.ModificarReserva(this.ArmarEntidadReserva());

                LimpiarTapReserva();
                btnCancel.PerformClick();
                MessageBox.Show("CAMBIOS GUARDADOS CON EXITO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch 
            {
                MessageBox.Show("ERROR AL ACTUALIZAR LA INFORMACION. VUELVA A INTENTARLO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var a = this.ArmarEntidadReserva();
            List<Reserva> b = this.nReserva.VerificarValidezDeLaReserva(a);
            if (b.Count > 0)
            {
                string mensaje = "Hay choque de horas con otras reservas.\n";
                foreach (Reserva c in b) {
                    mensaje += string.Format("({3}-{4}) {0} {1} {2}\n", c.Apellido1, c.Apellido2, c.Nombre, c.HoraInicio.Value, c.HoraFin.Value);
                }
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("La reserva es posible...");
            }
        }

        private void txtApellido2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
