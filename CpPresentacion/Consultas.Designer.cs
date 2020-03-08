namespace CpPresentacion
{
    partial class Consultas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipoInfo = new System.Windows.Forms.Label();
            this.lblProveedorInfo = new System.Windows.Forms.Label();
            this.lblProductoInfo = new System.Windows.Forms.Label();
            this.gBoxOpciones = new System.Windows.Forms.GroupBox();
            this.rBtnTipo = new System.Windows.Forms.RadioButton();
            this.rBtnProveedor = new System.Windows.Forms.RadioButton();
            this.rBtnProducto = new System.Windows.Forms.RadioButton();
            this.cmbProductoConsultas = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbTipoProductoConsultas = new System.Windows.Forms.ComboBox();
            this.cmbProveedorConsultas = new System.Windows.Forms.ComboBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIngresoProducto = new System.Windows.Forms.Label();
            this.btnCancelarConsultas = new System.Windows.Forms.Button();
            this.btnAceptarConsultas = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gBoxOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTipoInfo);
            this.panel1.Controls.Add(this.lblProveedorInfo);
            this.panel1.Controls.Add(this.lblProductoInfo);
            this.panel1.Controls.Add(this.gBoxOpciones);
            this.panel1.Controls.Add(this.cmbProductoConsultas);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.cmbTipoProductoConsultas);
            this.panel1.Controls.Add(this.cmbProveedorConsultas);
            this.panel1.Controls.Add(this.lblValorCompra);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblIngresoProducto);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 189);
            this.panel1.TabIndex = 1;
            // 
            // lblTipoInfo
            // 
            this.lblTipoInfo.AutoSize = true;
            this.lblTipoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTipoInfo.Location = new System.Drawing.Point(634, 103);
            this.lblTipoInfo.Name = "lblTipoInfo";
            this.lblTipoInfo.Size = new System.Drawing.Size(274, 17);
            this.lblTipoInfo.TabIndex = 22;
            this.lblTipoInfo.Text = "Seleccione un Tipo de Producto de la lista";
            this.lblTipoInfo.Visible = false;
            // 
            // lblProveedorInfo
            // 
            this.lblProveedorInfo.AutoSize = true;
            this.lblProveedorInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedorInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProveedorInfo.Location = new System.Drawing.Point(634, 61);
            this.lblProveedorInfo.Name = "lblProveedorInfo";
            this.lblProveedorInfo.Size = new System.Drawing.Size(231, 17);
            this.lblProveedorInfo.TabIndex = 21;
            this.lblProveedorInfo.Text = "Seleccione un Proveedor de la lista";
            this.lblProveedorInfo.Visible = false;
            // 
            // lblProductoInfo
            // 
            this.lblProductoInfo.AutoSize = true;
            this.lblProductoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoInfo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProductoInfo.Location = new System.Drawing.Point(634, 19);
            this.lblProductoInfo.Name = "lblProductoInfo";
            this.lblProductoInfo.Size = new System.Drawing.Size(222, 17);
            this.lblProductoInfo.TabIndex = 20;
            this.lblProductoInfo.Text = "Seleccione un Producto de la lista";
            this.lblProductoInfo.Visible = false;
            // 
            // gBoxOpciones
            // 
            this.gBoxOpciones.Controls.Add(this.rBtnTipo);
            this.gBoxOpciones.Controls.Add(this.rBtnProveedor);
            this.gBoxOpciones.Controls.Add(this.rBtnProducto);
            this.gBoxOpciones.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gBoxOpciones.Location = new System.Drawing.Point(18, 44);
            this.gBoxOpciones.Name = "gBoxOpciones";
            this.gBoxOpciones.Size = new System.Drawing.Size(266, 68);
            this.gBoxOpciones.TabIndex = 19;
            this.gBoxOpciones.TabStop = false;
            this.gBoxOpciones.Text = "Seleccione una opcion";
            // 
            // rBtnTipo
            // 
            this.rBtnTipo.AutoSize = true;
            this.rBtnTipo.Location = new System.Drawing.Point(161, 45);
            this.rBtnTipo.Name = "rBtnTipo";
            this.rBtnTipo.Size = new System.Drawing.Size(107, 17);
            this.rBtnTipo.TabIndex = 2;
            this.rBtnTipo.Text = "Tipo de Producto";
            this.rBtnTipo.UseVisualStyleBackColor = true;
            this.rBtnTipo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rBtnTipo_MouseClick);
            // 
            // rBtnProveedor
            // 
            this.rBtnProveedor.AutoSize = true;
            this.rBtnProveedor.Location = new System.Drawing.Point(81, 45);
            this.rBtnProveedor.Name = "rBtnProveedor";
            this.rBtnProveedor.Size = new System.Drawing.Size(74, 17);
            this.rBtnProveedor.TabIndex = 1;
            this.rBtnProveedor.Text = "Proveedor";
            this.rBtnProveedor.UseVisualStyleBackColor = true;
            this.rBtnProveedor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rBtnProveedor_MouseClick);
            // 
            // rBtnProducto
            // 
            this.rBtnProducto.AutoSize = true;
            this.rBtnProducto.Location = new System.Drawing.Point(7, 45);
            this.rBtnProducto.Name = "rBtnProducto";
            this.rBtnProducto.Size = new System.Drawing.Size(68, 17);
            this.rBtnProducto.TabIndex = 0;
            this.rBtnProducto.Text = "Producto";
            this.rBtnProducto.UseVisualStyleBackColor = true;
            this.rBtnProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rBtnProducto_MouseClick);
            // 
            // cmbProductoConsultas
            // 
            this.cmbProductoConsultas.Enabled = false;
            this.cmbProductoConsultas.FormattingEnabled = true;
            this.cmbProductoConsultas.Location = new System.Drawing.Point(472, 15);
            this.cmbProductoConsultas.Name = "cmbProductoConsultas";
            this.cmbProductoConsultas.Size = new System.Drawing.Size(121, 21);
            this.cmbProductoConsultas.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblId.Location = new System.Drawing.Point(324, 23);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(50, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Producto";
            // 
            // cmbTipoProductoConsultas
            // 
            this.cmbTipoProductoConsultas.Enabled = false;
            this.cmbTipoProductoConsultas.FormattingEnabled = true;
            this.cmbTipoProductoConsultas.Location = new System.Drawing.Point(472, 99);
            this.cmbTipoProductoConsultas.Name = "cmbTipoProductoConsultas";
            this.cmbTipoProductoConsultas.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoProductoConsultas.TabIndex = 16;
            // 
            // cmbProveedorConsultas
            // 
            this.cmbProveedorConsultas.Enabled = false;
            this.cmbProveedorConsultas.FormattingEnabled = true;
            this.cmbProveedorConsultas.Location = new System.Drawing.Point(472, 57);
            this.cmbProveedorConsultas.Name = "cmbProveedorConsultas";
            this.cmbProveedorConsultas.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedorConsultas.TabIndex = 12;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblValorCompra.Location = new System.Drawing.Point(324, 107);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(89, 13);
            this.lblValorCompra.TabIndex = 3;
            this.lblValorCompra.Text = "Tipo de Producto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDescripcion.Location = new System.Drawing.Point(324, 65);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(56, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Proveedor";
            // 
            // lblIngresoProducto
            // 
            this.lblIngresoProducto.AutoSize = true;
            this.lblIngresoProducto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblIngresoProducto.Location = new System.Drawing.Point(15, 15);
            this.lblIngresoProducto.Name = "lblIngresoProducto";
            this.lblIngresoProducto.Size = new System.Drawing.Size(122, 13);
            this.lblIngresoProducto.TabIndex = 0;
            this.lblIngresoProducto.Text = "Consultar productos por:";
            // 
            // btnCancelarConsultas
            // 
            this.btnCancelarConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelarConsultas.Location = new System.Drawing.Point(858, 358);
            this.btnCancelarConsultas.Name = "btnCancelarConsultas";
            this.btnCancelarConsultas.Size = new System.Drawing.Size(106, 38);
            this.btnCancelarConsultas.TabIndex = 14;
            this.btnCancelarConsultas.Text = "Cancelar";
            this.btnCancelarConsultas.UseVisualStyleBackColor = false;
            this.btnCancelarConsultas.Click += new System.EventHandler(this.btnCancelarConsultas_Click);
            // 
            // btnAceptarConsultas
            // 
            this.btnAceptarConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnAceptarConsultas.Location = new System.Drawing.Point(732, 358);
            this.btnAceptarConsultas.Name = "btnAceptarConsultas";
            this.btnAceptarConsultas.Size = new System.Drawing.Size(106, 38);
            this.btnAceptarConsultas.TabIndex = 13;
            this.btnAceptarConsultas.Text = "Aceptar";
            this.btnAceptarConsultas.UseVisualStyleBackColor = false;
            this.btnAceptarConsultas.Click += new System.EventHandler(this.btnAceptarConsultas_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            this.dgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsultas.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(68)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsultas.EnableHeadersVisualStyles = false;
            this.dgvConsultas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvConsultas.Location = new System.Drawing.Point(12, 207);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsultas.Size = new System.Drawing.Size(714, 189);
            this.dgvConsultas.TabIndex = 15;
            this.dgvConsultas.Visible = false;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 408);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAceptarConsultas);
            this.Controls.Add(this.btnCancelarConsultas);
            this.Name = "Consultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBoxOpciones.ResumeLayout(false);
            this.gBoxOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.ComboBox cmbTipoProductoConsultas;
        private System.Windows.Forms.Button btnCancelarConsultas;
        private System.Windows.Forms.Button btnAceptarConsultas;
        public System.Windows.Forms.ComboBox cmbProveedorConsultas;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblIngresoProducto;
        public System.Windows.Forms.ComboBox cmbProductoConsultas;
        private System.Windows.Forms.GroupBox gBoxOpciones;
        private System.Windows.Forms.RadioButton rBtnTipo;
        private System.Windows.Forms.RadioButton rBtnProveedor;
        private System.Windows.Forms.RadioButton rBtnProducto;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Label lblProductoInfo;
        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTipoInfo;
        private System.Windows.Forms.Label lblProveedorInfo;
    }
}