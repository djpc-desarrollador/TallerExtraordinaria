using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Taller_Extraordinaria.Datos;
namespace Software
{
    public partial class GestionAsociados : Form
    {
        NTipoAsociado tipoAsociado = new NTipoAsociado();
        NAsociado nAsociado = new NAsociado();
        Asociado aAsociado = new Asociado();

        public GestionAsociados()
        {
            InitializeComponent();
            this.grbInformacionLab.Visible = false;
        }

        private void GestionAsociados_Load(object sender, EventArgs e)
        {
            this.cmbCategoria.DataSource = this.tipoAsociado.ListarTodos();
            this.cmbCategoria.DisplayMember = "Descripcion";
            this.cmbCategoria.ValueMember = "Id";
            this.chkFalso.Checked = true;
            this.cmbSexo.SelectedIndex = 0;
            this.cmbCiudadProc.SelectedIndex = 0;
            this.cmbEstadoCivil.SelectedIndex = 0;
            this.ReadOnlyCampos();
        }

        private void lblTelefonoDom_Click(object sender, EventArgs e)
        {

        }

        private void tRegistro_MouseEnter(object sender, EventArgs e)
        {
            tTip.SetToolTip(btnNew, "Nuevo");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            // this.epError.Clear();
            btnRegister.Enabled = true;
            this.LimpiarCampos();
            this.habilitarCampos();
            btnEdit.Enabled = false;
        }

