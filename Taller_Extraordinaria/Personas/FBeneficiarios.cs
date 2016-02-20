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
    public partial class FBeneficiarios : Form
    {
        private Beneficiario bBeneficiario = new Beneficiario();
        private NParentesco nParentesco = new NParentesco();
        private NBeneficiario nBeneficiario = new NBeneficiario();

        public FBeneficiarios()
        {
            InitializeComponent();
        }

        private void frmBeneficiario_Load(object sender, EventArgs e)
        {
            try
            {
                cmbParentesco.DataSource = nParentesco.listarParentescos();
                cmbParentesco.ValueMember = "Id";
                cmbParentesco.DisplayMember = "Descripcion";
                txtCodigoAso.Text = Convert.ToString(Global.asociadoGlobal.Codigo);
                txtNombreAsoc.Text = Global.asociadoGlobal.Nombre;
                txtApellidoPAsociado.Text = Global.asociadoGlobal.Apellido1;
                txtApellidoMAsociado.Text = Global.asociadoGlobal.Apellido2;
                txtIdInterno.Text = Convert.ToString(Global.asociadoGlobal.Id);
                this.CargarBeneficiarios();
                this.ReadOnlyCampos();
            }
            catch 
            {
                MessageBox.Show("NECESITA CARGAR UN ASOCIADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
         
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string strParentesco = cmbParentesco.Text;
            if (this.ValidarFormulario())
            {
                if (this.ValidarEdadParentesco())
                {
                    if (this.ExisteElParentesco())
                    {
                        bool bregistro = nBeneficiario.RegistrarBeneficiario(this.ArmarEntidadBeneficiario());
                        if (bregistro == true)
                        {
                            MessageBox.Show("REGISTRO REALIZADO CON EXITO", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.LimpiarCampos();
                            this.ReadOnlyCampos();
                            this.CargarBeneficiarios();
                        }
                    }
                    else
                    {
                        MessageBox.Show("YA SE ENCUENTRA REGISTRADO UN " + strParentesco + " PARA ESTE ASOCIADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("EL " + strParentesco + " NO CUMPLE CON LA EDAD NECESARIA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ARMAR ENTIDAD BENEFICIARIO
        private Beneficiario ArmarEntidadBeneficiario()
        {
            try
            {
                bBeneficiario.Nombre = txtNombre.Text;
                bBeneficiario.Apellido1 = txtApellidoPaterno.Text;
                bBeneficiario.Apellido2 = txtApellidoMaterno.Text;
                bBeneficiario.IdAsociado = Convert.ToInt32(txtIdInterno.Text);
                bBeneficiario.Eliminado = false;
                bBeneficiario.FechaNac = dtpFechaNac.Value;
                bBeneficiario.IdParentesco = Convert.ToInt32(cmbParentesco.SelectedValue);
                bBeneficiario.CedulaIdentidad = txtCarnet.Text;
               bBeneficiario.Edad = Convert.ToByte(txtEdad.Text);
            }
            catch
            {
                MessageBox.Show("ERROR AL CARGAR LA INFORMACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return bBeneficiario;
        }

        // VALIDAR FORMULARIO
        private bool ValidarFormulario()
        {
            bool bresult = false;
            if (txtNombre.Text == string.Empty)
            {
           //     epError.SetError(txtNombre, "DEBE INSERTAR EL NOMBRE DEL BENEFICIARIO");
                txtNombre.Focus();
                return bresult;
            }
            else
            {
               // epError.Clear();
            }
            if (txtApellidoPaterno.Text == string.Empty)
            {
             //   epError.SetError(txtApellidoPaterno, "DEBE INSERTAR AL MENOS EL APELLIDO PATERNO DEL BENEFICIARIO");
                txtApellidoPaterno.Focus();
                return bresult;
            }
            else
            {
             //   epError.Clear();
            }

            return bresult = true;
        }

        // LIMPIAR FORMULARIO
        private void LimpiarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtCarnet.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Now;
            txtEdad.Text = string.Empty;
        }

        private void HabilitarCampos()
        {
            txtNombre.ReadOnly = false;
            txtApellidoMaterno.ReadOnly = false;
            txtApellidoPaterno.ReadOnly = false;
            txtCarnet.ReadOnly = false;
            dtpFechaNac.Enabled = true;
            txtEdad.ReadOnly = true;
            cmbParentesco.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.HabilitarCampos();
            this.btnRegistrar.Enabled = true;
            btnModificar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardarCambios.Enabled = false;

        }

        // CARGA LOS BENEFICIARIOS AL DATAGRIEDVIEW
        private void CargarBeneficiarios()
        {
            dgvListaBenef.DataSource = this.nBeneficiario.listarBeneficiarioCodigo(Global.asociadoGlobal.Id);
            dgvListaBenef.Columns.Remove("Asociado");
            dgvListaBenef.Columns.Remove("Parentesco");
            dgvListaBenef.Columns.Remove("IdAsociado");
            dgvListaBenef.Columns.Remove("Status");
            dgvListaBenef.Columns.Remove("IdParentesco");

        }

        // CALCULA LA EDAD DEL BENEFICIARIO PARA REGISTRAR O MODIFICAR
        private int DateDiff(DateTime fechaNac)
        {
            int years = 0;
            TimeSpan span = DateTime.Now.Subtract(fechaNac);
            years = (int)(span.Days / 365.25); // leap years included - años biciestos incluidos
            return years;
        }

        // VALIDAR EDAD CON PARENTESCO DEL NUEVO BENEFICIARIO PARA EL REGISTRO
        private bool ValidarEdadParentesco()
        {
            bool bresult = false;
            string valueCmbParentesco = cmbParentesco.Text;
            if (txtEdad.Text != string.Empty)
            {
                if (nBeneficiario.ValidarRegistro(valueCmbParentesco, Convert.ToInt32(txtEdad.Text)))
                {
                    bresult = true;
                }
            }
            return bresult;
        }

        // CUANDO CAMBIA EL VALOR DE LA FECHA DE NACIMIENTO SE ACTUALIZA LA EDAD AUTOMATICAMENTE
        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            int iedad = this.DateDiff(dtpFechaNac.Value);
            txtEdad.Text = Convert.ToString(iedad);
        }

        // PASAR DATOS, CUANDO SE OBTENGA UN BENEFICIARIO LA INFORMACION SE MOSTRARA EN EL FORMULARIO
        private void PasarDatos()
        {
            txtNombre.Text = this.bBeneficiario.Nombre;
            txtApellidoPaterno.Text = this.bBeneficiario.Apellido1;
            txtApellidoMaterno.Text = this.bBeneficiario.Apellido2;
            txtCarnet.Text = this.bBeneficiario.CedulaIdentidad;
            txtEdad.Text = Convert.ToString(this.bBeneficiario.Edad);
            dtpFechaNac.Value = this.bBeneficiario.FechaNac;
            cmbParentesco.SelectedValue = this.bBeneficiario.Parentesco.Id;
            this.ReadOnlyCampos();
        }

        // CUANDO SE PRECIONA CLICK A LA CABECERA PROCEDE A BUSCAR LA INFORMACION DEL BENEFICARIO
        private void dgvListaBenef_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          //  this.epError.Clear();
            this.btnGuardarCambios.Enabled = false;
            this.btnModificar.Enabled = true;
            this.btnRegistrar.Enabled = false;
            this.bBeneficiario = this.nBeneficiario.DevolverBeneficiario(Convert.ToInt32(dgvListaBenef.CurrentRow.Cells[0].Value));
            this.PasarDatos();

        }

        // ReadOnly textboxs
        private void ReadOnlyCampos()
        {
            txtNombre.ReadOnly = true;
            txtApellidoPaterno.ReadOnly = true;
            txtApellidoMaterno.ReadOnly = true;
            txtCarnet.ReadOnly = true;
            cmbParentesco.Enabled = false;
            dtpFechaNac.Enabled = false;
        }

        // BOTON MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnGuardarCambios.Enabled = true;
            this.HabilitarCampos();
        }

        // VALIDAR PARENTESCOS EN CASO DE QUE QUIERA VOLVER DOS VECES UN ESPOSO(A) O EL MISMO PADRE
        private bool ExisteElParentesco()
        {
            bool bresult = true;
           if (!this.nBeneficiario.ValidarParentescos(cmbParentesco.Text , bBeneficiario.IdAsociado))
           {
               return bresult = false;
          }
            return bresult;
        }

        // GUARDAR CAMBIOS
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (this.ValidarFormulario())
            {

                if (this.nBeneficiario.ModificarBeneficiario(this.ArmarEntidadBeneficiario()))
                {
                    MessageBox.Show("ACTUALIZACION CON EXITO", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardarCambios.Enabled = false;
                    btnModificar.Enabled = false;
                    this.ReadOnlyCampos();
                    this.CargarBeneficiarios();
                }
                else
                {
                    MessageBox.Show("ERROR. VUELVA A INTENTARLO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            this.ReadOnlyCampos();
            btnRegistrar.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardarCambios.Enabled = false;
        }
    }
}
