namespace FormLapiceras
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
 

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpb_datosLapicera = new GroupBox();
            cmb_color = new ComboBox();
            lbl_color = new Label();
            lbl_precio = new Label();
            lbl_marca = new Label();
            lbl_nivelDeTinta = new Label();
            num_precio = new NumericUpDown();
            txt_marca = new TextBox();
            num_nivelDeTinta = new NumericUpDown();
            btn_cancelar = new Button();
            btn_agregar = new Button();
            gpb_datosLapicera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_precio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_nivelDeTinta).BeginInit();

            // 
            // gpb_datosLapicera
            // 
            gpb_datosLapicera.Controls.Add(num_nivelDeTinta);
            gpb_datosLapicera.Controls.Add(txt_marca);
            gpb_datosLapicera.Controls.Add(num_precio);
            gpb_datosLapicera.Controls.Add(lbl_nivelDeTinta);
            gpb_datosLapicera.Controls.Add(lbl_marca);
            gpb_datosLapicera.Controls.Add(lbl_precio);
            gpb_datosLapicera.Controls.Add(lbl_color);
            gpb_datosLapicera.Controls.Add(cmb_color);
            gpb_datosLapicera.Location = new Point(26, 43);
            gpb_datosLapicera.Name = "gpb_datosLapicera";
            gpb_datosLapicera.Size = new Size(409, 199);
            gpb_datosLapicera.TabIndex = 0;
            gpb_datosLapicera.TabStop = false;
            gpb_datosLapicera.Text = "Datos de lapicera";
            // 
            // cmb_color
            // 
            cmb_color.FormattingEnabled = true;
            cmb_color.Location = new Point(171, 37);
            cmb_color.Name = "cmb_color";
            cmb_color.Size = new Size(169, 23);
            cmb_color.TabIndex = 0;
            // 
            // lbl_color
            // 
            lbl_color.AutoSize = true;
            lbl_color.Location = new Point(62, 45);
            lbl_color.Name = "lbl_color";
            lbl_color.Size = new Size(36, 15);
            lbl_color.TabIndex = 1;
            lbl_color.Text = "Color";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Location = new Point(62, 82);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(40, 15);
            lbl_precio.TabIndex = 2;
            lbl_precio.Text = "Precio";
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Location = new Point(62, 116);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(40, 15);
            lbl_marca.TabIndex = 3;
            lbl_marca.Text = "Marca";
            // 
            // lbl_nivelDeTinta
            // 
            lbl_nivelDeTinta.AutoSize = true;
            lbl_nivelDeTinta.Location = new Point(62, 157);
            lbl_nivelDeTinta.Name = "lbl_nivelDeTinta";
            lbl_nivelDeTinta.Size = new Size(77, 15);
            lbl_nivelDeTinta.TabIndex = 4;
            lbl_nivelDeTinta.Text = "Nivel de tinta";
            // 
            // num_precio
            // 
            num_precio.Location = new Point(171, 74);
            num_precio.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            num_precio.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            num_precio.Name = "num_precio";
            num_precio.Size = new Size(169, 23);
            num_precio.TabIndex = 1;
            num_precio.Value = new decimal(new int[] { 1500, 0, 0, 0 });
            // 
            // txt_marca
            // 
            txt_marca.Location = new Point(171, 108);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(169, 23);
            txt_marca.TabIndex = 1;
            // 
            // num_nivelDeTinta
            // 
            num_nivelDeTinta.Location = new Point(171, 149);
            num_nivelDeTinta.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            num_nivelDeTinta.Name = "num_nivelDeTinta";
            num_nivelDeTinta.Size = new Size(169, 23);
            num_nivelDeTinta.TabIndex = 5;
            num_nivelDeTinta.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(52, 260);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(98, 35);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(300, 260);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(98, 35);
            btn_agregar.TabIndex = 2;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            // 

        }

        #endregion

        private GroupBox gpb_datosLapicera;
        private Label lbl_nivelDeTinta;
        private Label lbl_marca;
        private Label lbl_precio;
        private Label lbl_color;
        private ComboBox cmb_color;
        private NumericUpDown num_precio;
        private NumericUpDown num_nivelDeTinta;
        private TextBox txt_marca;
        private Button btn_cancelar;
        private Button btn_agregar;
    }
}