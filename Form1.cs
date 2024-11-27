namespace ProyectoProgra
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Usuario")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                textBoxUsuario.Text = "Usuario";
                textBoxUsuario.ForeColor = Color.LightGray;
            }
        }

        private void textBoxContraseña_Enter(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "Contraseña")
            {
                textBoxContraseña.Text = "";
                textBoxContraseña.ForeColor = Color.LightGray;

            }
            textBoxContraseña.PasswordChar = '*';
        }

        private void textBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                textBoxContraseña.Text = "Contraseña";
                textBoxContraseña.ForeColor = Color.LightGray;
                textBoxContraseña.PasswordChar = '\0';
            }

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
