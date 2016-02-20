namespace Software
{
    partial class FBeneficiarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBeneficiarios));
            this.gbInfoAsociado = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtIdInterno = new System.Windows.Forms.TextBox();
            this.lblApellidoMat = new System.Windows.Forms.Label();
            this.txtApellidoMAsociado = new System.Windows.Forms.TextBox();
            this.lblCodigoAso = new System.Windows.Forms.Label();
            this.txtApellidoPAsociado = new System.Windows.Forms.TextBox();
            this.txtNombreAsoc = new System.Windows.Forms.TextBox();
            this.lblApellidoPat = new System.Windows.Forms.Label();
            this.lblNombreAso = new System.Windows.Forms.Label();
            this.txtCodigoAso = new System.Windows.Forms.TextBox();
            this.grbListaBen = new System.Windows.Forms.GroupBox();
            this.dgvListaBenef = new System.Windows.Forms.DataGridView();
            this.grbBeneficiario = new System.Windows.Forms.GroupBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbParentesco = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.lblCarnet = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.gbInfoAsociado.SuspendLayout();
            this.grbListaBen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBenef)).BeginInit();
            this.grbBeneficiario.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfoAsociado
            // 
            this.gbInfoAsociado.Controls.Add(this.lblId);
            this.gbInfoAsociado.Controls.Add(this.txtIdInterno);
            this.gbInfoAsociado.Controls.Add(this.lblApellidoMat);
            this.gbInfoAsociado.Controls.Add(this.txtApellidoMAsociado);
            this.gbInfoAsociado.Controls.Add(this.lblCodigoAso);
            this.gbInfoAsociado.Controls.Add(this.txtApellidoPAsociado);
            this.gbInfoAsociado.Controls.Add(this.txtNombreAsoc);
            this.gbInfoAsociado.Controls.Add(this.lblApellidoPat);
            this.gbInfoAsociado.Controls.Add(this.lblNombreAso);
            this.gbInfoAsociado.Controls.Add(this.txtCodigoAso);
            this.gbInfoAsociado.Location = new System.Drawing.Point(35, 87);
            this.gbInfoAsociado.Name = "gbInfoAsociado";
            this.gbInfoAsociado.Size = new System.Drawing.Size(258, 205);
            this.gbInfoAsociado.TabIndex = 23;
            this.gbInfoAsociado.TabStop = false;
            this.gbInfoAsociado.Text = "Informacion de Asociado";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(52, 13);
            this.lblId.TabIndex = 21;
            this.lblId.Text = "Id Interno";
            // 
            // txtIdInterno
            // 
            this.txtIdInterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdInterno.Location = new System.Drawing.Point(23, 51);
            this.txtIdInterno.Name = "txtIdInterno";
            this.txtIdInterno.ReadOnly = true;
            this.txtIdInterno.Size = new System.Drawing.Size(105, 20);
            this.txtIdInterno.TabIndex = 22;
            // 
            // lblApellidoMat
            // 
            this.lblApellidoMat.AutoSize = true;
            this.lblApellidoMat.Location = new System.Drawing.Point(20, 151);
            this.lblApellidoMat.Name = "lblApellidoMat";
            this.lblApellidoMat.Size = new System.Drawing.Size(90, 13);
            this.lblApellidoMat.TabIndex = 21;
            this.lblApellidoMat.Text = "Segundo Apellido";
            // 
            // txtApellidoMAsociado
            // 
            this.txtApellidoMAsociado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMAsociado.Location = new System.Drawing.Point(23, 168);
            this.txtApellidoMAsociado.Name = "txtApellidoMAsociado";
            this.txtApellidoMAsociado.ReadOnly = true;
            this.txtApellidoMAsociado.Size = new System.Drawing.Size(229, 20);
            this.txtApellidoMAsociado.TabIndex = 20;
            // 
            // lblCodigoAso
            // 
            this.lblCodigoAso.AutoSize = true;
            this.lblCodigoAso.Location = new System.Drawing.Point(143, 34);
            this.lblCodigoAso.Name = "lblCodigoAso";
            this.lblCodigoAso.Size = new System.Drawing.Size(73, 13);
            this.lblCodigoAso.TabIndex = 16;
            this.lblCodigoAso.Text = "Cod Asociado";
            // 
            // txtApellidoPAsociado
            // 
            this.txtApellidoPAsociado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPAsociado.Location = new System.Drawing.Point(23, 128);
            this.txtApellidoPAsociado.Name = "txtApellidoPAsociado";
            this.txtApellidoPAsociado.ReadOnly = true;
            this.txtApellidoPAsociado.Size = new System.Drawing.Size(229, 20);
            this.txtApellidoPAsociado.TabIndex = 19;
            // 
            // txtNombreAsoc
            // 
            this.txtNombreAsoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreAsoc.Location = new System.Drawing.Point(23, 89);
            this.txtNombreAsoc.Name = "txtNombreAsoc";
            this.txtNombreAsoc.ReadOnly = true;
            this.txtNombreAsoc.Size = new System.Drawing.Size(229, 20);
            this.txtNombreAsoc.TabIndex = 14;
            // 
            // lblApellidoPat
            // 
            this.lblApellidoPat.AutoSize = true;
            this.lblApellidoPat.Location = new System.Drawing.Point(20, 112);
            this.lblApellidoPat.Name = "lblApellidoPat";
            this.lblApellidoPat.Size = new System.Drawing.Size(76, 13);
            this.lblApellidoPat.TabIndex = 18;
            this.lblApellidoPat.Text = "Primer Apellido";
            // 
            // lblNombreAso
            // 
            this.lblNombreAso.AutoSize = true;
            this.lblNombreAso.Location = new System.Drawing.Point(20, 72);
            this.lblNombreAso.Name = "lblNombreAso";
            this.lblNombreAso.Size = new System.Drawing.Size(91, 13);
            this.lblNombreAso.TabIndex = 15;
            this.lblNombreAso.Text = "Nombre Asociado";
            // 
            // txtCodigoAso
            // 
            this.txtCodigoAso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoAso.Location = new System.Drawing.Point(134, 50);
            this.txtCodigoAso.Name = "txtCodigoAso";
            this.txtCodigoAso.ReadOnly = true;
            this.txtCodigoAso.Size = new System.Drawing.Size(118, 20);
            this.txtCodigoAso.TabIndex = 17;
            // 
            // grbListaBen
            // 
            this.grbListaBen.Controls.Add(this.dgvListaBenef);
            this.grbListaBen.Location = new System.Drawing.Point(83, 298);
            this.grbListaBen.Name = "grbListaBen";
            this.grbListaBen.Size = new System.Drawing.Size(618, 183);
            this.grbListaBen.TabIndex = 22;
            this.grbListaBen.TabStop = false;
            this.grbListaBen.Text = "Lista Beneficiarios";
            // 
            // dgvListaBenef
            // 
            this.dgvListaBenef.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListaBenef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaBenef.GridColor = System.Drawing.Color.LightGreen;
            this.dgvListaBenef.Location = new System.Drawing.Point(21, 19);
            this.dgvListaBenef.Name = "dgvListaBenef";
            this.dgvListaBenef.ReadOnly = true;
            this.dgvListaBenef.Size = new System.Drawing.Size(581, 150);
            this.dgvListaBenef.TabIndex = 0;
            this.dgvListaBenef.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaBenef_RowHeaderMouseClick);
            // 
            // grbBeneficiario
            // 
            this.grbBeneficiario.Controls.Add(this.txtEdad);
            this.grbBeneficiario.Controls.Add(this.lblEdad);
            this.grbBeneficiario.Controls.Add(this.lblNombre);
            this.grbBeneficiario.Controls.Add(this.cmbParentesco);
            this.grbBeneficiario.Controls.Add(this.txtNombre);
            this.grbBeneficiario.Controls.Add(this.lblParentesco);
            this.grbBeneficiario.Controls.Add(this.lblApellidoPaterno);
            this.grbBeneficiario.Controls.Add(this.dtpFechaNac);
            this.grbBeneficiario.Controls.Add(this.txtApellidoPaterno);
            this.grbBeneficiario.Controls.Add(this.lblFechaNac);
            this.grbBeneficiario.Controls.Add(this.txtCarnet);
            this.grbBeneficiario.Controls.Add(this.lblApellidoMaterno);
            this.grbBeneficiario.Controls.Add(this.txtApellidoMaterno);
            this.grbBeneficiario.Controls.Add(this.lblCarnet);
            this.grbBeneficiario.Location = new System.Drawing.Point(299, 87);
            this.grbBeneficiario.Name = "grbBeneficiario";
            this.grbBeneficiario.Size = new System.Drawing.Size(474, 205);
            this.grbBeneficiario.TabIndex = 21;
            this.grbBeneficiario.TabStop = false;
            this.grbBeneficiario.Text = "Beneficiario";
            // 
            // txtEdad
            // 
            this.txtEdad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdad.Location = new System.Drawing.Point(249, 129);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(213, 20);
            this.txtEdad.TabIndex = 13;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(248, 113);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbParentesco
            // 
            this.cmbParentesco.FormattingEnabled = true;
            this.cmbParentesco.Location = new System.Drawing.Point(15, 50);
            this.cmbParentesco.Name = "cmbParentesco";
            this.cmbParentesco.Size = new System.Drawing.Size(217, 21);
            this.cmbParentesco.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(15, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblParentesco
            // 
            this.lblParentesco.AutoSize = true;
            this.lblParentesco.Location = new System.Drawing.Point(21, 34);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(61, 13);
            this.lblParentesco.TabIndex = 10;
            this.lblParentesco.Text = "Parentesco";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(21, 113);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(76, 13);
            this.lblApellidoPaterno.TabIndex = 1;
            this.lblApellidoPaterno.Text = "Primer Apellido";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(251, 90);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(211, 20);
            this.dtpFechaNac.TabIndex = 9;
            this.dtpFechaNac.ValueChanged += new System.EventHandler(this.dtpFechaNac_ValueChanged);
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoPaterno.Location = new System.Drawing.Point(15, 129);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(217, 20);
            this.txtApellidoPaterno.TabIndex = 6;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(248, 74);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(63, 13);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha Nac.";
            // 
            // txtCarnet
            // 
            this.txtCarnet.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCarnet.Location = new System.Drawing.Point(249, 50);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(213, 20);
            this.txtCarnet.TabIndex = 8;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(21, 152);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(90, 13);
            this.lblApellidoMaterno.TabIndex = 2;
            this.lblApellidoMaterno.Text = "Segundo Apellido";
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoMaterno.Location = new System.Drawing.Point(15, 168);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(217, 20);
            this.txtApellidoMaterno.TabIndex = 7;
            // 
            // lblCarnet
            // 
            this.lblCarnet.AutoSize = true;
            this.lblCarnet.Location = new System.Drawing.Point(248, 34);
            this.lblCarnet.Name = "lblCarnet";
            this.lblCarnet.Size = new System.Drawing.Size(38, 13);
            this.lblCarnet.TabIndex = 3;
            this.lblCarnet.Text = "Carnet";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnNuevo);
            this.flowLayoutPanel1.Controls.Add(this.btnRegistrar);
            this.flowLayoutPanel1.Controls.Add(this.btnModificar);
            this.flowLayoutPanel1.Controls.Add(this.btnGuardarCambios);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelar);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(758, 68);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(64, 64);
            this.btnNuevo.TabIndex = 23;
            this.tooltip.SetToolTip(this.btnNuevo, "Nuevo");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Location = new System.Drawing.Point(73, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(64, 64);
            this.btnRegistrar.TabIndex = 24;
            this.tooltip.SetToolTip(this.btnRegistrar, "Guardar");
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificar.Location = new System.Drawing.Point(143, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(64, 64);
            this.btnModificar.TabIndex = 25;
            this.tooltip.SetToolTip(this.btnModificar, "Editar");
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.BackgroundImage")));
            this.btnGuardarCambios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.Enabled = false;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuardarCambios.Location = new System.Drawing.Point(213, 3);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(64, 64);
            this.btnGuardarCambios.TabIndex = 26;
            this.tooltip.SetToolTip(this.btnGuardarCambios, "Guardar Cambios");
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Location = new System.Drawing.Point(283, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(64, 64);
            this.btnCancelar.TabIndex = 27;
            this.tooltip.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FBeneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 526);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gbInfoAsociado);
            this.Controls.Add(this.grbListaBen);
            this.Controls.Add(this.grbBeneficiario);
            this.Name = "FBeneficiarios";
            this.Text = "Beneficiarios";
            this.Load += new System.EventHandler(this.frmBeneficiario_Load);
            this.gbInfoAsociado.ResumeLayout(false);
            this.gbInfoAsociado.PerformLayout();
            this.grbListaBen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBenef)).EndInit();
            this.grbBeneficiario.ResumeLayout(false);
            this.grbBeneficiario.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoAsociado;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtIdInterno;
        private System.Windows.Forms.Label lblApellidoMat;
        private System.Windows.Forms.TextBox txtApellidoMAsociado;
        private System.Windows.Forms.Label lblCodigoAso;
        private System.Windows.Forms.TextBox txtApellidoPAsociado;
        private System.Windows.Forms.TextBox txtNombreAsoc;
        private System.Windows.Forms.Label lblApellidoPat;
        private System.Windows.Forms.Label lblNombreAso;
        private System.Windows.Forms.TextBox txtCodigoAso;
        private System.Windows.Forms.GroupBox grbListaBen;
        private System.Windows.Forms.DataGridView dgvListaBenef;
        private System.Windows.Forms.GroupBox grbBeneficiario;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbParentesco;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblParentesco;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtCarnet;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.Label lblCarnet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip tooltip;
    }
}