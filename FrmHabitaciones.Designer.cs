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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHabitaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Name = "panel1";
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
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.bunifuCustomDataGrid1, "bunifuCustomDataGrid1");
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.RowTemplate.Height = 28;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnAgregar, "btnAgregar");
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnModificar, "btnModificar");
            this.btnModificar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
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
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // FrmHabitaciones
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.bunifuCustomDataGrid1);
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
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
    }
}