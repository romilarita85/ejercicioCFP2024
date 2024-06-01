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
            btn_evaluar = new Button();
            btn_mostrar = new Button();
            lbl_informacion = new Label();
            dgv_informacion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_informacion).BeginInit();
            SuspendLayout();
            // 
            // lst_alumnos
            // 
            lst_alumnos.BackColor = Color.LemonChiffon;
            lst_alumnos.FormattingEnabled = true;
            lst_alumnos.ItemHeight = 15;
            lst_alumnos.Location = new Point(51, 70);
            lst_alumnos.Name = "lst_alumnos";
            lst_alumnos.Size = new Size(216, 334);
            lst_alumnos.TabIndex = 0;
            // 
            // lbl_alumnos
            // 
            lbl_alumnos.AutoSize = true;
            lbl_alumnos.BackColor = Color.Transparent;
            lbl_alumnos.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_alumnos.ForeColor = Color.Black;
            lbl_alumnos.ImageAlign = ContentAlignment.TopRight;
            lbl_alumnos.Location = new Point(108, 37);
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
            btn_agregar.Location = new Point(93, 416);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(132, 44);
            btn_agregar.TabIndex = 3;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            // 
            // btn_evaluar
            // 
            btn_evaluar.BackColor = Color.FromArgb(255, 255, 128);
            btn_evaluar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_evaluar.ForeColor = Color.Black;
            btn_evaluar.ImageAlign = ContentAlignment.TopCenter;
            btn_evaluar.Location = new Point(415, 416);
            btn_evaluar.Name = "btn_evaluar";
            btn_evaluar.Size = new Size(137, 44);
            btn_evaluar.TabIndex = 4;
            btn_evaluar.Text = "Evaluar";
            btn_evaluar.UseVisualStyleBackColor = false;
            // 
            // btn_mostrar
            // 
            btn_mostrar.BackColor = SystemColors.InfoText;
            btn_mostrar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_mostrar.ForeColor = Color.Transparent;
            btn_mostrar.Location = new Point(669, 416);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(137, 44);
            btn_mostrar.TabIndex = 5;
            btn_mostrar.Text = "Mostrar";
            btn_mostrar.UseVisualStyleBackColor = false;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // lbl_informacion
            // 
            lbl_informacion.AutoSize = true;
            lbl_informacion.BackColor = Color.Transparent;
            lbl_informacion.Font = new Font("Harrington", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_informacion.Location = new Point(596, 37);
            lbl_informacion.Name = "lbl_informacion";
            lbl_informacion.Size = new Size(134, 25);
            lbl_informacion.TabIndex = 6;
            lbl_informacion.Text = "Informacion";
            // 
            // dgv_informacion
            // 
            dgv_informacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_informacion.BackgroundColor = Color.LemonChiffon;
            dgv_informacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_informacion.Location = new Point(296, 70);
            dgv_informacion.Name = "dgv_informacion";
            dgv_informacion.Size = new Size(740, 334);
            dgv_informacion.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1060, 483);
            Controls.Add(dgv_informacion);
            Controls.Add(lbl_informacion);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_evaluar);
            Controls.Add(btn_agregar);
            Controls.Add(lbl_alumnos);
            Controls.Add(lst_alumnos);
            ForeColor = Color.Black;
            Name = "FormPrincipal";
            Text = "Alumnos";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_informacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lst_alumnos;
        private Label lbl_alumnos;
        private Button btn_agregar;
        private Button btn_evaluar;
        private Button btn_mostrar;
        private Label lbl_informacion;
        private DataGridView dgv_informacion;
    }
}
