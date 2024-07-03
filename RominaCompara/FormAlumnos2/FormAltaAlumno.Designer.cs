namespace FormAlumnos2
{
    partial class FormAltaAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_legajo = new Label();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            txt_legajo = new TextBox();
            txt_nombre = new TextBox();
            txt_apellido = new TextBox();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            SuspendLayout();
            // 
            // lbl_legajo
            // 
            lbl_legajo.AutoSize = true;
            lbl_legajo.Location = new Point(78, 81);
            lbl_legajo.Name = "lbl_legajo";
            lbl_legajo.Size = new Size(42, 15);
            lbl_legajo.TabIndex = 0;
            lbl_legajo.Text = "Legajo";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(78, 134);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 1;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(78, 180);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 2;
            lbl_apellido.Text = "Apellido";
            // 
            // txt_legajo
            // 
            txt_legajo.Location = new Point(193, 73);
            txt_legajo.Name = "txt_legajo";
            txt_legajo.Size = new Size(100, 23);
            txt_legajo.TabIndex = 3;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(193, 126);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(100, 23);
            txt_nombre.TabIndex = 4;
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(193, 172);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(100, 23);
            txt_apellido.TabIndex = 5;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(78, 235);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 6;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(218, 235);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 7;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormAltaAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 324);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(txt_apellido);
            Controls.Add(txt_nombre);
            Controls.Add(txt_legajo);
            Controls.Add(lbl_apellido);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_legajo);
            Name = "FormAltaAlumno";
            Text = "Alta alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_legajo;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private TextBox txt_legajo;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private Button btn_cancelar;
        private Button btn_agregar;
    }
}