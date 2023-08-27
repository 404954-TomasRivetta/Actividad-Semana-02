namespace problema1_4
{
    partial class FrmRegistrarJugador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNroCamiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBotones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cboPersona = new System.Windows.Forms.ComboBox();
            this.lblJugadorNro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNroCamiseta = new System.Windows.Forms.TextBox();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColJugador,
            this.ColNroCamiseta,
            this.ColPosicion,
            this.ColBotones});
            this.dgvJugadores.Location = new System.Drawing.Point(56, 215);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.Size = new System.Drawing.Size(493, 157);
            this.dgvJugadores.TabIndex = 71;
            this.dgvJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellContentClick);
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Column1";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColJugador
            // 
            this.ColJugador.HeaderText = "Jugador";
            this.ColJugador.Name = "ColJugador";
            this.ColJugador.ReadOnly = true;
            // 
            // ColNroCamiseta
            // 
            this.ColNroCamiseta.HeaderText = "Nro.Camiseta";
            this.ColNroCamiseta.Name = "ColNroCamiseta";
            this.ColNroCamiseta.ReadOnly = true;
            // 
            // ColPosicion
            // 
            this.ColPosicion.HeaderText = "Posicion";
            this.ColPosicion.Name = "ColPosicion";
            this.ColPosicion.ReadOnly = true;
            // 
            // ColBotones
            // 
            this.ColBotones.HeaderText = "Acciones";
            this.ColBotones.Name = "ColBotones";
            this.ColBotones.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(403, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 23);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(344, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(218, 378);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 67;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cboPersona
            // 
            this.cboPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersona.FormattingEnabled = true;
            this.cboPersona.Location = new System.Drawing.Point(172, 121);
            this.cboPersona.Name = "cboPersona";
            this.cboPersona.Size = new System.Drawing.Size(306, 21);
            this.cboPersona.TabIndex = 56;
            // 
            // lblJugadorNro
            // 
            this.lblJugadorNro.AutoSize = true;
            this.lblJugadorNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadorNro.Location = new System.Drawing.Point(63, 21);
            this.lblJugadorNro.Name = "lblJugadorNro";
            this.lblJugadorNro.Size = new System.Drawing.Size(103, 20);
            this.lblJugadorNro.TabIndex = 54;
            this.lblJugadorNro.Text = "Jugador Nº ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Persona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Posicion";
            // 
            // cboPosicion
            // 
            this.cboPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Location = new System.Drawing.Point(172, 150);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(121, 21);
            this.cboPosicion.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Numero de Camiseta";
            // 
            // txtNroCamiseta
            // 
            this.txtNroCamiseta.Location = new System.Drawing.Point(172, 183);
            this.txtNroCamiseta.Name = "txtNroCamiseta";
            this.txtNroCamiseta.Size = new System.Drawing.Size(121, 20);
            this.txtNroCamiseta.TabIndex = 76;
            // 
            // cboEquipo
            // 
            this.cboEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Location = new System.Drawing.Point(172, 85);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(306, 21);
            this.cboEquipo.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Equipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(170, 53);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 79;
            // 
            // FrmRegistrarJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 425);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboEquipo);
            this.Controls.Add(this.txtNroCamiseta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboPosicion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboPersona);
            this.Controls.Add(this.lblJugadorNro);
            this.Name = "FrmRegistrarJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liga Cordobesa";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboPersona;
        private System.Windows.Forms.Label lblJugadorNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNroCamiseta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroCamiseta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicion;
        private System.Windows.Forms.DataGridViewButtonColumn ColBotones;
        private System.Windows.Forms.ComboBox cboEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
    }
}

