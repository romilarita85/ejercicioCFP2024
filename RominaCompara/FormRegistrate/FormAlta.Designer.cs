namespace FormRegistrate
{
    partial class FormAlta
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
            gpb_datosIngresante = new GroupBox();
            num_edad = new NumericUpDown();
            lbl_edad = new Label();
            lbl_nombre = new Label();
            lbl_apellido = new Label();
            txt_apellido = new TextBox();
            txt_nombre = new TextBox();
            gpv_genero = new GroupBox();
            rdb_noBinario = new RadioButton();
            rbd_femenino = new RadioButton();
            rdb_masculino = new RadioButton();
            gpb_cursos = new GroupBox();
            chk_javascript = new CheckBox();
            chk_node = new CheckBox();
            chk_phyton = new CheckBox();
            chk_angular = new CheckBox();
            chk_sicharp = new CheckBox();
            lst_paises = new ListBox();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            lbl_pais = new Label();
            gpb_datosIngresante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).BeginInit();
            gpv_genero.SuspendLayout();
            gpb_cursos.SuspendLayout();
            SuspendLayout();
            // 
            // gpb_datosIngresante
            // 
            gpb_datosIngresante.Controls.Add(num_edad);
            gpb_datosIngresante.Controls.Add(lbl_edad);
            gpb_datosIngresante.Controls.Add(lbl_nombre);
            gpb_datosIngresante.Controls.Add(lbl_apellido);
            gpb_datosIngresante.Controls.Add(txt_apellido);
            gpb_datosIngresante.Controls.Add(txt_nombre);
            gpb_datosIngresante.Location = new Point(50, 26);
            gpb_datosIngresante.Name = "gpb_datosIngresante";
            gpb_datosIngresante.Size = new Size(290, 189);
            gpb_datosIngresante.TabIndex = 0;
            gpb_datosIngresante.TabStop = false;
            gpb_datosIngresante.Text = "Datos del ingresante";
            // 
            // num_edad
            // 
            num_edad.Location = new Point(97, 124);
            num_edad.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            num_edad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_edad.Name = "num_edad";
            num_edad.Size = new Size(155, 23);
            num_edad.TabIndex = 2;
            num_edad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_edad
            // 
            lbl_edad.AutoSize = true;
            lbl_edad.Location = new Point(27, 126);
            lbl_edad.Name = "lbl_edad";
            lbl_edad.Size = new Size(33, 15);
            lbl_edad.TabIndex = 4;
            lbl_edad.Text = "Edad";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Location = new Point(27, 45);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(51, 15);
            lbl_nombre.TabIndex = 2;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Location = new Point(27, 86);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(51, 15);
            lbl_apellido.TabIndex = 3;
            lbl_apellido.Text = "Apellido";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(97, 83);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.PlaceholderText = "Ingrese su apellido";
            txt_apellido.Size = new Size(155, 23);
            txt_apellido.TabIndex = 1;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(97, 42);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Ingrese su nombre";
            txt_nombre.Size = new Size(155, 23);
            txt_nombre.TabIndex = 0;
            // 
            // gpv_genero
            // 
            gpv_genero.Controls.Add(rdb_noBinario);
            gpv_genero.Controls.Add(rbd_femenino);
            gpv_genero.Controls.Add(rdb_masculino);
            gpv_genero.Location = new Point(370, 26);
            gpv_genero.Name = "gpv_genero";
            gpv_genero.Size = new Size(195, 124);
            gpv_genero.TabIndex = 0;
            gpv_genero.TabStop = false;
            gpv_genero.Text = "Genero";
            // 
            // rdb_noBinario
            // 
            rdb_noBinario.AutoSize = true;
            rdb_noBinario.Location = new Point(19, 83);
            rdb_noBinario.Name = "rdb_noBinario";
            rdb_noBinario.Size = new Size(81, 19);
            rdb_noBinario.TabIndex = 2;
            rdb_noBinario.TabStop = true;
            rdb_noBinario.Text = "No binario";
            rdb_noBinario.UseVisualStyleBackColor = true;
            // 
            // rbd_femenino
            // 
            rbd_femenino.AutoSize = true;
            rbd_femenino.Location = new Point(19, 56);
            rbd_femenino.Name = "rbd_femenino";
            rbd_femenino.Size = new Size(78, 19);
            rbd_femenino.TabIndex = 1;
            rbd_femenino.TabStop = true;
            rbd_femenino.Text = "Femenino";
            rbd_femenino.UseVisualStyleBackColor = true;
            // 
            // rdb_masculino
            // 
            rdb_masculino.AutoSize = true;
            rdb_masculino.Location = new Point(19, 31);
            rdb_masculino.Name = "rdb_masculino";
            rdb_masculino.Size = new Size(80, 19);
            rdb_masculino.TabIndex = 0;
            rdb_masculino.TabStop = true;
            rdb_masculino.Text = "Masculino";
            rdb_masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_cursos
            // 
            gpb_cursos.Controls.Add(chk_javascript);
            gpb_cursos.Controls.Add(chk_node);
            gpb_cursos.Controls.Add(chk_phyton);
            gpb_cursos.Controls.Add(chk_angular);
            gpb_cursos.Controls.Add(chk_sicharp);
            gpb_cursos.Location = new Point(370, 174);
            gpb_cursos.Name = "gpb_cursos";
            gpb_cursos.Size = new Size(195, 174);
            gpb_cursos.TabIndex = 0;
            gpb_cursos.TabStop = false;
            gpb_cursos.Text = "Cursos";
            // 
            // chk_javascript
            // 
            chk_javascript.AutoSize = true;
            chk_javascript.Location = new Point(19, 137);
            chk_javascript.Name = "chk_javascript";
            chk_javascript.Size = new Size(78, 19);
            chk_javascript.TabIndex = 4;
            chk_javascript.Text = "JavaScript";
            chk_javascript.UseVisualStyleBackColor = true;
            // 
            // chk_node
            // 
            chk_node.AutoSize = true;
            chk_node.Location = new Point(19, 111);
            chk_node.Name = "chk_node";
            chk_node.Size = new Size(66, 19);
            chk_node.TabIndex = 3;
            chk_node.Text = "Node.js";
            chk_node.UseVisualStyleBackColor = true;
            // 
            // chk_phyton
            // 
            chk_phyton.AutoSize = true;
            chk_phyton.Location = new Point(19, 86);
            chk_phyton.Name = "chk_phyton";
            chk_phyton.Size = new Size(64, 19);
            chk_phyton.TabIndex = 2;
            chk_phyton.Text = "Phyton";
            chk_phyton.UseVisualStyleBackColor = true;
            // 
            // chk_angular
            // 
            chk_angular.AutoSize = true;
            chk_angular.Location = new Point(19, 61);
            chk_angular.Name = "chk_angular";
            chk_angular.Size = new Size(68, 19);
            chk_angular.TabIndex = 1;
            chk_angular.Text = "Angular";
            chk_angular.UseVisualStyleBackColor = true;
            // 
            // chk_sicharp
            // 
            chk_sicharp.AutoSize = true;
            chk_sicharp.Location = new Point(19, 36);
            chk_sicharp.Name = "chk_sicharp";
            chk_sicharp.Size = new Size(41, 19);
            chk_sicharp.TabIndex = 0;
            chk_sicharp.Text = "C#";
            chk_sicharp.UseVisualStyleBackColor = true;
            // 
            // lst_paises
            // 
            lst_paises.FormattingEnabled = true;
            lst_paises.ItemHeight = 15;
            lst_paises.Location = new Point(50, 270);
            lst_paises.Name = "lst_paises";
            lst_paises.Size = new Size(290, 124);
            lst_paises.TabIndex = 1;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(370, 374);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 0;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(490, 374);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(75, 23);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // lbl_pais
            // 
            lbl_pais.AutoSize = true;
            lbl_pais.Location = new Point(50, 239);
            lbl_pais.Name = "lbl_pais";
            lbl_pais.Size = new Size(28, 15);
            lbl_pais.TabIndex = 4;
            lbl_pais.Text = "Pais";
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 422);
            Controls.Add(lbl_pais);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_agregar);
            Controls.Add(lst_paises);
            Controls.Add(gpv_genero);
            Controls.Add(gpb_cursos);
            Controls.Add(gpb_datosIngresante);
            Name = "FormAlta";
            Text = "Alta";
            Load += FormAlta_Load;
            gpb_datosIngresante.ResumeLayout(false);
            gpb_datosIngresante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_edad).EndInit();
            gpv_genero.ResumeLayout(false);
            gpv_genero.PerformLayout();
            gpb_cursos.ResumeLayout(false);
            gpb_cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpb_datosIngresante;
        private GroupBox gpv_genero;
        private GroupBox gpb_cursos;
        private NumericUpDown num_edad;
        private TextBox txt_apellido;
        private TextBox txt_nombre;
        private RadioButton rdb_noBinario;
        private RadioButton rbd_femenino;
        private RadioButton rdb_masculino;
        private CheckBox chk_javascript;
        private CheckBox chk_node;
        private CheckBox chk_phyton;
        private CheckBox chk_angular;
        private CheckBox chk_sicharp;
        private ListBox lst_paises;
        private Button btn_cancelar;
        private Button btn_agregar;
        private Label lbl_edad;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Label lbl_pais;
    }
}