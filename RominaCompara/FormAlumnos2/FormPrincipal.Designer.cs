namespace FormAlumnos2
{
    partial class FormPrincipal
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
            lbl_materias = new Label();
            lbl_alumnos = new Label();
            lst_alumnos = new ListBox();
            lst_materias = new ListBox();
            btn_agregarAlumno = new Button();
            btn_agregarMateria = new Button();
            btn_crearEstadoAcad = new Button();
            SuspendLayout();
            // 
            // lbl_materias
            // 
            lbl_materias.AutoSize = true;
            lbl_materias.Location = new Point(295, 38);
            lbl_materias.Name = "lbl_materias";
            lbl_materias.Size = new Size(52, 15);
            lbl_materias.TabIndex = 0;
            lbl_materias.Text = "Materias";
            // 
            // lbl_alumnos
            // 
            lbl_alumnos.AutoSize = true;
            lbl_alumnos.Location = new Point(116, 38);
            lbl_alumnos.Name = "lbl_alumnos";
            lbl_alumnos.Size = new Size(55, 15);
            lbl_alumnos.TabIndex = 1;
            lbl_alumnos.Text = "Alumnos";
            // 
            // lst_alumnos
            // 
            lst_alumnos.FormattingEnabled = true;
            lst_alumnos.ItemHeight = 15;
            lst_alumnos.Location = new Point(62, 73);
            lst_alumnos.Name = "lst_alumnos";
            lst_alumnos.Size = new Size(160, 274);
            lst_alumnos.TabIndex = 2;
            // 
            // lst_materias
            // 
            lst_materias.FormattingEnabled = true;
            lst_materias.ItemHeight = 15;
            lst_materias.Location = new Point(239, 73);
            lst_materias.Name = "lst_materias";
            lst_materias.Size = new Size(160, 274);
            lst_materias.TabIndex = 3;
            // 
            // btn_agregarAlumno
            // 
            btn_agregarAlumno.Location = new Point(89, 372);
            btn_agregarAlumno.Name = "btn_agregarAlumno";
            btn_agregarAlumno.Size = new Size(107, 43);
            btn_agregarAlumno.TabIndex = 4;
            btn_agregarAlumno.Text = "Agregar alumno";
            btn_agregarAlumno.UseVisualStyleBackColor = true;
            btn_agregarAlumno.Click += btn_agregarAlumno_Click;
            // 
            // btn_agregarMateria
            // 
            btn_agregarMateria.Location = new Point(265, 372);
            btn_agregarMateria.Name = "btn_agregarMateria";
            btn_agregarMateria.Size = new Size(107, 43);
            btn_agregarMateria.TabIndex = 5;
            btn_agregarMateria.Text = "Agregar materia";
            btn_agregarMateria.UseVisualStyleBackColor = true;
            btn_agregarMateria.Click += btn_agregarMateria_Click;
            // 
            // btn_crearEstadoAcad
            // 
            btn_crearEstadoAcad.Location = new Point(477, 372);
            btn_crearEstadoAcad.Name = "btn_crearEstadoAcad";
            btn_crearEstadoAcad.Size = new Size(107, 43);
            btn_crearEstadoAcad.TabIndex = 6;
            btn_crearEstadoAcad.Text = "Crear estado academico";
            btn_crearEstadoAcad.UseVisualStyleBackColor = true;
            btn_crearEstadoAcad.Click += btn_crearEstadoAcad_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 450);
            Controls.Add(btn_crearEstadoAcad);
            Controls.Add(btn_agregarMateria);
            Controls.Add(btn_agregarAlumno);
            Controls.Add(lst_materias);
            Controls.Add(lst_alumnos);
            Controls.Add(lbl_alumnos);
            Controls.Add(lbl_materias);
            Name = "FormPrincipal";
            Text = "Alumnos";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_materias;
        private Label lbl_alumnos;
        private ListBox lst_alumnos;
        private ListBox lst_materias;
        private Button btn_agregarAlumno;
        private Button btn_agregarMateria;
        private Button btn_crearEstadoAcad;
    }
}
