namespace Práctica5
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //COmentario git
            if (txtbApellido.Text == "")
                txtbApellido.BackColor = Color.Red;
            else
                txtbApellido.BackColor = System.Drawing.SystemColors.Window;
            
            if (txtbNombre.Text == "")
                txtbNombre.BackColor = Color.Red;
            else
                txtbNombre.BackColor = System.Drawing.SystemColors.Window;

            if (txtbDireccion.Text == "")
                txtbDireccion.BackColor = Color.Red;
            else
                txtbDireccion.BackColor = System.Drawing.SystemColors.Window;

            if (txtbEDAD.Text == "")
                txtbEDAD.BackColor = Color.Red;
            else
                txtbEDAD.BackColor = System.Drawing.SystemColors.Window;

            if (txtbApellido.Text.Length != 0 && txtbNombre.Text.Length != 0 && txtbDireccion.Text.Length != 0 && txtbEDAD.Text.Length != 0)
                txtbResultado.Text = ("Apellido y Nombre: " + txtbApellido.Text + " " + txtbNombre.Text + Environment.NewLine + "Edad: " 
                                     + txtbEDAD.Text + Environment.NewLine + "Direccion: " + txtbDireccion.Text);


        }
        
        private void txtbEDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
