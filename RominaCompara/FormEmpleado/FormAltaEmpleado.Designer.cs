namespace FormEmpleado
{
    partial class FormAltaEmpleado
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
            lbl_nombre = new Label();
            txt_nombre = new TextBox();
            num_salario = new NumericUpDown();
            lbl_salario = new Label();
            lbl_antiguedad = new Label();
            gpb_departamentos = new GroupBox();
            rdb_rrhh = new RadioButton();
            rdb_administracion = new RadioButton();
            rdb_sistemas = new RadioButton();
            rdb_contabilidad = new RadioButton();
            rdb_finanzas = new RadioButton();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            num_antiguedad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num_salario).BeginInit();
            gpb_departamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_antiguedad).BeginInit();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(50, 52);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(152, 52);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Ingrese su nombre";
            txt_nombre.Size = new Size(175, 23);
            txt_nombre.TabIndex = 1;
            // 
            // num_salario
            // 
            num_salario.Location = new Point(466, 50);
            num_salario.Maximum = new decimal(new int[] { 900000, 0, 0, 0 });
            num_salario.Minimum = new decimal(new int[] { 200000, 0, 0, 0 });
            num_salario.Name = "num_salario";
            num_salario.Size = new Size(175, 23);
            num_salario.TabIndex = 2;
            num_salario.Value = new decimal(new int[] { 200000, 0, 0, 0 });
            // 
            // lbl_salario
            // 
            lbl_salario.AutoSize = true;
            lbl_salario.Location = new Point(364, 55);
            lbl_salario.Name = "lbl_salario";
            lbl_salario.Size = new Size(42, 15);
            lbl_salario.TabIndex = 3;
            lbl_salario.Text = "Salario";
            // 
            // lbl_antiguedad
            // 
            lbl_antiguedad.AutoSize = true;
            lbl_antiguedad.Location = new Point(364, 130);
            lbl_antiguedad.Name = "lbl_antiguedad";
            lbl_antiguedad.Size = new Size(69, 15);
            lbl_antiguedad.TabIndex = 4;
            lbl_antiguedad.Text = "Antiguedad";
            // 
            // gpb_departamentos
            // 
            gpb_departamentos.Controls.Add(rdb_rrhh);
            gpb_departamentos.Controls.Add(rdb_administracion);
            gpb_departamentos.Controls.Add(rdb_sistemas);
            gpb_departamentos.Controls.Add(rdb_contabilidad);
            gpb_departamentos.Controls.Add(rdb_finanzas);
            gpb_departamentos.Location = new Point(50, 98);
            gpb_departamentos.Name = "gpb_departamentos";
            gpb_departamentos.Size = new Size(234, 170);
            gpb_departamentos.TabIndex = 8;
            gpb_departamentos.TabStop = false;
            gpb_departamentos.Text = "Departamento";
            // 
            // rdb_rrhh
            // 
            rdb_rrhh.AutoSize = true;
            rdb_rrhh.Location = new Point(66, 128);
            rdb_rrhh.Name = "rdb_rrhh";
            rdb_rrhh.Size = new Size(127, 19);
            rdb_rrhh.TabIndex = 4;
            rdb_rrhh.TabStop = true;
            rdb_rrhh.Text = "Recursos Humanos";
            rdb_rrhh.UseVisualStyleBackColor = true;
            // 
            // rdb_administracion
            // 
            rdb_administracion.AutoSize = true;
            rdb_administracion.Location = new Point(66, 103);
            rdb_administracion.Name = "rdb_administracion";
            rdb_administracion.Size = new Size(106, 19);
            rdb_administracion.TabIndex = 3;
            rdb_administracion.TabStop = true;
            rdb_administracion.Text = "Administracion";
            rdb_administracion.UseVisualStyleBackColor = true;
            // 
            // rdb_sistemas
            // 
            rdb_sistemas.AutoSize = true;
            rdb_sistemas.Location = new Point(66, 78);
            rdb_sistemas.Name = "rdb_sistemas";
            rdb_sistemas.Size = new Size(71, 19);
            rdb_sistemas.TabIndex = 2;
            rdb_sistemas.TabStop = true;
            rdb_sistemas.Text = "Sistemas";
            rdb_sistemas.UseVisualStyleBackColor = true;
            // 
            // rdb_contabilidad
            // 
            rdb_contabilidad.AutoSize = true;
            rdb_contabilidad.Location = new Point(66, 53);
            rdb_contabilidad.Name = "rdb_contabilidad";
            rdb_contabilidad.Size = new Size(93, 19);
            rdb_contabilidad.TabIndex = 1;
            rdb_contabilidad.TabStop = true;
            rdb_contabilidad.Text = "Contabilidad";
            rdb_contabilidad.UseVisualStyleBackColor = true;
            // 
            // rdb_finanzas
            // 
            rdb_finanzas.AutoSize = true;
            rdb_finanzas.Location = new Point(66, 28);
            rdb_finanzas.Name = "rdb_finanzas";
            rdb_finanzas.Size = new Size(70, 19);
            rdb_finanzas.TabIndex = 0;
            rdb_finanzas.TabStop = true;
            rdb_finanzas.Text = "Finanzas";
            rdb_finanzas.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(364, 232);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(87, 36);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(554, 232);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(87, 36);
            btn_agregar.TabIndex = 10;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // num_antiguedad
            // 
            num_antiguedad.Location = new Point(466, 130);
            num_antiguedad.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            num_antiguedad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_antiguedad.Name = "num_antiguedad";
            num_antiguedad.Size = new Size(175, 23);
            num_antiguedad.TabIndex = 11;
            num_antiguedad.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // FormAltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 299);
            Controls.Add(num_antiguedad);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpb_departamentos);
            Controls.Add(lbl_antiguedad);
            Controls.Add(lbl_salario);
            Controls.Add(num_salario);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_nombre);
            Name = "FormAltaEmpleado";
            Text = "Alta Empleado";
            Load += FormAltaEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)num_salario).EndInit();
            gpb_departamentos.ResumeLayout(false);
            gpb_departamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_antiguedad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private TextBox txt_nombre;
        private NumericUpDown num_salario;
        private Label lbl_salario;
        private Label lbl_antiguedad;
        private GroupBox gpb_departamentos;
        private RadioButton rdb_administracion;
        private RadioButton rdb_sistemas;
        private RadioButton rdb_contabilidad;
        private RadioButton rdb_finanzas;
        private Button btn_cancelar;
        private Button btn_agregar;
        private NumericUpDown num_antiguedad;
        private RadioButton rdb_rrhh;
    }
}