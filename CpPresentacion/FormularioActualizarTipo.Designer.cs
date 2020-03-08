namespace CpPresentacion
{
    partial class FormularioActualizarTipo
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
            this.txtIdTiporActualizar = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnCancelarTipo = new System.Windows.Forms.Button();
            this.btnActualizarTipo = new System.Windows.Forms.Button();
            this.txtAreaTipoActualizar = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblActualizarTipo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdTiporActualizar);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.btnCancelarTipo);
            this.panel1.Controls.Add(this.btnActualizarTipo);
            this.panel1.Controls.Add(this.txtAreaTipoActualizar);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblActualizarTipo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 284);
            this.panel1.TabIndex = 3;
            // 
            // txtIdTiporActualizar
            // 
            this.txtIdTiporActualizar.Enabled = false;
            this.txtIdTiporActualizar.Location = new System.Drawing.Point(112, 46);
            this.txtIdTiporActualizar.Name = "txtIdTiporActualizar";
            this.txtIdTiporActualizar.Size = new System.Drawing.Size(121, 20);
            this.txtIdTiporActualizar.TabIndex = 18;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 53);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(86, 13);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Id Tipo Producto";
            // 
            // btnCancelarTipo
            // 
            this.btnCancelarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnCancelarTipo.Location = new System.Drawing.Point(152, 174);
            this.btnCancelarTipo.Name = "btnCancelarTipo";
            this.btnCancelarTipo.Size = new System.Drawing.Size(106, 38);
            this.btnCancelarTipo.TabIndex = 14;
            this.btnCancelarTipo.Text = "Cancelar";
            this.btnCancelarTipo.UseVisualStyleBackColor = false;
            // 
            // btnActualizarTipo
            // 
            this.btnActualizarTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.btnActualizarTipo.Location = new System.Drawing.Point(15, 174);
            this.btnActualizarTipo.Name = "btnActualizarTipo";
            this.btnActualizarTipo.Size = new System.Drawing.Size(106, 38);
            this.btnActualizarTipo.TabIndex = 13;
            this.btnActualizarTipo.Text = "Guardar";
            this.btnActualizarTipo.UseVisualStyleBackColor = false;
            this.btnActualizarTipo.Click += new System.EventHandler(this.btnActualizarTipo_Click);
            // 
            // txtAreaTipoActualizar
            // 
            this.txtAreaTipoActualizar.Location = new System.Drawing.Point(111, 76);
            this.txtAreaTipoActualizar.Name = "txtAreaTipoActualizar";
            this.txtAreaTipoActualizar.Size = new System.Drawing.Size(122, 20);
            this.txtAreaTipoActualizar.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 83);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(55, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Area/Tipo";
            // 
            // lblActualizarTipo
            // 
            this.lblActualizarTipo.AutoSize = true;
            this.lblActualizarTipo.Location = new System.Drawing.Point(15, 15);
            this.lblActualizarTipo.Name = "lblActualizarTipo";
            this.lblActualizarTipo.Size = new System.Drawing.Size(123, 13);
            this.lblActualizarTipo.TabIndex = 0;
            this.lblActualizarTipo.Text = "Actualizar Tipo Producto";
            // 
            // FormularioActualizarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 338);
            this.Controls.Add(this.panel1);
            this.Name = "FormularioActualizarTipo";
            this.Text = "FormularioActualizarTipo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txtIdTiporActualizar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCancelarTipo;
        private System.Windows.Forms.Button btnActualizarTipo;
        public System.Windows.Forms.TextBox txtAreaTipoActualizar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblActualizarTipo;
    }
}