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
            lbl_departamento = new Label();
            lst_departamentos = new ListBox();
            gpb_antiguedad = new GroupBox();
            rdb_16a20 = new RadioButton();
            rdb_11a15 = new RadioButton();
            rdb_6a10 = new RadioButton();
            rdb_1a5 = new RadioButton();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            ((System.ComponentModel.ISupportInitialize)num_salario).BeginInit();
            gpb_antiguedad.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(50, 61);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(152, 61);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Ingrese su nombre";
            txt_nombre.Size = new Size(175, 23);
            txt_nombre.TabIndex = 1;
            // 
            // num_salario
            // 
            num_salario.Location = new Point(152, 134);
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
            lbl_salario.Location = new Point(50, 139);
            lbl_salario.Name = "lbl_salario";
            lbl_salario.Size = new Size(42, 15);
            lbl_salario.TabIndex = 3;
            lbl_salario.Text = "Salario";
            // 
            // lbl_departamento
            // 
            lbl_departamento.AutoSize = true;
            lbl_departamento.Location = new Point(50, 233);
            lbl_departamento.Name = "lbl_departamento";
            lbl_departamento.Size = new Size(83, 15);
            lbl_departamento.TabIndex = 4;
            lbl_departamento.Text = "Departamento";
            // 
            // lst_departamentos
            // 
            lst_departamentos.FormattingEnabled = true;
            lst_departamentos.ItemHeight = 15;
            lst_departamentos.Location = new Point(152, 236);
            lst_departamentos.Name = "lst_departamentos";
            lst_departamentos.Size = new Size(175, 94);
            lst_departamentos.TabIndex = 5;
            // 
            // gpb_antiguedad
            // 
            gpb_antiguedad.Controls.Add(rdb_16a20);
            gpb_antiguedad.Controls.Add(rdb_11a15);
            gpb_antiguedad.Controls.Add(rdb_6a10);
            gpb_antiguedad.Controls.Add(rdb_1a5);
            gpb_antiguedad.Location = new Point(358, 51);
            gpb_antiguedad.Name = "gpb_antiguedad";
            gpb_antiguedad.Size = new Size(234, 170);
            gpb_antiguedad.TabIndex = 8;
            gpb_antiguedad.TabStop = false;
            gpb_antiguedad.Text = "Antiguedad";
            // 
            // rdb_16a20
            // 
            rdb_16a20.AutoSize = true;
            rdb_16a20.Location = new Point(64, 114);
            rdb_16a20.Name = "rdb_16a20";
            rdb_16a20.Size = new Size(82, 19);
            rdb_16a20.TabIndex = 3;
            rdb_16a20.TabStop = true;
            rdb_16a20.Text = "16-20 años";
            rdb_16a20.UseVisualStyleBackColor = true;
            // 
            // rdb_11a15
            // 
            rdb_11a15.AutoSize = true;
            rdb_11a15.Location = new Point(64, 89);
            rdb_11a15.Name = "rdb_11a15";
            rdb_11a15.Size = new Size(82, 19);
            rdb_11a15.TabIndex = 2;
            rdb_11a15.TabStop = true;
            rdb_11a15.Text = "11-15 años";
            rdb_11a15.UseVisualStyleBackColor = true;
            // 
            // rdb_6a10
            // 
            rdb_6a10.AutoSize = true;
            rdb_6a10.Location = new Point(64, 64);
            rdb_6a10.Name = "rdb_6a10";
            rdb_6a10.Size = new Size(76, 19);
            rdb_6a10.TabIndex = 1;
            rdb_6a10.TabStop = true;
            rdb_6a10.Text = "6-10 años";
            rdb_6a10.UseVisualStyleBackColor = true;
            // 
            // rdb_1a5
            // 
            rdb_1a5.AutoSize = true;
            rdb_1a5.Location = new Point(64, 39);
            rdb_1a5.Name = "rdb_1a5";
            rdb_1a5.Size = new Size(70, 19);
            rdb_1a5.TabIndex = 0;
            rdb_1a5.TabStop = true;
            rdb_1a5.Text = "1-5 años";
            rdb_1a5.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(375, 282);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(87, 36);
            btn_cancelar.TabIndex = 9;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(501, 282);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(87, 36);
            btn_agregar.TabIndex = 10;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormAltaEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 372);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpb_antiguedad);
            Controls.Add(lst_departamentos);
            Controls.Add(lbl_departamento);
            Controls.Add(lbl_salario);
            Controls.Add(num_salario);
            Controls.Add(txt_nombre);
            Controls.Add(lbl_nombre);
            Name = "FormAltaEmpleado";
            Text = "Alta Empleado";
            Load += FormAltaEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)num_salario).EndInit();
            gpb_antiguedad.ResumeLayout(false);
            gpb_antiguedad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nombre;
        private TextBox txt_nombre;
        private NumericUpDown num_salario;
        private Label lbl_salario;
        private Label lbl_departamento;
        private ListBox lst_departamentos;
        private GroupBox gpb_antiguedad;
        private RadioButton rdb_16a20;
        private RadioButton rdb_11a15;
        private RadioButton rdb_6a10;
        private RadioButton rdb_1a5;
        private Button btn_cancelar;
        private Button btn_agregar;
    }
}