namespace Software
{
    partial class FPagoReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPagoReserva));
            this.grbReserva = new System.Windows.Forms.GroupBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtReservaCod = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellidoPat = new System.Windows.Forms.Label();
            this.txtCedulaIdentidad = new System.Windows.Forms.TextBox();
            this.txtNombreAsoc = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblNombreAso = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.lblGarantia = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.lblCodigoReserva = new System.Windows.Forms.Label();
            this.txtCodReserva = new System.Windows.Forms.TextBox();
            this.gbInfoAsociado = new System.Windows.Forms.GroupBox();
            this.lblBs = new System.Windows.Forms.Label();
            this.lblCodigoPago = new System.Windows.Forms.Label();
            this.txtCodPago = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtPagoObserv = new System.Windows.Forms.TextBox();
            this.txtPagoMotivo = new System.Windows.Forms.TextBox();
            this.lblPagoObservacion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEliminado = new System.Windows.Forms.Button();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.grbReserva.SuspendLayout();
            this.gbInfoAsociado.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbReserva
            // 
            this.grbReserva.Controls.Add(this.lblArea);
            this.grbReserva.Controls.Add(this.txtArea);
            this.grbReserva.Controls.Add(this.label2);
            this.grbReserva.Controls.Add(this.txtObservacion);
            this.grbReserva.Controls.Add(this.txtReservaCod);
            this.grbReserva.Controls.Add(this.lblCedula);
            this.grbReserva.Controls.Add(this.txtApellido1);
            this.grbReserva.Controls.Add(this.lblApellidoPat);
            this.grbReserva.Controls.Add(this.txtCedulaIdentidad);
            this.grbReserva.Controls.Add(this.txtNombreAsoc);
            this.grbReserva.Controls.Add(this.lblObservacion);
            this.grbReserva.Controls.Add(this.lblNombreAso);
            this.grbReserva.Controls.Add(this.txtGarantia);
            this.grbReserva.Controls.Add(this.lblGarantia);
            this.grbReserva.Controls.Add(this.lblFechaReserva);
            this.grbReserva.Controls.Add(this.dtpFechaReserva);
            this.grbReserva.Location = new System.Drawing.Point(463, 101);
            this.grbReserva.Name = "grbReserva";
            this.grbReserva.Size = new System.Drawing.Size(369, 278);
            this.grbReserva.TabIndex = 29;
            this.grbReserva.TabStop = false;
            this.grbReserva.Text = "Informacion Reserva";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(197, 16);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(76, 13);
            this.lblArea.TabIndex = 33;
            this.lblArea.Text = "Area Ocupada";
            // 
            // txtArea
            // 
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArea.Location = new System.Drawing.Point(191, 34);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(164, 20);
            this.txtArea.TabIndex = 34;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Codigo Reserva";
            // 
            // txtObservacion
            // 
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Location = new System.Drawing.Point(6, 192);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.ReadOnly = true;
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservacion.Size = new System.Drawing.Size(341, 48);
            this.txtObservacion.TabIndex = 26;
            // 
            // txtReservaCod
            // 
            this.txtReservaCod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtReservaCod.Location = new System.Drawing.Point(6, 34);
            this.txtReservaCod.Name = "txtReservaCod";
            this.txtReservaCod.ReadOnly = true;
            this.txtReservaCod.Size = new System.Drawing.Size(168, 20);
            this.txtReservaCod.TabIndex = 32;
            this.txtReservaCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(6, 57);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(102, 13);
            this.lblCedula.TabIndex = 23;
            this.lblCedula.Text = "Cedula de Identidad";
            // 
            // txtApellido1
            // 
            this.txtApellido1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido1.Location = new System.Drawing.Point(191, 114);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.ReadOnly = true;
            this.txtApellido1.Size = new System.Drawing.Size(164, 20);
            this.txtApellido1.TabIndex = 19;
            // 
            // lblApellidoPat
            // 
            this.lblApellidoPat.AutoSize = true;
            this.lblApellidoPat.Location = new System.Drawing.Point(188, 98);
            this.lblApellidoPat.Name = "lblApellidoPat";
            this.lblApellidoPat.Size = new System.Drawing.Size(76, 13);
            this.lblApellidoPat.TabIndex = 18;
            this.lblApellidoPat.Text = "Primer Apellido";
            // 
            // txtCedulaIdentidad
            // 
            this.txtCedulaIdentidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCedulaIdentidad.Location = new System.Drawing.Point(6, 73);
            this.txtCedulaIdentidad.Name = "txtCedulaIdentidad";
            this.txtCedulaIdentidad.ReadOnly = true;
            this.txtCedulaIdentidad.Size = new System.Drawing.Size(168, 20);
            this.txtCedulaIdentidad.TabIndex = 24;
            this.txtCedulaIdentidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombreAsoc
            // 
            this.txtNombreAsoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreAsoc.Location = new System.Drawing.Point(7, 114);
            this.txtNombreAsoc.Name = "txtNombreAsoc";
            this.txtNombreAsoc.ReadOnly = true;
            this.txtNombreAsoc.Size = new System.Drawing.Size(167, 20);
            this.txtNombreAsoc.TabIndex = 14;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(6, 176);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(67, 13);
            this.lblObservacion.TabIndex = 25;
            this.lblObservacion.Text = "Observacion";
            // 
            // lblNombreAso
            // 
            this.lblNombreAso.AutoSize = true;
            this.lblNombreAso.Location = new System.Drawing.Point(12, 98);
            this.lblNombreAso.Name = "lblNombreAso";
            this.lblNombreAso.Size = new System.Drawing.Size(96, 13);
            this.lblNombreAso.TabIndex = 15;
            this.lblNombreAso.Text = "Nombre Solicitante";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(191, 73);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.ReadOnly = true;
            this.txtGarantia.Size = new System.Drawing.Size(164, 20);
            this.txtGarantia.TabIndex = 24;
            // 
            // lblGarantia
            // 
            this.lblGarantia.AutoSize = true;
            this.lblGarantia.Location = new System.Drawing.Point(188, 57);
            this.lblGarantia.Name = "lblGarantia";
            this.lblGarantia.Size = new System.Drawing.Size(50, 13);
            this.lblGarantia.TabIndex = 23;
            this.lblGarantia.Text = "Garantia:";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(7, 137);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(95, 13);
            this.lblFechaReserva.TabIndex = 23;
            this.lblFechaReserva.Text = "Fecha de Reserva";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Enabled = false;
            this.dtpFechaReserva.Location = new System.Drawing.Point(6, 153);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaReserva.TabIndex = 0;
            // 
            // lblCodigoReserva
            // 
            this.lblCodigoReserva.AutoSize = true;
            this.lblCodigoReserva.Location = new System.Drawing.Point(6, 57);
            this.lblCodigoReserva.Name = "lblCodigoReserva";
            this.lblCodigoReserva.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoReserva.TabIndex = 29;
            this.lblCodigoReserva.Text = "Codigo Reserva";
            // 
            // txtCodReserva
            // 
            this.txtCodReserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodReserva.Location = new System.Drawing.Point(9, 73);
            this.txtCodReserva.Name = "txtCodReserva";
            this.txtCodReserva.Size = new System.Drawing.Size(212, 20);
            this.txtCodReserva.TabIndex = 30;
            this.txtCodReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodReserva_KeyPress);
            // 
            // gbInfoAsociado
            // 
            this.gbInfoAsociado.Controls.Add(this.lblBs);
            this.gbInfoAsociado.Controls.Add(this.lblCodigoPago);
            this.gbInfoAsociado.Controls.Add(this.txtCodPago);
            this.gbInfoAsociado.Controls.Add(this.txtMonto);
            this.gbInfoAsociado.Controls.Add(this.lblMonto);
            this.gbInfoAsociado.Controls.Add(this.txtPagoObserv);
            this.gbInfoAsociado.Controls.Add(this.txtPagoMotivo);
            this.gbInfoAsociado.Controls.Add(this.lblPagoObservacion);
            this.gbInfoAsociado.Controls.Add(this.lblFecha);
            this.gbInfoAsociado.Controls.Add(this.lblMotivo);
            this.gbInfoAsociado.Controls.Add(this.lblCodigoReserva);
            this.gbInfoAsociado.Controls.Add(this.dtpFechaActual);
            this.gbInfoAsociado.Controls.Add(this.txtCodReserva);
            this.gbInfoAsociado.Location = new System.Drawing.Point(12, 101);
            this.gbInfoAsociado.Name = "gbInfoAsociado";
            this.gbInfoAsociado.Size = new System.Drawing.Size(445, 278);
            this.gbInfoAsociado.TabIndex = 28;
            this.gbInfoAsociado.TabStop = false;
            this.gbInfoAsociado.Text = "Pago de Reserva";
            // 
            // lblBs
            // 
            this.lblBs.AutoSize = true;
            this.lblBs.Font = new System.Drawing.Font("Nueva Std", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBs.Location = new System.Drawing.Point(304, 248);
            this.lblBs.Name = "lblBs";
            this.lblBs.Size = new System.Drawing.Size(29, 20);
            this.lblBs.TabIndex = 33;
            this.lblBs.Text = "Bs.";
            // 
            // lblCodigoPago
            // 
            this.lblCodigoPago.AutoSize = true;
            this.lblCodigoPago.Location = new System.Drawing.Point(152, 16);
            this.lblCodigoPago.Name = "lblCodigoPago";
            this.lblCodigoPago.Size = new System.Drawing.Size(117, 13);
            this.lblCodigoPago.TabIndex = 31;
            this.lblCodigoPago.Text = "Codigo de Transaccion";
            // 
            // txtCodPago
            // 
            this.txtCodPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodPago.Location = new System.Drawing.Point(98, 32);
            this.txtCodPago.Name = "txtCodPago";
            this.txtCodPago.ReadOnly = true;
            this.txtCodPago.Size = new System.Drawing.Size(212, 20);
            this.txtCodPago.TabIndex = 32;
            this.txtCodPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(98, 248);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 20);
            this.txtMonto.TabIndex = 28;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(152, 232);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(91, 13);
            this.lblMonto.TabIndex = 27;
            this.lblMonto.Text = "Monto a Cancelar";
            // 
            // txtPagoObserv
            // 
            this.txtPagoObserv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPagoObserv.Location = new System.Drawing.Point(6, 181);
            this.txtPagoObserv.Multiline = true;
            this.txtPagoObserv.Name = "txtPagoObserv";
            this.txtPagoObserv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPagoObserv.Size = new System.Drawing.Size(421, 48);
            this.txtPagoObserv.TabIndex = 28;
            // 
            // txtPagoMotivo
            // 
            this.txtPagoMotivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPagoMotivo.Location = new System.Drawing.Point(9, 114);
            this.txtPagoMotivo.Multiline = true;
            this.txtPagoMotivo.Name = "txtPagoMotivo";
            this.txtPagoMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPagoMotivo.Size = new System.Drawing.Size(418, 48);
            this.txtPagoMotivo.TabIndex = 28;
            this.txtPagoMotivo.Text = "PAGO RESERVA";
            // 
            // lblPagoObservacion
            // 
            this.lblPagoObservacion.AutoSize = true;
            this.lblPagoObservacion.Location = new System.Drawing.Point(6, 165);
            this.lblPagoObservacion.Name = "lblPagoObservacion";
            this.lblPagoObservacion.Size = new System.Drawing.Size(67, 13);
            this.lblPagoObservacion.TabIndex = 27;
            this.lblPagoObservacion.Text = "Observacion";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(228, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(80, 13);
            this.lblFecha.TabIndex = 28;
            this.lblFecha.Text = "Fecha de Pago";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(6, 98);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(39, 13);
            this.lblMotivo.TabIndex = 27;
            this.lblMotivo.Text = "Motivo";
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Enabled = false;
            this.dtpFechaActual.Location = new System.Drawing.Point(227, 73);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaActual.TabIndex = 27;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnBuscar);
            this.flowLayoutPanel1.Controls.Add(this.btnPagar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Controls.Add(this.btnEliminado);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(820, 72);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Location = new System.Drawing.Point(3, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 64);
            this.btnBuscar.TabIndex = 40;
            this.tTip.SetToolTip(this.btnBuscar, "Buscar Reserva");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPagar.BackgroundImage")));
            this.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.ForeColor = System.Drawing.Color.Transparent;
            this.btnPagar.Location = new System.Drawing.Point(73, 3);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(64, 64);
            this.btnPagar.TabIndex = 0;
            this.tTip.SetToolTip(this.btnPagar, "Pagar Reserva");
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(143, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 64);
            this.btnCancel.TabIndex = 39;
            this.tTip.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEliminado
            // 
            this.btnEliminado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminado.BackgroundImage")));
            this.btnEliminado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminado.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminado.Location = new System.Drawing.Point(213, 3);
            this.btnEliminado.Name = "btnEliminado";
            this.btnEliminado.Size = new System.Drawing.Size(64, 64);
            this.btnEliminado.TabIndex = 1;
            this.tTip.SetToolTip(this.btnEliminado, "Anular Pago");
            this.btnEliminado.UseVisualStyleBackColor = true;
            // 
            // FPagoReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 436);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grbReserva);
            this.Controls.Add(this.gbInfoAsociado);
            this.Name = "FPagoReserva";
            this.Text = "FPagoReserva";
            this.grbReserva.ResumeLayout(false);
            this.grbReserva.PerformLayout();
            this.gbInfoAsociado.ResumeLayout(false);
            this.gbInfoAsociado.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbReserva;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblApellidoPat;
        private System.Windows.Forms.TextBox txtCedulaIdentidad;
        private System.Windows.Forms.TextBox txtNombreAsoc;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblNombreAso;
        private System.Windows.Forms.Label lblCodigoReserva;
        private System.Windows.Forms.TextBox txtCodReserva;
        private System.Windows.Forms.TextBox txtGarantia;
        private System.Windows.Forms.Label lblGarantia;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.GroupBox gbInfoAsociado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReservaCod;
        private System.Windows.Forms.Label lblBs;
        private System.Windows.Forms.Label lblCodigoPago;
        private System.Windows.Forms.TextBox txtCodPago;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtPagoObserv;
        private System.Windows.Forms.TextBox txtPagoMotivo;
        private System.Windows.Forms.Label lblPagoObservacion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnEliminado;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnBuscar;
    }
}