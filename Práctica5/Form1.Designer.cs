namespace Práctica5
{
    partial class frmDatosPersonales
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblApellido = new Label();
            txtbApellido = new TextBox();
            lblNombre = new Label();
            txtbNombre = new TextBox();
            lblEdad = new Label();
            txtbEDAD = new TextBox();
            lblDireccion = new Label();
            txtbDireccion = new TextBox();
            lblResultado = new Label();
            txtbResultado = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(15, 12);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 15);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "APELLIDO";
            // 
            // txtbApellido
            // 
            txtbApellido.CharacterCasing = CharacterCasing.Upper;
            txtbApellido.Location = new Point(86, 9);
            txtbApellido.MaxLength = 20;
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(280, 23);
            txtbApellido.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(15, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "NOMBRE";
            // 
            // txtbNombre
            // 
            txtbNombre.CharacterCasing = CharacterCasing.Upper;
            txtbNombre.Location = new Point(86, 38);
            txtbNombre.MaxLength = 20;
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(280, 23);
            txtbNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(15, 70);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(37, 15);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "EDAD";
            // 
            // txtbEDAD
            // 
            txtbEDAD.Location = new Point(86, 67);
            txtbEDAD.MaxLength = 2;
            txtbEDAD.Name = "txtbEDAD";
            txtbEDAD.Size = new Size(64, 23);
            txtbEDAD.TabIndex = 5;
            txtbEDAD.KeyPress += txtbEDAD_KeyPress;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(15, 99);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(68, 15);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "DIRECCIÓN";
            // 
            // txtbDireccion
            // 
            txtbDireccion.CharacterCasing = CharacterCasing.Upper;
            txtbDireccion.Location = new Point(86, 96);
            txtbDireccion.MaxLength = 20;
            txtbDireccion.Name = "txtbDireccion";
            txtbDireccion.Size = new Size(280, 23);
            txtbDireccion.TabIndex = 7;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(15, 180);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(70, 15);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "RESULTADO";
            // 
            // txtbResultado
            // 
            txtbResultado.Location = new Point(16, 198);
            txtbResultado.Multiline = true;
            txtbResultado.Name = "txtbResultado";
            txtbResultado.Size = new Size(351, 118);
            txtbResultado.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.ButtonHighlight;
            btnAceptar.Location = new Point(98, 322);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(203, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmDatosPersonales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(379, 366);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtbResultado);
            Controls.Add(lblResultado);
            Controls.Add(txtbDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtbEDAD);
            Controls.Add(lblEdad);
            Controls.Add(txtbNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtbApellido);
            Controls.Add(lblApellido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmDatosPersonales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatosPersonales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApellido;
        private TextBox txtbApellido;
        private Label lblNombre;
        private TextBox txtbNombre;
        private Label lblEdad;
        private TextBox txtbEDAD;
        private Label lblDireccion;
        private TextBox txtbDireccion;
        private Label lblResultado;
        private TextBox txtbResultado;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