        #region ArmarEntidad
        private Asociado ArmarEntidadAsociado()
        {

            try
            {
                this.aAsociado.Nombre = txtNombres.Text.Trim();
                this.aAsociado.Apellido1 = txtApellidoPaterno.Text.Trim();
                this.aAsociado.Apellido2 = txtApellidoMaterno.Text.Trim();
                this.aAsociado.FechaNac = dtpFechaNac.Value;
                this.aAsociado.EstadoCivil = Convert.ToString(cmbEstadoCivil.SelectedItem);
                this.aAsociado.CedulaIdentidad = txtCarnet.Text.Trim();
                this.aAsociado.Sexo = Convert.ToString(cmbSexo.SelectedItem);
                this.aAsociado.Celular = txtCelular.Text.Trim();
                this.aAsociado.CiudadProc = Convert.ToString(cmbCiudadProc.SelectedItem);
                this.aAsociado.DireccionOfi = txtDireccionOf.Text.Trim();
                this.aAsociado.TelefonoOfi = txtTelefonoOfi.Text.Trim();
                this.aAsociado.Profesion = txtProfesion.Text.Trim();
                this.aAsociado.Empresa = txtEmpresa.Text.Trim();
                this.aAsociado.CargoEmpresa = txtCargoEmp.Text.Trim();
                this.aAsociado.DireccionDom = txtDireccionDom.Text.Trim();
                this.aAsociado.TelefonoDom = txtTelefonoDom.Text.Trim();
                this.aAsociado.Email = txtEmail.Text.Trim();
                this.aAsociado.IdTipoAsociado = Convert.ToInt32(cmbCategoria.SelectedValue);
                this.aAsociado.Eliminado = false;
                this.aAsociado.FechaIngreso = dtpFechaIngreso.Value;
                this.aAsociado.PaisProc = txtPais.Text.Trim();
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                PbFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.aAsociado.Imagen = ms.GetBuffer();
                if (txtPais.Text == string.Empty)
                {
                    this.aAsociado.PaisProc = "BOLIVIA";
                }
                else
                {
                    this.aAsociado.PaisProc = txtPais.Text.Trim();
                }
                if (chkFalso.Checked == true)
                {
                    this.aAsociado.Enmora = false;
                }
                else
                {
                    this.aAsociado.Enmora = true;
                }
                if (this.txtCodigoAsociado.Text.Trim() == string.Empty)
                {
                    this.aAsociado.Codigo = 0;
                }
                else
                {
                    this.aAsociado.Codigo = Convert.ToInt32(txtCodigoAsociado.Text);
                }
            }
            catch
            {
                MessageBox.Show("ERROR AL CARGAR LA INFORMACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            return this.aAsociado;
        }
        #endregion

        public void ReadOnlyCampos()
        {
            txtNombres.ReadOnly = true;
            txtApellidoPaterno.ReadOnly = true;
            txtApellidoMaterno.ReadOnly = true;
            dtpFechaNac.Enabled = false;
            cmbEstadoCivil.Enabled = false;
            txtCarnet.ReadOnly = true;
            cmbSexo.Enabled = true;
            txtCelular.ReadOnly = true;
            cmbCiudadProc.Enabled = false;
            txtDireccionOf.ReadOnly = true;
            txtTelefonoOfi.ReadOnly = true;
            txtProfesion.ReadOnly = true;
            txtEmpresa.ReadOnly = true;
            txtCargoEmp.ReadOnly = true;
            txtDireccionDom.ReadOnly = true;
            txtTelefonoDom.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cmbCategoria.Enabled = false;
            cmbSexo.Enabled = false;
            txtCodigoAsociado.ReadOnly = true;
            chkFalso.Enabled = false;
            chkVerdadero.Enabled = false;
            txtPais.ReadOnly = true;
            dtpFechaIngreso.Enabled = false;
        }

        public void habilitarCampos()
        {
            txtNombres.ReadOnly = false;
            txtApellidoPaterno.ReadOnly = false;
            txtApellidoMaterno.ReadOnly = false;
            dtpFechaNac.Enabled = true;
            cmbEstadoCivil.Enabled = true;
            txtCarnet.ReadOnly = false;
            cmbSexo.Enabled = false;
            txtCelular.ReadOnly = false;
            cmbCiudadProc.Enabled = true;
            txtDireccionOf.ReadOnly = false;
            txtTelefonoOfi.ReadOnly = false;
            txtProfesion.ReadOnly = false;
            txtEmpresa.ReadOnly = false;
            txtCargoEmp.ReadOnly = false;
            txtDireccionDom.ReadOnly = false;
            txtTelefonoDom.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cmbCategoria.Enabled = true;
            cmbSexo.Enabled = true;
            txtCodigoAsociado.ReadOnly = true;
            txtCodigoAsociado.ReadOnly = false;
            chkFalso.Enabled = true;
            chkVerdadero.Enabled = true;
            dtpFechaIngreso.Enabled = true;
        }
        public void LimpiarCampos()
        {
            txtInterno.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApellidoPaterno.Text = string.Empty;
            txtApellidoMaterno.Text = string.Empty;
            txtCarnet.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtDireccionOf.Text = string.Empty;
            txtTelefonoOfi.Text = string.Empty;
            txtProfesion.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            txtCargoEmp.Text = string.Empty;
            txtDireccionDom.Text = string.Empty;
            txtTelefonoDom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCodigoAsociado.Text = string.Empty;
            txtCodigoAsociado.Text = string.Empty;
            txtPais.Text = string.Empty;
            cmbCiudadProc.SelectedIndex = 0;
            PbFoto.Image = PbFoto.ErrorImage;
        }

        public void LimpiarCamposBusqueda()
        {
            txt1Interno.Text = string.Empty;
            txt1Nombre.Text = string.Empty;
            txt1Apellido1.Text = string.Empty;
            txt1Apellido2.Text = string.Empty;
            txt1Codigo.Text = string.Empty;
            txt1Ci.Text = string.Empty;
            txt1Celular.Text = string.Empty;
            txt1PaisProc.Text = string.Empty;
            txt1CiudadProc.Text = string.Empty;
            txt1Sexo.Text = string.Empty;
            txt1EstadoCivil.Text = string.Empty;
            txt1Categoria.Text = string.Empty;
            pb1Foto.Image = null;
            dgvResult.DataSource = null;
        }

        // Pasar Datos a Formulario Tab Asociado
        #region PasarDatos
        public void pasarDatosAsociado()
        {
            txtInterno.Text = Convert.ToString(this.aAsociado.Id);
            txtNombres.Text = this.aAsociado.Nombre.Trim();
            txtApellidoPaterno.Text = this.aAsociado.Apellido1.Trim();
            txtApellidoMaterno.Text = this.aAsociado.Apellido2.Trim();
            dtpFechaNac.Value = Convert.ToDateTime(this.aAsociado.FechaNac);
            cmbEstadoCivil.SelectedItem = this.aAsociado.EstadoCivil.Trim();
            txtCarnet.Text = this.aAsociado.CedulaIdentidad.Trim();
            cmbSexo.SelectedItem = this.aAsociado.Sexo;
            txtCelular.Text = this.aAsociado.Celular.Trim();
            cmbCiudadProc.SelectedItem = this.aAsociado.CiudadProc;
            txtDireccionOf.Text = this.aAsociado.DireccionOfi.Trim();
            txtTelefonoOfi.Text = this.aAsociado.TelefonoOfi.Trim();
            txtProfesion.Text = this.aAsociado.Profesion.Trim();
            txtEmpresa.Text = this.aAsociado.Empresa.Trim();
            txtCargoEmp.Text = this.aAsociado.CargoEmpresa.Trim();
            txtDireccionDom.Text = this.aAsociado.DireccionDom.Trim();
            txtTelefonoDom.Text = this.aAsociado.TelefonoDom.Trim();
            txtEmail.Text = this.aAsociado.Email.Trim();
            cmbCategoria.SelectedValue = this.aAsociado.IdTipoAsociado;
            this.aAsociado.Eliminado = this.aAsociado.Eliminado;
            txtPais.Text = this.aAsociado.PaisProc.Trim();
            txtCodigoAsociado.Text = Convert.ToString(this.aAsociado.Codigo);
            dtpFechaIngreso.Value = Convert.ToDateTime(this.aAsociado.FechaIngreso);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(aAsociado.Imagen);
            PbFoto.Image = System.Drawing.Bitmap.FromStream(ms);
            PbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (this.aAsociado.Enmora == true)
            {
                chkVerdadero.Checked = true;
            }
            else
            {
                chkVerdadero.Checked = false;
                chkFalso.Checked = true;
            }

        }
        #endregion

        // Pasar Datos TAP Busqueda

        public void pasarDatosBusqueda()
        {
            txt1Interno.Text = Convert.ToString(this.aAsociado.Id);
            txt1Codigo.Text = Convert.ToString(this.aAsociado.Codigo);
            txt1Nombre.Text = this.aAsociado.Nombre.Trim();
            txt1Apellido1.Text = this.aAsociado.Apellido1.Trim();
            txt1Apellido2.Text = this.aAsociado.Apellido2.Trim();
            dtp1FechaNac.Value = Convert.ToDateTime(this.aAsociado.FechaNac);
            txt1EstadoCivil.Text = this.aAsociado.EstadoCivil.Trim();
            txt1Ci.Text = this.aAsociado.CedulaIdentidad.Trim();
            txt1Sexo.Text = this.aAsociado.Sexo;
            txt1Celular.Text = this.aAsociado.Celular.Trim();
            txt1CiudadProc.Text = this.aAsociado.CiudadProc;
            txt1Categoria.Text = this.aAsociado.TipoAsociado.Descripcion;
            this.aAsociado.Eliminado = this.aAsociado.Eliminado;
            txt1PaisProc.Text = this.aAsociado.PaisProc.Trim();
            txtCodigoAsociado.Text = Convert.ToString(this.aAsociado.Codigo);
            dtpFechaIngreso.Value = Convert.ToDateTime(this.aAsociado.FechaIngreso);
            System.IO.MemoryStream ms = new System.IO.MemoryStream(aAsociado.Imagen);
            pb1Foto.Image = System.Drawing.Bitmap.FromStream(ms);
            pb1Foto.SizeMode = PictureBoxSizeMode.StretchImage;
            if (this.aAsociado.Enmora == true)
            {
                chk1Verdadero.Checked = true;
            }
            else
            {
                chk1Verdadero.Checked = false;
                chk1Falso.Checked = true;
            }

        }

        #region validar Formulario
        private bool ValidarFormulario()
        {
            bool bresult = false;
            if (txtNombres.Text.Trim() == string.Empty)
            {
                txtNombres.Focus();
                return bresult;
            }
            else
            {
            }
            if (txtApellidoPaterno.Text.Trim() == string.Empty)
            {

                txtApellidoPaterno.Focus();
                return bresult;
            }

            else
            {

            }
            if (txtCodigoAsociado.Text.Trim() == string.Empty)
            {

                txtCodigoAsociado.Focus();
                return bresult;
            }
            else
            {

            }
            if (txtCarnet.Text.Trim() == string.Empty)
            {
                txtCarnet.Focus();
                return bresult;
            }
            else
            {
            }
            if ((txtPais.ReadOnly == false) && (txtPais.Text.Trim() == string.Empty))
            {

                txtPais.Focus();
                return bresult;
            }
            else
            {

            }

            return bresult = true;
        }
        #endregion

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (this.ValidarFormulario())
            {

                bool bRegistro = this.nAsociado.RegistrarAsociado(this.ArmarEntidadAsociado());
                if (bRegistro == true)
                {
                    MessageBox.Show("REGISTRO REALIZADO CON EXITO", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRegister.Enabled = false;
                    this.LimpiarCampos();
                    //   this.cargarAsociados();

                }
                else
                {
                    MessageBox.Show("ERROR EN EL REGISTRO VUELVA A INTERTARLO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            this.habilitarCampos();
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.ValidarFormulario())
            {

                if (this.nAsociado.ModificarAsociado(this.ArmarEntidadAsociado()))
                {
                    MessageBox.Show("ACTUALIZACION CON EXITO", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSalvar.Enabled = false;
                    btnEdit.Enabled = false;
                    this.ReadOnlyCampos();
                }
                else
                {
                    MessageBox.Show("ERROR. VUELVA A INTENTARLO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnEdit.Enabled = false;
            btnRegister.Enabled = false;
            this.LimpiarCampos();
            this.ReadOnlyCampos();
        }

        private void btnBeneficiarios_Click(object sender, EventArgs e)
        {
            try
            {
                FBeneficiarios ben = new FBeneficiarios();
                ben.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("NECESITA CARGAR UN ASOCIADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void lblMas_Click(object sender, EventArgs e)
        {
            if (grbInformacionLab.Visible == false)
            {
                grbInformacionLab.Visible = true;
                lblMas.Text = "<Menos";

            }
            else
            {

                grbInformacionLab.Visible = false;
                lblMas.Text = ">Mas";

            }
        }



        private void PbFoto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();

            getImage.InitialDirectory = "c:\\";
            getImage.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif"; ;
            getImage.FilterIndex = 2;
            getImage.RestoreDirectory = true;

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PbFoto.ImageLocation = getImage.FileName;
                    PbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception)
                {
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvResult.DataSource = nAsociado.BuscarAsociado(txt1Nombre.Text, txt1Apellido1.Text, txt1Apellido2.Text, txt1Codigo.Text, txt1Ci.Text);
            dgvResult.Columns.Remove("Imagen");
            dgvResult.Columns.Remove("IdTipoAsociado");
            dgvResult.Columns.Remove("Eliminado");
            dgvResult.Columns.Remove("EnMora");
            dgvResult.Columns.Remove("Email");
            dgvResult.Columns.Remove("DireccionOfi");
            dgvResult.Columns.Remove("TelefonoOfi");
            dgvResult.Columns.Remove("DireccionDom");
            dgvResult.Columns.Remove("TelefonoDom");
            dgvResult.Columns.Remove("Profesion");
            dgvResult.Columns.Remove("Empresa");
            dgvResult.Columns.Remove("CargoEmpresa");
            dgvResult.Columns.Remove("TipoAsociado");
            //dgvResult.Columns.Remove("Mensualidades");
            dgvResult.Columns.Remove("Beneficiario");
        }

        private void dgvResult_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.aAsociado = this.nAsociado.DevolverAsociado(Convert.ToInt32(dgvResult.CurrentRow.Cells[0].Value));
                Global.asociadoGlobal = this.aAsociado;
                this.pasarDatosBusqueda();
                btnRegister.Enabled = false;
            }
            catch
            {

            }
        }
        private void btnPasarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                this.btnSalvar.Enabled = false;
                this.btnEdit.Enabled = true;
                this.pasarDatosAsociado();
                this.ReadOnlyCampos();
                this.tabControl.SelectTab(1);
            }
            catch (Exception)
            {
                MessageBox.Show("NO HAY DATOS QUE PASAR");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpiarCamposBusqueda();
        }

        private void cmbCiudadProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((string)cmbCiudadProc.SelectedItem).Equals("EXTRANJERO"))
            {
                txtPais.ReadOnly = false;
                txtPais.Focus();
            }
            else
            {
                txtPais.ReadOnly = true;
                txtPais.Text = string.Empty;
            }
        }

        private void btnBeneficiari_Click(object sender, EventArgs e)
        {
            try
            {
                FBeneficiarios ben = new FBeneficiarios();
                ben.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("NECESITA CARGAR UN ASOCIADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void btnMensualidad_Click(object sender, EventArgs e)
        {

        }


    }
}
