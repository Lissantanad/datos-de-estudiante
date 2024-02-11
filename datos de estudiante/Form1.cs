namespace datos_de_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad;
            if (int.TryParse(txtEdad.Text, out edad))
  
            {
                string carrera = txt_Carrera.Text;

                txtDatos.Text = $"Matrícula: {matricula}";
                txtDatos.Text = $"Nombre: {nombre}";
                txtDatos.Text = $"Apellido: {apellido}";
                txtDatos.Text = $"Edad: {edad}";
                txtDatos.Text = $"Carrera: {carrera}";

                txtDatos.Text="Matricula: " + matricula.ToString() +"        Nombre: " + nombre.ToString()+ "     Apellido: " + apellido.ToString() +  "     Edad: " +edad.ToString() + "    Carrera:  " + carrera.ToString();

            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtCarrera.Clear();
            txtDatos.Clear();

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
