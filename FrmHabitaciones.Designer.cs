namespace ProyectoOptaHotel
{
    partial class FrmHabitaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHabitaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtIdHabitacion = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblPiso = new System.Windows.Forms.Label();
            this.cboPiso = new System.Windows.Forms.ComboBox();
            this.lblCaracteristicas = new System.Windows.Forms.Label();
            this.txtCaracteristicas = new System.Windows.Forms.TextBox();
            this.lblPrecioDiario = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtPrecioDiario = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.HabitacionGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.picActualizar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Name = "panel1";
            // 
            // lblHora
            // 
            resources.ApplyResources(this.lblHora, "lblHora");
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Name = "lblHora";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Name = "label1";
            // 
            // lblNumero
            // 
            resources.ApplyResources(this.lblNumero, "lblNumero");
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNumero.Name = "lblNumero";
            // 
            // txtIdHabitacion
            // 
            resources.ApplyResources(this.txtIdHabitacion, "txtIdHabitacion");
            this.txtIdHabitacion.Name = "txtIdHabitacion";
            // 
            // txtNumero
            // 
            resources.ApplyResources(this.txtNumero, "txtNumero");
            this.txtNumero.Name = "txtNumero";
            // 
            // lblPiso
            // 
            resources.ApplyResources(this.lblPiso, "lblPiso");
            this.lblPiso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPiso.Name = "lblPiso";
            // 
            // cboPiso
            // 
            this.cboPiso.FormattingEnabled = true;
            this.cboPiso.Items.AddRange(new object[] {
            resources.GetString("cboPiso.Items"),
            resources.GetString("cboPiso.Items1"),
            resources.GetString("cboPiso.Items2"),
            resources.GetString("cboPiso.Items3"),
            resources.GetString("cboPiso.Items4"),
            resources.GetString("cboPiso.Items5")});
            resources.ApplyResources(this.cboPiso, "cboPiso");
            this.cboPiso.Name = "cboPiso";
            // 
            // lblCaracteristicas
            // 
            resources.ApplyResources(this.lblCaracteristicas, "lblCaracteristicas");
            this.lblCaracteristicas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCaracteristicas.Name = "lblCaracteristicas";
            // 
            // txtCaracteristicas
            // 
            resources.ApplyResources(this.txtCaracteristicas, "txtCaracteristicas");
            this.txtCaracteristicas.Name = "txtCaracteristicas";
            // 
            // lblPrecioDiario
            // 
            resources.ApplyResources(this.lblPrecioDiario, "lblPrecioDiario");
            this.lblPrecioDiario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrecioDiario.Name = "lblPrecioDiario";
            // 
            // lblEstado
            // 
            resources.ApplyResources(this.lblEstado, "lblEstado");
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEstado.Name = "lblEstado";
            // 
            // lblTipo
            // 
            resources.ApplyResources(this.lblTipo, "lblTipo");
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Click += new System.EventHandler(this.lblTipo_Click);
            // 
            // txtPrecioDiario
            // 
            resources.ApplyResources(this.txtPrecioDiario, "txtPrecioDiario");
            this.txtPrecioDiario.Name = "txtPrecioDiario";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            resources.GetString("cboEstado.Items"),
            resources.GetString("cboEstado.Items1"),
            resources.GetString("cboEstado.Items2"),
            resources.GetString("cboEstado.Items3")});
            resources.ApplyResources(this.cboEstado, "cboEstado");
            this.cboEstado.Name = "cboEstado";
            // 
            // cboTipoHabitacion
            // 
            this.cboTipoHabitacion.FormattingEnabled = true;
            this.cboTipoHabitacion.Items.AddRange(new object[] {
            resources.GetString("cboTipoHabitacion.Items"),
            resources.GetString("cboTipoHabitacion.Items1"),
            resources.GetString("cboTipoHabitacion.Items2")});
            resources.ApplyResources(this.cboTipoHabitacion, "cboTipoHabitacion");
            this.cboTipoHabitacion.Name = "cboTipoHabitacion";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            resources.ApplyResources(this.txtBuscar, "txtBuscar");
            this.txtBuscar.Name = "txtBuscar";
            // 
            // lblBuscar
            // 
            resources.ApplyResources(this.lblBuscar, "lblBuscar");
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBuscar.Name = "lblBuscar";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HabitacionGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.HabitacionGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HabitacionGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.HabitacionGridView, "HabitacionGridView");
            this.HabitacionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HabitacionGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.HabitacionGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HabitacionGridView.Name = "HabitacionGridView";
            this.HabitacionGridView.RowHeadersVisible = false;
            this.HabitacionGridView.RowTemplate.Height = 28;
            this.HabitacionGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.HabitacionGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.HabitacionGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.HabitacionGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.HabitacionGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.HabitacionGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.HabitacionGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HabitacionGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HabitacionGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HabitacionGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HabitacionGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.HabitacionGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.HabitacionGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.HabitacionGridView.ThemeStyle.ReadOnly = false;
            this.HabitacionGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.HabitacionGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HabitacionGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.HabitacionGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HabitacionGridView.ThemeStyle.RowsStyle.Height = 28;
            this.HabitacionGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HabitacionGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HabitacionGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HabitacionGridView_CellContentClick);
            // 
            // picActualizar
            // 
            resources.ApplyResources(this.picActualizar, "picActualizar");
            this.picActualizar.Name = "picActualizar";
            this.picActualizar.TabStop = false;
            this.picActualizar.Click += new System.EventHandler(this.picActualizar_Click);
            // 
            // FrmHabitaciones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.picActualizar);
            this.Controls.Add(this.HabitacionGridView);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboTipoHabitacion);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtPrecioDiario);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPrecioDiario);
            this.Controls.Add(this.txtCaracteristicas);
            this.Controls.Add(this.lblCaracteristicas);
            this.Controls.Add(this.cboPiso);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtIdHabitacion);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHabitaciones";
            this.Load += new System.EventHandler(this.FrmHabitaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtIdHabitacion;
        private System.Windows.Forms.TextBox txtNumero;
        public System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.ComboBox cboPiso;
        public System.Windows.Forms.Label lblCaracteristicas;
        private System.Windows.Forms.TextBox txtCaracteristicas;
        public System.Windows.Forms.Label lblPrecioDiario;
        public System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtPrecioDiario;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboTipoHabitacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DataGridView HabitacionGridView;
        private System.Windows.Forms.PictureBox picActualizar;
    }
}