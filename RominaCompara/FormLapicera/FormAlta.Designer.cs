namespace FormLapicera
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
            gpb_datosLapicera = new GroupBox();
            num_precio = new NumericUpDown();
            txt_marca = new TextBox();
            cmb_colores = new ComboBox();
            lbl_marca = new Label();
            lbl_precio = new Label();
            lbl_color = new Label();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            gpb_datosLapicera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).BeginInit();
            SuspendLayout();
            // 
            // gpb_datosLapicera
            // 
            gpb_datosLapicera.Controls.Add(num_precio);
            gpb_datosLapicera.Controls.Add(txt_marca);
            gpb_datosLapicera.Controls.Add(cmb_colores);
            gpb_datosLapicera.Controls.Add(lbl_marca);
            gpb_datosLapicera.Controls.Add(lbl_precio);
            gpb_datosLapicera.Controls.Add(lbl_color);
            gpb_datosLapicera.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpb_datosLapicera.Location = new Point(60, 63);
            gpb_datosLapicera.Name = "gpb_datosLapicera";
            gpb_datosLapicera.Size = new Size(395, 231);
            gpb_datosLapicera.TabIndex = 0;
            gpb_datosLapicera.TabStop = false;
            gpb_datosLapicera.Text = "Datos de lapicera";
            // 
            // num_precio
            // 
            num_precio.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            num_precio.Location = new Point(166, 100);
            num_precio.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            num_precio.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            num_precio.Name = "num_precio";
            num_precio.Size = new Size(149, 23);
            num_precio.TabIndex = 5;
            num_precio.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(166, 134);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(149, 23);
            txt_marca.TabIndex = 4;
            // 
            // cmb_colores
            // 
            cmb_colores.FormattingEnabled = true;
            cmb_colores.Location = new Point(165, 64);
            cmb_colores.Name = "cmb_colores";
            cmb_colores.Size = new Size(150, 24);
            cmb_colores.TabIndex = 3;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Verdana", 9.75F);
            lbl_marca.Location = new Point(77, 142);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(47, 16);
            lbl_marca.TabIndex = 2;
            lbl_marca.Text = "Marca";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Verdana", 9.75F);
            lbl_precio.Location = new Point(77, 108);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(47, 16);
            lbl_precio.TabIndex = 1;
            lbl_precio.Text = "Precio";
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Font = new Font("Verdana", 9.75F);
            lbl_color.Location = new Point(77, 72);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(40, 16);
            lbl_color.TabIndex = 0;
            lbl_color.Text = "Color";
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(103, 330);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(82, 29);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(324, 330);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(82, 29);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 396);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(gpb_datosLapicera);
            Name = "FormAlta";
            Text = "Alta lapicera";
            Load += FormAlta_Load;
            gpb_datosLapicera.ResumeLayout(false);
            gpb_datosLapicera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpb_datosLapicera;
        private Label lbl_marca;
        private Label lbl_precio;
        private Label lbl_color;
        private TextBox txt_marca;
        private ComboBox cmb_colores;
        private NumericUpDown num_precio;
        private Button btn_cancelar;
        private Button btn_aceptar;
    }
}