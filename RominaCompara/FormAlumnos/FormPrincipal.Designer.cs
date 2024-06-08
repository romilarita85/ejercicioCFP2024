namespace FormAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            lst_alumnos = new ListBox();
            lbl_alumnos = new Label();
            btn_agregar = new Button();
            lbl_informacion = new Label();
            btn_agregarMateria = new Button();
            lst_materias = new ListBox();
            btn_estadoAcademico = new Button();
            SuspendLayout();
            // 
            // lst_alumnos
            // 
            lst_alumnos.BackColor = Color.LemonChiffon;
            lst_alumnos.FormattingEnabled = true;
            lst_alumnos.ItemHeight = 15;
            lst_alumnos.Location = new Point(65, 65);
            lst_alumnos.Name = "lst_alumnos";
            lst_alumnos.Size = new Size(216, 409);
            lst_alumnos.TabIndex = 0;
            // 
            // lbl_alumnos
            // 
            lbl_alumnos.AutoSize = true;
            lbl_alumnos.BackColor = Color.Transparent;
            lbl_alumnos.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_alumnos.ForeColor = Color.Black;
            lbl_alumnos.ImageAlign = ContentAlignment.TopRight;
            lbl_alumnos.Location = new Point(123, 28);
            lbl_alumnos.Name = "lbl_alumnos";
            lbl_alumnos.Size = new Size(103, 25);
            lbl_alumnos.TabIndex = 2;
            lbl_alumnos.Text = "Alumnos";
            lbl_alumnos.TextAlign = ContentAlignment.BottomRight;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.MediumSpringGreen;
            btn_agregar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(95, 489);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(153, 44);
            btn_agregar.TabIndex = 3;
            btn_agregar.Text = "Agregar alumno";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // lbl_informacion
            // 
            lbl_informacion.AutoSize = true;
            lbl_informacion.BackColor = Color.Transparent;
            lbl_informacion.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_informacion.Location = new Point(376, 28);
            lbl_informacion.Name = "lbl_informacion";
            lbl_informacion.Size = new Size(98, 25);
            lbl_informacion.TabIndex = 6;
            lbl_informacion.Text = "Materias";
            // 
            // btn_agregarMateria
            // 
            btn_agregarMateria.BackColor = Color.FromArgb(255, 255, 128);
            btn_agregarMateria.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_agregarMateria.ForeColor = Color.Black;
            btn_agregarMateria.ImageAlign = ContentAlignment.TopCenter;
            btn_agregarMateria.Location = new Point(346, 489);
            btn_agregarMateria.Name = "btn_agregarMateria";
            btn_agregarMateria.Size = new Size(153, 44);
            btn_agregarMateria.TabIndex = 8;
            btn_agregarMateria.Text = "Agregar materia";
            btn_agregarMateria.UseVisualStyleBackColor = false;
            btn_agregarMateria.Click += btn_agregarMateria_Click;
            // 
            // lst_materias
            // 
            lst_materias.FormattingEnabled = true;
            lst_materias.ItemHeight = 15;
            lst_materias.Location = new Point(315, 65);
            lst_materias.Name = "lst_materias";
            lst_materias.Size = new Size(216, 409);
            lst_materias.TabIndex = 9;
            // 
            // btn_estadoAcademico
            // 
            btn_estadoAcademico.BackColor = SystemColors.InfoText;
            btn_estadoAcademico.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_estadoAcademico.ForeColor = Color.White;
            btn_estadoAcademico.ImageAlign = ContentAlignment.TopCenter;
            btn_estadoAcademico.Location = new Point(608, 489);
            btn_estadoAcademico.Name = "btn_estadoAcademico";
            btn_estadoAcademico.Size = new Size(153, 44);
            btn_estadoAcademico.TabIndex = 10;
            btn_estadoAcademico.Text = "Crear estado academico";
            btn_estadoAcademico.UseVisualStyleBackColor = false;
            btn_estadoAcademico.Click += btn_estadoAcademico_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 545);
            Controls.Add(btn_estadoAcademico);
            Controls.Add(lst_materias);
            Controls.Add(btn_agregarMateria);
            Controls.Add(lbl_informacion);
            Controls.Add(btn_agregar);
            Controls.Add(lbl_alumnos);
            Controls.Add(lst_alumnos);
            ForeColor = Color.Black;
            Name = "FormPrincipal";
            Text = "Alumnos";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_alumnos;
        private Label lbl_alumnos;
        private Button btn_agregar;
        private Label lbl_informacion;
        private Button btn_agregarMateria;
        private ListBox lst_materias;
        private Button btn_estadoAcademico;
    }
}
