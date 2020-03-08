using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CpPresentacion
{
    public partial class Menu : Form
    {
        public int xClick = 0, yClick = 0;
        public Menu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void AbrirFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void btnPRODUCTOS_Click(object sender, EventArgs e)
        {
            ProductoMain pantallaProductoMain = new ProductoMain();
            pantallaProductoMain.Show();
            AbrirFormInPanel(pantallaProductoMain);
        }

        int LX, LY, SW, SH;

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void btnPROVEEDORES_Click(object sender, EventArgs e)
        {
             MainProveedores pantallaMainProveedores = new MainProveedores();
            pantallaMainProveedores.Show();
            AbrirFormInPanel(pantallaMainProveedores);
        }

        

        private void btnmenu_Click(object sender, EventArgs e)
        {
            if (panelVertical.Width == 57)
            {
                panelVertical.Width = 250;
            }
            else

                panelVertical.Width = 57;
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112, 0xf012,0);
        }

        private void btnTipoProducto_Click(object sender, EventArgs e)
        {
            MainTipoProducto mainTipoProducto = new MainTipoProducto();
            mainTipoProducto.Show();
            AbrirFormInPanel(mainTipoProducto);
        }

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Mensaje. ¿Desea cerrar la aplicacion?", "¡Atencion!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                Application.Exit();
            }
           
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconmaximizar.Visible = true;
            iconrestaurar.Visible = false;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
    }
}
