namespace Exercici1
{
    partial class frmVentana1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentana1));
            this.btnFormulario = new System.Windows.Forms.Button();
            this.lblFormulario = new System.Windows.Forms.Label();
            this.txtbCajaTexto = new System.Windows.Forms.TextBox();
            this.txtbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFormulario
            // 
            this.btnFormulario.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.btnFormulario, "btnFormulario");
            this.btnFormulario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFormulario.Image = global::Exercici1.Properties.Resources.icons8_formularios_de_google_50;
            this.btnFormulario.Name = "btnFormulario";
            this.btnFormulario.UseVisualStyleBackColor = false;
            this.btnFormulario.Click += new System.EventHandler(this.btnFormulario_Click);
            // 
            // lblFormulario
            // 
            resources.ApplyResources(this.lblFormulario, "lblFormulario");
            this.lblFormulario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFormulario.ForeColor = System.Drawing.Color.Black;
            this.lblFormulario.Name = "lblFormulario";
            this.lblFormulario.MouseLeave += new System.EventHandler(this.lblFormulario_MouseLeave);
            this.lblFormulario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblFormulario_MouseMove);
            // 
            // txtbCajaTexto
            // 
            this.txtbCajaTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txtbCajaTexto, "txtbCajaTexto");
            this.txtbCajaTexto.Name = "txtbCajaTexto";
            this.txtbCajaTexto.TextChanged += new System.EventHandler(this.txtbCajaTexto_TextChanged);
            this.txtbCajaTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCajaTexto_KeyPress);
            // 
            // txtbResultado
            // 
            resources.ApplyResources(this.txtbResultado, "txtbResultado");
            this.txtbResultado.Name = "txtbResultado";
            this.txtbResultado.Leave += new System.EventHandler(this.txtbResultado_Leave);
            // 
            // frmVentana1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.txtbResultado);
            this.Controls.Add(this.txtbCajaTexto);
            this.Controls.Add(this.lblFormulario);
            this.Controls.Add(this.btnFormulario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentana1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVentana1_FormClosed);
            this.Load += new System.EventHandler(this.frmVentana1_Load);
            this.Click += new System.EventHandler(this.frmVentana1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFormulario;
        private System.Windows.Forms.Label lblFormulario;
        private System.Windows.Forms.TextBox txtbCajaTexto;
        private System.Windows.Forms.TextBox txtbResultado;
    }
}

