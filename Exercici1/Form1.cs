using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercici1
{
    public partial class frmVentana1 : Form
    {
        public frmVentana1()
        {
            InitializeComponent();
        }

        private void frmVentana1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void frmVentana1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }

        private void btnFormulario_Click(object sender, EventArgs e)
        {
            //btnFormulario.FlatStyle = FlatStyle.Popup;
            //btnFormulario.FlatAppearance.BorderSize = 0;

            //btnFormulario.FlatAppearance.BorderColor = Color.Transparent;

            //MessageBox.Show("Se disparo el evento Click", "Atención");
            //this.BackColor = Color.Blue;

            if (txtbCajaTexto.Text == "")
                txtbCajaTexto.BackColor = Color.Red;
            else
                txtbCajaTexto.BackColor = System.Drawing.SystemColors.Control;
        }

        private void frmVentana1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton derecho", "Atención");
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio", "Atención");

        }

        private void lblFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            lblFormulario.BackColor = Color.Cyan;
            lblFormulario.Cursor = Cursors.Hand;


        }

        private void lblFormulario_MouseLeave(object sender, EventArgs e)
        {
            lblFormulario.BackColor = System.Drawing.SystemColors.Control;
            lblFormulario.Cursor = Cursors.Arrow;
        }

        private void txtbCajaTexto_TextChanged(object sender, EventArgs e)
        {
            txtbCajaTexto.BackColor = Color.Red;    
        }

        private void txtbCajaTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // SI XX < 0 o xx > 9 i xx not bakcspace
            if((e.KeyChar < 48 || e.KeyChar >57) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void txtbResultado_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene" + txtbResultado.Text.Length + "Caraceteres");
        }
    }
}
