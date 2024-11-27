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
            labelNombreSistema = new Label();
            panel1 = new Panel();
            buttonIngresar = new Button();
            label1 = new Label();
            textBoxContraseña = new TextBox();
            textBoxUsuario = new TextBox();
            labelSlogan = new Label();
            buttonSalir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNombreSistema
            // 
            labelNombreSistema.AutoSize = true;
            labelNombreSistema.Location = new Point(158, 21);
            labelNombreSistema.Name = "labelNombreSistema";
            labelNombreSistema.Size = new Size(94, 20);
            labelNombreSistema.TabIndex = 0;
            labelNombreSistema.Text = "Bite'n Burger";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(buttonSalir);
            panel1.Controls.Add(buttonIngresar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxContraseña);
            panel1.Controls.Add(textBoxUsuario);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(543, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 450);
            panel1.TabIndex = 1;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.IndianRed;
            buttonIngresar.FlatAppearance.BorderSize = 0;
            buttonIngresar.FlatAppearance.MouseDownBackColor = Color.Lime;
            buttonIngresar.FlatAppearance.MouseOverBackColor = Color.Green;
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Location = new Point(127, 305);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(94, 29);
            buttonIngresar.TabIndex = 4;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(104, 21);
            label1.Name = "label1";
            label1.Size = new Size(150, 29);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = Color.Red;
            textBoxContraseña.BorderStyle = BorderStyle.None;
            textBoxContraseña.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxContraseña.ForeColor = Color.LightGray;
            textBoxContraseña.Location = new Point(72, 233);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(200, 18);
            textBoxContraseña.TabIndex = 2;
            textBoxContraseña.Text = "Contraseña";
            textBoxContraseña.TextAlign = HorizontalAlignment.Center;
            textBoxContraseña.Enter += textBoxContraseña_Enter;
            textBoxContraseña.Leave += textBoxContraseña_Leave;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.Red;
            textBoxUsuario.BorderStyle = BorderStyle.None;
            textBoxUsuario.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsuario.ForeColor = Color.LightGray;
            textBoxUsuario.Location = new Point(72, 174);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(200, 18);
            textBoxUsuario.TabIndex = 1;
            textBoxUsuario.Text = "Usuario";
            textBoxUsuario.TextAlign = HorizontalAlignment.Center;
            textBoxUsuario.Enter += textBoxUsuario_Enter;
            textBoxUsuario.Leave += textBoxUsuario_Leave;
            // 
            // labelSlogan
            // 
            labelSlogan.AutoSize = true;
            labelSlogan.Location = new Point(121, 53);
            labelSlogan.Name = "labelSlogan";
            labelSlogan.Size = new Size(146, 20);
            labelSlogan.TabIndex = 1;
            labelSlogan.Text = "Muerde la diferencia";
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.IndianRed;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            buttonSalir.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            buttonSalir.FlatStyle = FlatStyle.Flat;
            buttonSalir.Location = new Point(127, 378);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(94, 29);
            buttonSalir.TabIndex = 5;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            // 
            // Presentacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(891, 450);
            Controls.Add(panel1);
            Controls.Add(labelSlogan);
            Controls.Add(labelNombreSistema);
            Name = "Presentacion";
            Text = "Presentacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombreSistema;
        private Panel panel1;
        private Label labelSlogan;
        private TextBox textBoxUsuario;
        private Button buttonIngresar;
        private Label label1;
        private TextBox textBoxContraseña;
        private Button buttonSalir;
    }
}
