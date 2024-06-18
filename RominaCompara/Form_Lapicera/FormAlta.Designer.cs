namespace Form_Lapicera
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
            gpv_datosLapicera = new GroupBox();
            txt_marca = new TextBox();
            num_precio = new NumericUpDown();
            cmb_colores = new ComboBox();
            lbl_marca = new Label();
            lbl_precio = new Label();
            lbl_color = new Label();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            gpv_datosLapicera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).BeginInit();
            SuspendLayout();
            // 
            // gpv_datosLapicera
            // 
            gpv_datosLapicera.Controls.Add(txt_marca);
            gpv_datosLapicera.Controls.Add(num_precio);
            gpv_datosLapicera.Controls.Add(cmb_colores);
            gpv_datosLapicera.Controls.Add(lbl_marca);
            gpv_datosLapicera.Controls.Add(lbl_precio);
            gpv_datosLapicera.Controls.Add(lbl_color);
            gpv_datosLapicera.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpv_datosLapicera.Location = new Point(43, 50);
            gpv_datosLapicera.Name = "gpv_datosLapicera";
            gpv_datosLapicera.Size = new Size(405, 241);
            gpv_datosLapicera.TabIndex = 0;
            gpv_datosLapicera.TabStop = false;
            gpv_datosLapicera.Text = "Datos de lapicera";
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(190, 155);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(154, 23);
            txt_marca.TabIndex = 6;
            // 
            // num_precio
            // 
            num_precio.Increment = new decimal(new int[] { 200, 0, 0, 0 });
            num_precio.Location = new Point(189, 107);
            num_precio.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            num_precio.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            num_precio.Name = "num_precio";
            num_precio.Size = new Size(155, 23);
            num_precio.TabIndex = 5;
            num_precio.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(189, 59);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(155, 24);
            cmb_colores.TabIndex = 4;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Verdana", 9.75F);
            lbl_marca.Location = new Point(80, 163);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(47, 16);
            lbl_marca.TabIndex = 2;
            lbl_marca.Text = "Marca";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Verdana", 9.75F);
            lbl_precio.Location = new Point(80, 115);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(47, 16);
            lbl_precio.TabIndex = 1;
            lbl_precio.Text = "Precio";
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Font = new Font("Verdana", 9.75F);
            lbl_color.Location = new Point(80, 67);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(40, 16);
            lbl_color.TabIndex = 0;
            lbl_color.Text = "Color";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(85, 333);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(89, 32);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(311, 333);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(89, 32);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(489, 396);
            Controls.Add(btn_agregar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpv_datosLapicera);
            Name = "FormAlta";
            Text = "Alta lapicera";
            Load += FormAlta_Load;
            gpv_datosLapicera.ResumeLayout(false);
            gpv_datosLapicera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpv_datosLapicera;
        private TextBox txt_marca;
        private NumericUpDown num_precio;
        private ComboBox cmb_colores;
        private Label lbl_marca;
        private Label lbl_precio;
        private Label lbl_color;
        private Button btn_cancelar;
        private Button btn_agregar;
    }
}