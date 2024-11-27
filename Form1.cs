namespace ProyectoProgra
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
            timerFechaHora.Start();
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Limpia el área del formulario antes de dibujar
            g.Clear(this.BackColor);

            // Crear un degradado lineal para el fondo
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                new Point(0, 0),
                new Point(this.ClientSize.Width, this.ClientSize.Height),
                Color.LightBlue, // Color inicial
                Color.DarkBlue   // Color final
            ))
            {
                // Dibujar el fondo completo del formulario
                g.FillRectangle(brush, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            }


        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // Forzar redibujado del formulario
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }
    }
}
