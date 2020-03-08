namespace CpPresentacion
{
    partial class FormularioActualizar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdProductoActualizar = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbTipoProductoActualizar = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.btnCancelarActualizar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.cmbProveedorActualizar = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtStockMinimoActualizar = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.txtCantidadStockActualizar = new System.Windows.Forms.TextBox();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.txtValorVentaActualizar = new System.Windows.Forms.TextBox();
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.txtValorCompraActualizar = new System.Windows.Forms.TextBox();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.txtDescripcionProductoActualizar = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblModificarProducto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdProductoActualizar);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.cmbTipoProductoActualizar);
            this.panel1.Controls.Add(this.lblTipoProducto);
            this.panel1.Controls.Add(this.btnCancelarActualizar);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.cmbProveedorActualizar);
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.txtStockMinimoActualizar);
            this.panel1.Controls.Add(this.lblStockMinimo);
            this.panel1.Controls.Add(this.txtCantidadStockActualizar);
            this.panel1.Controls.Add(this.lblCantidadStock);
            this.panel1.Controls.Add(this.txtValorVentaActualizar);
            this.panel1.Controls.Add(this.lblValorVenta);
            this.panel1.Controls.Add(this.txtValorCompraActualizar);
            this.panel1.Controls.Add(this.lblValorCompra);
            this.panel1.Controls.Add(this.txtDescripcionProductoActualizar);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblModificarProducto);
            this.panel1.Location = new System.Drawing.Point(23, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 284);
            this.panel1.TabIndex = 1;
            // 
            // txtIdProductoActualizar
            // 
            this.txtIdProductoActualizar.Enabled = false;
            this.txtIdProductoActualizar.Location = new System.Drawing.Point(112, 53);
            this.txtIdProductoActualizar.Name = "txtIdProductoActualizar";
            this.txtIdProductoActualizar.Size = new System.Drawing.Size(121, 20);
            this.txtIdProductoActualizar.TabIndex = 18;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 53);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(62, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "Id Producto";
            // 
            // cmbTipoProductoActualizar
            // 
            this.cmbTipoProductoActualizar.FormattingEnabled = true;
            this.cmbTipoProductoActualizar.Location = new System.Drawing.Point(461, 167);
            this.cmbTipoProductoActualizar.Name = "cmbTipoProductoActualizar";
            this.cmbTipoProductoActualizar.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoProductoActualizar.TabIndex = 16;
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(369, 170);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(74, 13);
            this.lblTipoProducto.TabIndex = 15;
            this.lblTipoProducto.Text = "Tipo Producto";
            // 
            // btnCancelarActualizar
            // 
            this.btnCancelarActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelarActualizar.Location = new System.Drawing.Point(509, 228);
            this.btnCancelarActualizar.Name = "btnCancelarActualizar";
            this.btnCancelarActualizar.Size = new System.Drawing.Size(106, 38);
            this.btnCancelarActualizar.TabIndex = 14;
            this.btnCancelarActualizar.Text = "Cancelar";
            this.btnCancelarActualizar.UseVisualStyleBackColor = false;
            this.btnCancelarActualizar.Click += new System.EventHandler(this.btnCancelarActualizar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnActualizar.Location = new System.Drawing.Point(372, 228);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(106, 38);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbProveedorActualizar
            // 
            this.cmbProveedorActualizar.FormattingEnabled = true;
            this.cmbProveedorActualizar.Location = new System.Drawing.Point(461, 45);
            this.cmbProveedorActualizar.Name = "cmbProveedorActualizar";
            this.cmbProveedorActualizar.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedorActualizar.TabIndex = 12;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(369, 53);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 11;
            this.lblProveedor.Text = "Proveedor";
            // 
            // txtStockMinimoActualizar
            // 
            this.txtStockMinimoActualizar.Location = new System.Drawing.Point(461, 129);
            this.txtStockMinimoActualizar.Name = "txtStockMinimoActualizar";
            this.txtStockMinimoActualizar.Size = new System.Drawing.Size(121, 20);
            this.txtStockMinimoActualizar.TabIndex = 10;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(369, 136);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(68, 13);
            this.lblStockMinimo.TabIndex = 9;
            this.lblStockMinimo.Text = "StockMinimo";
            // 
            // txtCantidadStockActualizar
            // 
            this.txtCantidadStockActualizar.Location = new System.Drawing.Point(461, 88);
            this.txtCantidadStockActualizar.Name = "txtCantidadStockActualizar";
            this.txtCantidadStockActualizar.Size = new System.Drawing.Size(121, 20);
            this.txtCantidadStockActualizar.TabIndex = 8;
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Location = new System.Drawing.Point(369, 95);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(80, 13);
            this.lblCantidadStock.TabIndex = 7;
            this.lblCantidadStock.Text = "Cantidad Stock";
            // 
            // txtValorVentaActualizar
            // 
            this.txtValorVentaActualizar.Location = new System.Drawing.Point(111, 171);
            this.txtValorVentaActualizar.Name = "txtValorVentaActualizar";
            this.txtValorVentaActualizar.Size = new System.Drawing.Size(121, 20);
            this.txtValorVentaActualizar.TabIndex = 6;
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Location = new System.Drawing.Point(28, 178);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(62, 13);
            this.lblValorVenta.TabIndex = 5;
            this.lblValorVenta.Text = "Valor Venta";
            // 
            // txtValorCompraActualizar
            // 
            this.txtValorCompraActualizar.Location = new System.Drawing.Point(111, 130);
            this.txtValorCompraActualizar.Name = "txtValorCompraActualizar";
            this.txtValorCompraActualizar.Size = new System.Drawing.Size(121, 20);
            this.txtValorCompraActualizar.TabIndex = 4;
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(28, 137);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(70, 13);
            this.lblValorCompra.TabIndex = 3;
            this.lblValorCompra.Text = "Valor Compra";
            // 
            // txtDescripcionProductoActualizar
            // 
            this.txtDescripcionProductoActualizar.Location = new System.Drawing.Point(111, 88);
            this.txtDescripcionProductoActualizar.Name = "txtDescripcionProductoActualizar";
            this.txtDescripcionProductoActualizar.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcionProductoActualizar.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 95);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblModificarProducto
            // 
            this.lblModificarProducto.AutoSize = true;
            this.lblModificarProducto.Location = new System.Drawing.Point(15, 15);
            this.lblModificarProducto.Name = "lblModificarProducto";
            this.lblModificarProducto.Size = new System.Drawing.Size(96, 13);
            this.lblModificarProducto.TabIndex = 0;
            this.lblModificarProducto.Text = "Modificar Producto";
            // 
            // FormularioActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioActualizar";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormularioActualizar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtIdProductoActualizar;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.ComboBox cmbTipoProductoActualizar;
        public System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Button btnCancelarActualizar;
        private System.Windows.Forms.Button btnActualizar;
        public System.Windows.Forms.ComboBox cmbProveedorActualizar;
        private System.Windows.Forms.Label lblProveedor;
        public System.Windows.Forms.TextBox txtStockMinimoActualizar;
        public System.Windows.Forms.Label lblStockMinimo;
        public System.Windows.Forms.TextBox txtCantidadStockActualizar;
        public System.Windows.Forms.Label lblCantidadStock;
        public System.Windows.Forms.TextBox txtValorVentaActualizar;
        private System.Windows.Forms.Label lblValorVenta;
        public System.Windows.Forms.TextBox txtValorCompraActualizar;
        private System.Windows.Forms.Label lblValorCompra;
        public System.Windows.Forms.TextBox txtDescripcionProductoActualizar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblModificarProducto;
    }
}