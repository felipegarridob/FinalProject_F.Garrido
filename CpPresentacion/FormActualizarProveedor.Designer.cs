namespace CpPresentacion
{
    partial class FormActualizarProveedor
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
            this.txtIdProveedorActualizar = new System.Windows.Forms.TextBox();
            this.lblIdProv = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcionProveedorActualizar = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblActualizarProveedor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdProveedorActualizar);
            this.panel1.Controls.Add(this.lblIdProv);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtDescripcionProveedorActualizar);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblActualizarProveedor);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 284);
            this.panel1.TabIndex = 2;
            // 
            // txtIdProveedorActualizar
            // 
            this.txtIdProveedorActualizar.Enabled = false;
            this.txtIdProveedorActualizar.Location = new System.Drawing.Point(112, 46);
            this.txtIdProveedorActualizar.Name = "txtIdProveedorActualizar";
            this.txtIdProveedorActualizar.Size = new System.Drawing.Size(121, 20);
            this.txtIdProveedorActualizar.TabIndex = 18;
            // 
            // lblIdProv
            // 
            this.lblIdProv.AutoSize = true;
            this.lblIdProv.Location = new System.Drawing.Point(28, 53);
            this.lblIdProv.Name = "lblIdProv";
            this.lblIdProv.Size = new System.Drawing.Size(68, 13);
            this.lblIdProv.TabIndex = 17;
            this.lblIdProv.Text = "Id Proveedor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelar.Location = new System.Drawing.Point(152, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 38);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnGuardar.Location = new System.Drawing.Point(15, 174);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 38);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcionProveedorActualizar
            // 
            this.txtDescripcionProveedorActualizar.Location = new System.Drawing.Point(111, 76);
            this.txtDescripcionProveedorActualizar.Name = "txtDescripcionProveedorActualizar";
            this.txtDescripcionProveedorActualizar.Size = new System.Drawing.Size(122, 20);
            this.txtDescripcionProveedorActualizar.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 83);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblActualizarProveedor
            // 
            this.lblActualizarProveedor.AutoSize = true;
            this.lblActualizarProveedor.Location = new System.Drawing.Point(15, 15);
            this.lblActualizarProveedor.Name = "lblActualizarProveedor";
            this.lblActualizarProveedor.Size = new System.Drawing.Size(105, 13);
            this.lblActualizarProveedor.TabIndex = 0;
            this.lblActualizarProveedor.Text = "Actualizar Proveedor";
            this.lblActualizarProveedor.Click += new System.EventHandler(this.lblIngresoProveedor_Click);
            // 
            // FormActualizarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 370);
            this.Controls.Add(this.panel1);
            this.Name = "FormActualizarProveedor";
            this.Text = "Actualizar Proveedor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtIdProveedorActualizar;
        private System.Windows.Forms.Label lblIdProv;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtDescripcionProveedorActualizar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblActualizarProveedor;
    }
}