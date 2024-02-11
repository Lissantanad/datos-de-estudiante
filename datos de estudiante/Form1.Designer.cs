namespace datos_de_estudiante
{
    partial class Form1
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
            btn_limpiar = new Button();
            btn_Ingresar = new Button();
            btn_Salir = new Button();
            txt_Matricula = new Label();
            txt_Nombre = new Label();
            txt_Apellido = new Label();
            txt_Edad = new Label();
            txt_Carrera = new Label();
            txt_Datos = new Label();
            txtMatricula = new TextBox();
            txtCarrera = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDatos = new TextBox();
            SuspendLayout();
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = SystemColors.GradientInactiveCaption;
            btn_limpiar.Location = new Point(600, 147);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(120, 41);
            btn_limpiar.TabIndex = 0;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // btn_Ingresar
            // 
            btn_Ingresar.BackColor = SystemColors.GradientInactiveCaption;
            btn_Ingresar.Location = new Point(600, 78);
            btn_Ingresar.Name = "btn_Ingresar";
            btn_Ingresar.Size = new Size(120, 41);
            btn_Ingresar.TabIndex = 1;
            btn_Ingresar.Text = "Ingresar";
            btn_Ingresar.UseVisualStyleBackColor = false;
            btn_Ingresar.Click += btn_Ingresar_Click;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor = SystemColors.GradientInactiveCaption;
            btn_Salir.Location = new Point(600, 213);
            btn_Salir.Name = "btn_Salir";
            btn_Salir.Size = new Size(120, 41);
            btn_Salir.TabIndex = 2;
            btn_Salir.Text = "Salir";
            btn_Salir.UseVisualStyleBackColor = false;
            btn_Salir.Click += btn_Salir_Click;
            // 
            // txt_Matricula
            // 
            txt_Matricula.AutoSize = true;
            txt_Matricula.Location = new Point(168, 52);
            txt_Matricula.Name = "txt_Matricula";
            txt_Matricula.Size = new Size(84, 25);
            txt_Matricula.TabIndex = 3;
            txt_Matricula.Text = "Matricula";
            // 
            // txt_Nombre
            // 
            txt_Nombre.AutoSize = true;
            txt_Nombre.Location = new Point(168, 91);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(78, 25);
            txt_Nombre.TabIndex = 4;
            txt_Nombre.Text = "Nombre";
            // 
            // txt_Apellido
            // 
            txt_Apellido.AutoSize = true;
            txt_Apellido.Location = new Point(168, 134);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(78, 25);
            txt_Apellido.TabIndex = 5;
            txt_Apellido.Text = "Apellido";
            // 
            // txt_Edad
            // 
            txt_Edad.AutoSize = true;
            txt_Edad.Location = new Point(178, 176);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(52, 25);
            txt_Edad.TabIndex = 6;
            txt_Edad.Text = "Edad";
            // 
            // txt_Carrera
            // 
            txt_Carrera.AutoSize = true;
            txt_Carrera.Location = new Point(183, 226);
            txt_Carrera.Name = "txt_Carrera";
            txt_Carrera.Size = new Size(68, 25);
            txt_Carrera.TabIndex = 7;
            txt_Carrera.Text = "Carrera";
            // 
            // txt_Datos
            // 
            txt_Datos.AutoSize = true;
            txt_Datos.Location = new Point(38, 327);
            txt_Datos.Name = "txt_Datos";
            txt_Datos.Size = new Size(59, 25);
            txt_Datos.TabIndex = 8;
            txt_Datos.Text = "Datos";
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(258, 49);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(130, 31);
            txtMatricula.TabIndex = 9;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(258, 223);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(130, 31);
            txtCarrera.TabIndex = 10;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(258, 176);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(130, 31);
            txtEdad.TabIndex = 11;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(258, 131);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 31);
            txtApellido.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(258, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 31);
            txtNombre.TabIndex = 13;
            // 
            // txtDatos
            // 
            txtDatos.Location = new Point(103, 321);
            txtDatos.Name = "txtDatos";
            txtDatos.Size = new Size(617, 31);
            txtDatos.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(txtDatos);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtEdad);
            Controls.Add(txtCarrera);
            Controls.Add(txtMatricula);
            Controls.Add(txt_Datos);
            Controls.Add(txt_Carrera);
            Controls.Add(txt_Edad);
            Controls.Add(txt_Apellido);
            Controls.Add(txt_Nombre);
            Controls.Add(txt_Matricula);
            Controls.Add(btn_Salir);
            Controls.Add(btn_Ingresar);
            Controls.Add(btn_limpiar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_limpiar;
        private Button btn_Ingresar;
        private Button btn_Salir;
        private Label txt_Matricula;
        private Label txt_Nombre;
        private Label txt_Apellido;
        private Label txt_Edad;
        private Label txt_Carrera;
        private Label txt_Datos;
        private TextBox txtMatricula;
        private TextBox txtCarrera;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtDatos;
    }
}
