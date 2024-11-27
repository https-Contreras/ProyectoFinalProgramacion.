namespace ProyectoProgra
{
    partial class Presentacion
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
            components = new System.ComponentModel.Container();
            timerFechaHora = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timerFechaHora
            // 
            timerFechaHora.Interval = 1000;
            timerFechaHora.Tick += timerFechaHora_Tick;
            // 
            // Presentacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Name = "Presentacion";
            Text = "Presentacion";
            Load += Presentacion_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerFechaHora;
    }
}
