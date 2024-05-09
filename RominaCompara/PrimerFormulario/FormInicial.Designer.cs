namespace PrimerFormulario
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            text_nombre = new TextBox();
            text_apellido = new TextBox();
            text_password = new TextBox();
            lbl_Nombre = new Label();
            lbl_Apellido = new Label();
            lbl_Password = new Label();
            lst_salida = new ListBox();
            btn_ingresar = new Button();
            btn_borrar = new Button();
            SuspendLayout();
            // 
            // text_nombre
            // 
            text_nombre.BackColor = Color.Lavender;
            text_nombre.ForeColor = SystemColors.WindowText;
            text_nombre.Location = new Point(30, 68);
            text_nombre.Name = "text_nombre";
            text_nombre.PlaceholderText = "Ingrese su nombre";
            text_nombre.Size = new Size(130, 23);
            text_nombre.TabIndex = 0;
            // 
            // text_apellido
            // 
            text_apellido.BackColor = Color.Lavender;
            text_apellido.Location = new Point(30, 122);
            text_apellido.Name = "text_apellido";
            text_apellido.PlaceholderText = "Ingrese su apellido";
            text_apellido.Size = new Size(130, 23);
            text_apellido.TabIndex = 1;
            // 
            // text_password
            // 
            text_password.BackColor = Color.Lavender;
            text_password.Location = new Point(33, 176);
            text_password.Name = "text_password";
            text_password.PasswordChar = '*';
            text_password.PlaceholderText = "Ingrese su contraseña";
            text_password.Size = new Size(127, 23);
            text_password.TabIndex = 2;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.BackColor = Color.WhiteSmoke;
            lbl_Nombre.Location = new Point(33, 45);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.BackColor = SystemColors.ButtonHighlight;
            lbl_Apellido.Location = new Point(33, 99);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 4;
            lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.BackColor = SystemColors.ButtonHighlight;
            lbl_Password.Location = new Point(32, 153);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 5;
            lbl_Password.Text = "Password";
            // 
            // lst_salida
            // 
            lst_salida.BackColor = SystemColors.Control;
            lst_salida.FormattingEnabled = true;
            lst_salida.ItemHeight = 15;
            lst_salida.Location = new Point(208, 56);
            lst_salida.Name = "lst_salida";
            lst_salida.Size = new Size(284, 229);
            lst_salida.TabIndex = 6;
            // 
            // btn_ingresar
            // 
            btn_ingresar.Location = new Point(59, 229);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(75, 23);
            btn_ingresar.TabIndex = 7;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(289, 316);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(104, 39);
            btn_borrar.TabIndex = 8;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(528, 438);
            Controls.Add(btn_borrar);
            Controls.Add(btn_ingresar);
            Controls.Add(lst_salida);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Apellido);
            Controls.Add(lbl_Nombre);
            Controls.Add(text_password);
            Controls.Add(text_apellido);
            Controls.Add(text_nombre);
            Name = "FormInicial";
            StartPosition = FormStartPosition.Manual;
            Tag = "";
            Text = "Bienvenido/a";
            TransparencyKey = Color.PaleTurquoise;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text_nombre;
        private TextBox text_apellido;
        private TextBox text_password;
        private Label lbl_Nombre;
        private Label lbl_Apellido;
        private Label lbl_Password;
        private ListBox lst_salida;
        private Button btn_ingresar;
        private Button btn_borrar;
    }
}
