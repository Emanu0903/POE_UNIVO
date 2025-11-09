namespace ValidacionFormularioC_
{
    public partial class frmValidacion : Form
    {
        public frmValidacion()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string edadTexto = txtEdad.Text.Trim();
            int edad;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(edadTexto))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(edadTexto, out edad))
            {
                MessageBox.Show("La edad debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (edad < 18)
            {
                MessageBox.Show("Debe ser mayor o igual a 18 años.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Bienvenido {nombre}, acceso permitido.", "Acceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
