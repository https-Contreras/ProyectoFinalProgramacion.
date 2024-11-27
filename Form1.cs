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

        private void textBoxContrase�a_Enter(object sender, EventArgs e)
        {
            if (textBoxContrase�a.Text == "Contrase�a")
            {
                textBoxContrase�a.Text = "";
                textBoxContrase�a.ForeColor = Color.LightGray;

            }
            textBoxContrase�a.PasswordChar = '*';
        }

        private void textBoxContrase�a_Leave(object sender, EventArgs e)
        {
            if (textBoxContrase�a.Text == "")
            {
                textBoxContrase�a.Text = "Contrase�a";
                textBoxContrase�a.ForeColor = Color.LightGray;
                textBoxContrase�a.PasswordChar = '\0';
            }

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
